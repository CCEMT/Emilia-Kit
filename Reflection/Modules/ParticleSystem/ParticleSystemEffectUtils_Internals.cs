using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class ParticleSystemEffectUtils_Internals
    {
        public static string CheckCircularReferences_Internals(ParticleSystem subEmitter) => ParticleSystemEffectUtils.CheckCircularReferences(subEmitter);

        public static void StopEffect_Internals()
        {
            ParticleSystemEffectUtils.StopEffect();
        }
    }
}