using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class ParticleSystemEditorUtils_Internals
    {
        public static float simulationSpeed_Internals
        {
            get => ParticleSystemEditorUtils.simulationSpeed;
            set => ParticleSystemEditorUtils.simulationSpeed = value;
        }

        public static float playbackTime_Internals
        {
            get => ParticleSystemEditorUtils.playbackTime;
            set => ParticleSystemEditorUtils.playbackTime = value;
        }

        public static bool playbackIsScrubbing_Internals
        {
            get => ParticleSystemEditorUtils.playbackIsScrubbing;
            set => ParticleSystemEditorUtils.playbackIsScrubbing = value;
        }

        public static bool playbackIsPlaying_Internals
        {
            get => ParticleSystemEditorUtils.playbackIsPlaying;
            set => ParticleSystemEditorUtils.playbackIsPlaying = value;
        }

        public static bool playbackIsPaused_Internals
        {
            get => ParticleSystemEditorUtils.playbackIsPaused;
            set => ParticleSystemEditorUtils.playbackIsPaused = value;
        }

        public static bool resimulation_Internals
        {
            get => ParticleSystemEditorUtils.resimulation;
            set => ParticleSystemEditorUtils.resimulation = value;
        }

        public static uint previewLayers_Internals
        {
            get => ParticleSystemEditorUtils.previewLayers;
            set => ParticleSystemEditorUtils.previewLayers = value;
        }

        public static bool renderInSceneView_Internals
        {
            get => ParticleSystemEditorUtils.renderInSceneView;
            set => ParticleSystemEditorUtils.renderInSceneView = value;
        }

        public static ParticleSystem lockedParticleSystem_Internals
        {
            get => ParticleSystemEditorUtils.lockedParticleSystem;
            set => ParticleSystemEditorUtils.lockedParticleSystem = value;
        }

        public static void PerformCompleteResimulation_Internals()
        {
            ParticleSystemEditorUtils.PerformCompleteResimulation();
        }

        public static ParticleSystem GetRoot_Internals(ParticleSystem ps) => ParticleSystemEditorUtils.GetRoot(ps);
    }
}