using System;
using UnityEditor;

namespace Emilia.RemoteDebug.Editor
{
    [InitializeOnLoad]
    public static class RemoteDebugEditorHost
    {
        private static RemoteDebugClient _native, _local;
        private static IDisposable _localLease;
        public static Action<Exception> Log { get; set; }
        public static RemoteDebugClient ExistingClient => _native;

        public static RemoteDebugClient Client => _native ??= new RemoteDebugClient(EditorConnectionRemoteDebugTransport.Create(),
            () => EditorApplication.timeSinceStartup, log: error => Log?.Invoke(error));

        public static RemoteDebugClient LocalClient
        {
            get
            {
                if (! EditorApplication.isPlaying) throw new InvalidOperationException("Local RemoteDebug requires Play Mode.");
                if (_local == null)
                    _local = new RemoteDebugClient(RemoteDebugRuntimeHost.EnsureStarted().CreateLocalTransport(out _localLease),
                        () => EditorApplication.timeSinceStartup, log: error => Log?.Invoke(error));
                return _local;
            }
        }

        public static RemoteDebugTarget LocalTarget => new(1, "本机 Play Mode");

        static RemoteDebugEditorHost()
        {
            EditorApplication.update += Tick;
            AssemblyReloadEvents.beforeAssemblyReload += Dispose;
            EditorApplication.quitting += Dispose;
            EditorApplication.playModeStateChanged += PlayModeChanged;
        }

        private static void Tick()
        {
            _native?.Tick();
            _local?.Tick();
        }

        private static void PlayModeChanged(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.ExitingPlayMode || state == PlayModeStateChange.EnteredEditMode)
            {
                DisposeLocal();
                RemoteDebugRuntimeHost.Shutdown();
            }
        }

        private static void DisposeLocal()
        {
            _local?.Dispose();
            _local = null;
            _localLease?.Dispose();
            _localLease = null;
        }

        public static void Dispose()
        {
            DisposeLocal();
            _native?.Dispose();
            _native = null;
            RemoteDebugRuntimeHost.Shutdown();
        }
    }
}