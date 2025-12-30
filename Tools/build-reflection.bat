rd /s /q UnityReflection

dotnet build ../Reflection/UnityReflection.csproj -c Debug -o UnityReflection

copy UnityReflection\Emilia.UnityReflection.Editor.dll ..\Assets\Emilia\Kit\Core\Reflection\Emilia.UnityReflection.Editor.dll