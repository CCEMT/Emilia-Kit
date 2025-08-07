using System;
using System.Collections.Generic;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Writer;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace MakeAllPublic
{
    public sealed class MakeAllPublic : Task
    {
        const string VERSION = "v1";

        [Required]
        public string DestinationDirectory { get; set; }

        [Required]
        public string AssembliesToProcess { get; set; }

        [Required]
        public ITaskItem[] ReferencePath { get; set; }

        [Output]
        public ITaskItem[] OutputReferencePath { get; private set; }

        public override bool Execute()
        {
            if (string.IsNullOrWhiteSpace(DestinationDirectory))
            {
                Log.LogMessageFromText(nameof(DestinationDirectory) + " is an empty string", MessageImportance.High);
                return false;
            }

            HashSet<string> assembliesToProcess = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var tmp in AssembliesToProcess.Split(';'))
            {
                var asmName = tmp.Trim();
                var asmSimpleName = asmName;
                int index = asmSimpleName.IndexOf(',');
                if (index >= 0) asmSimpleName = asmSimpleName.Substring(0, index).Trim();
                if (asmSimpleName.Length == 0) continue;
                assembliesToProcess.Add(asmSimpleName);
            }

            OutputReferencePath = new ITaskItem[ReferencePath.Length];

            for (int i = 0; i < ReferencePath.Length; i++)
            {
                ITaskItem file = ReferencePath[i];
                OutputReferencePath[i] = file;
                var filename = file.ItemSpec;
                var fileExt = Path.GetExtension(filename);
                var asmSimpleName = Path.GetFileNameWithoutExtension(filename);

                if (! assembliesToProcess.Contains(asmSimpleName)) continue;

                if (! File.Exists(filename))
                {
                    Log.LogMessageFromText($"File does not exist: {filename}", MessageImportance.High);
                    return false;
                }

                var patchDir = DestinationDirectory;
                Directory.CreateDirectory(patchDir);

                FileInfo fileInfo = new FileInfo(filename);
                long filesize = fileInfo.Length;
                long writeTime = fileInfo.LastWriteTimeUtc.ToBinary();

                var extraInfo = $"_{VERSION} {filesize} {writeTime}_";
                var patchedFilename = Path.Combine(patchDir, asmSimpleName + extraInfo + fileExt);

                if (StringComparer.OrdinalIgnoreCase.Equals(patchedFilename, filename)) continue;

                if (! File.Exists(patchedFilename))
                {
                    try
                    {
                        ProcessAssembly(filename, patchedFilename);
                        Log.LogMessageFromText($"Successfully processed assembly: {asmSimpleName}", MessageImportance.Normal);
                    }
                    catch (Exception ex)
                    {
                        Log.LogMessageFromText($"Error processing assembly '{asmSimpleName}': {ex.Message}", MessageImportance.High);
                        return false;
                    }

                    var xmlDocFile = Path.ChangeExtension(filename, "xml");
                    if (File.Exists(xmlDocFile))
                    {
                        var newXmlDocFile = Path.ChangeExtension(patchedFilename, "xml");
                        if (File.Exists(newXmlDocFile)) File.Delete(newXmlDocFile);
                        File.Copy(xmlDocFile, newXmlDocFile);
                    }
                }

                OutputReferencePath[i] = new TaskItem(patchedFilename);
            }

            return true;
        }

        void ProcessAssembly(string inputPath, string outputPath)
        {
            ModuleDefMD module = ModuleDefMD.Load(inputPath);
            ClassVisibilityPatcher patcher = new ClassVisibilityPatcher(module);
            int modifiedCount = patcher.MakeAllClassesPublic();

            if (modifiedCount > 0)
            {
                Log.LogMessageFromText($"Modified {modifiedCount} types to public in {Path.GetFileNameWithoutExtension(inputPath)}", MessageImportance.Normal);
                ModuleWriterOptions writerOptions = new ModuleWriterOptions(module);
                module.Write(outputPath, writerOptions);
            }
            else
            {
                Log.LogMessageFromText($"No types modified in {Path.GetFileNameWithoutExtension(inputPath)}", MessageImportance.Normal);
                File.Copy(inputPath, outputPath, true);
            }

            module.Dispose();
        }
    }

    internal sealed class ClassVisibilityPatcher
    {
        private readonly ModuleDefMD module;

        public ClassVisibilityPatcher(ModuleDefMD module)
        {
            this.module = module ?? throw new ArgumentNullException(nameof(module));
        }

        public int MakeAllClassesPublic()
        {
            int modifiedCount = 0;

            foreach (TypeDef type in module.GetTypes())
            {
                if (type.IsGlobalModuleType) continue;
                if (MakeTypePublic(type)) modifiedCount++;
                modifiedCount += MakeAllMembersPublic(type);
            }

            return modifiedCount;
        }

        private bool MakeTypePublic(TypeDef type)
        {
            bool modified = false;

            if (type.DeclaringType is null)
            {
                if ((type.Attributes & TypeAttributes.VisibilityMask) == TypeAttributes.NotPublic)
                {
                    type.Attributes &= ~TypeAttributes.VisibilityMask;
                    type.Attributes |= TypeAttributes.Public;
                    modified = true;
                }
            }
            else
            {
                TypeAttributes visibility = type.Attributes & TypeAttributes.VisibilityMask;
                if (visibility != TypeAttributes.NestedPublic)
                {
                    type.Attributes &= ~TypeAttributes.VisibilityMask;
                    type.Attributes |= TypeAttributes.NestedPublic;
                    modified = true;
                }
            }

            return modified;
        }

        private int MakeAllMembersPublic(TypeDef type)
        {
            int modifiedCount = 0;

            for (var i = 0; i < type.Fields.Count; i++)
            {
                FieldDef field = type.Fields[i];
                if (MakeFieldPublic(field)) modifiedCount++;
            }

            for (var i = 0; i < type.Methods.Count; i++)
            {
                MethodDef method = type.Methods[i];
                if (MakeMethodPublic(method)) modifiedCount++;
            }

            for (var i = 0; i < type.Properties.Count; i++)
            {
                PropertyDef property = type.Properties[i];
                if (MakePropertyPublic(property)) modifiedCount++;
            }

            for (var i = 0; i < type.Events.Count; i++)
            {
                EventDef eventDef = type.Events[i];
                if (MakeEventPublic(eventDef)) modifiedCount++;
            }

            return modifiedCount;
        }

        private bool MakeFieldPublic(FieldDef field)
        {
            if (field.IsCompilerControlled || field.Name.Contains("k__BackingField")) return false;

            FieldAttributes currentAccess = field.Attributes & FieldAttributes.FieldAccessMask;
            if (currentAccess != FieldAttributes.Public)
            {
                field.Attributes &= ~FieldAttributes.FieldAccessMask;
                field.Attributes |= FieldAttributes.Public;
                return true;
            }
            return false;
        }

        private bool MakeMethodPublic(MethodDef method)
        {
            if (method.IsRuntimeSpecialName && ! method.IsConstructor) return false;
            if (method.IsCompilerControlled && ! IsAccessorMethod(method)) return false;

            MethodAttributes currentAccess = method.Attributes & MethodAttributes.MemberAccessMask;
            if (currentAccess != MethodAttributes.Public)
            {
                method.Attributes &= ~MethodAttributes.MemberAccessMask;
                method.Attributes |= MethodAttributes.Public;
                return true;
            }
            return false;
        }

        private bool MakePropertyPublic(PropertyDef property)
        {
            bool modified = false;

            if (property.GetMethod != null && MakeMethodPublic(property.GetMethod)) modified = true;
            if (property.SetMethod != null && MakeMethodPublic(property.SetMethod)) modified = true;

            return modified;
        }

        private bool MakeEventPublic(EventDef eventDef)
        {
            bool modified = false;

            if (eventDef.AddMethod != null && MakeMethodPublic(eventDef.AddMethod)) modified = true;
            if (eventDef.RemoveMethod != null && MakeMethodPublic(eventDef.RemoveMethod)) modified = true;
            if (eventDef.InvokeMethod != null && MakeMethodPublic(eventDef.InvokeMethod)) modified = true;

            return modified;
        }

        private bool IsAccessorMethod(MethodDef method) => method.IsGetter || method.IsSetter || method.IsAddOn || method.IsRemoveOn || method.IsFire;
    }
}