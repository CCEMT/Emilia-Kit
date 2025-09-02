using System;
using System.Collections.Generic;
using Sirenix.Serialization;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Emilia.Kit
{
    [Serializable]
    public class OdinSerializablePack<T> : ISerializationCallbackReceiver
    {
        [SerializeField]
        private byte[] objectInfoBytes;

        [SerializeField]
        private List<Object> unityObjects = new List<Object>();

        [NonSerialized]
        public T serializableObject;

        public void OnBeforeSerialize()
        {
            if (this.serializableObject == null) return;
            unityObjects.Clear();
            objectInfoBytes = TagSerializationUtility.IgnoreTagSerializeValue(serializableObject, DataFormat.Binary, out unityObjects, SerializeTagDefine.DefaultIgnoreTag);
        }

        public void OnAfterDeserialize()
        {
            serializableObject = SerializationUtility.DeserializeValue<T>(objectInfoBytes, DataFormat.Binary, unityObjects);
        }
    }
}