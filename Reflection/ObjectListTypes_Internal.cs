using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using AssetReference = UnityEditorInternal.InternalEditorUtility.AssetReference;

namespace Emilia.Reflection.Editor
{
    public struct SearchSessionOptions_Internal
    {
        private SearchSessionOptions _options;

        internal SearchSessionOptions Target_Internal => _options;

        public static SearchSessionOptions_Internal Default_Internal => new SearchSessionOptions_Internal(SearchSessionOptions.Default);

        public bool legacyOnly_Internal
        {
            get => _options.legacyOnly;
            set => _options.legacyOnly = value;
        }

        public SearchSessionOptions_Internal(SearchSessionOptions options)
        {
            _options = options;
        }
    }

    public struct AssetReference_Internal : IEquatable<AssetReference_Internal>
    {
        private AssetReference _assetReference;

        internal AssetReference Target_Internal => _assetReference;

        public int instanceID_Internal
        {
            get => _assetReference.instanceID;
            set => _assetReference.instanceID = value;
        }

        public string guid_Internal
        {
            get => _assetReference.guid;
            set => _assetReference.guid = value;
        }

        public AssetReference_Internal(AssetReference assetReference)
        {
            _assetReference = assetReference;
        }

        public AssetReference_Internal(int instanceID, string guid = null)
        {
            _assetReference = new AssetReference
            {
                instanceID = instanceID,
                guid = guid
            };
        }

        public bool IsAssetImported_Internal() => AssetReference.IsAssetImported(_assetReference.instanceID);

        public bool Equals(AssetReference_Internal other)
        {
            return _assetReference.instanceID == other._assetReference.instanceID &&
                   string.Equals(_assetReference.guid, other._assetReference.guid, StringComparison.Ordinal);
        }

        public override bool Equals(object obj)
        {
            return obj is AssetReference_Internal other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_assetReference.instanceID * 397) ^ (_assetReference.guid?.GetHashCode() ?? 0);
            }
        }

        public static bool operator ==(AssetReference_Internal left, AssetReference_Internal right) => left.Equals(right);

        public static bool operator !=(AssetReference_Internal left, AssetReference_Internal right) => !left.Equals(right);
    }

    public struct AssetReferenceStringDictionary_Internal
    {
        private Dictionary<AssetReference, string> _dictionary;

        internal Dictionary<AssetReference, string> Target_Internal => _dictionary;

        public bool isValid_Internal => _dictionary != null;

        public int Count_Internal => _dictionary?.Count ?? 0;

        public AssetReferenceStringDictionary_Internal(Dictionary<AssetReference, string> dictionary)
        {
            _dictionary = dictionary;
        }

        public void Add_Internal(AssetReference_Internal key, string value)
        {
            _dictionary.Add(key.Target_Internal, value);
        }

        public bool ContainsKey_Internal(AssetReference_Internal key) => _dictionary.ContainsKey(key.Target_Internal);

        public bool Remove_Internal(AssetReference_Internal key) => _dictionary.Remove(key.Target_Internal);

        public bool TryGetValue_Internal(AssetReference_Internal key, out string value) => _dictionary.TryGetValue(key.Target_Internal, out value);

        public void Clear_Internal()
        {
            _dictionary.Clear();
        }

        public string GetValue_Internal(AssetReference_Internal key) => _dictionary[key.Target_Internal];

        public void SetValue_Internal(AssetReference_Internal key, string value)
        {
            _dictionary[key.Target_Internal] = value;
        }

        public List<AssetReference_Internal> GetKeys_Internal()
        {
            List<AssetReference_Internal> keys = new List<AssetReference_Internal>(_dictionary.Count);
            foreach (AssetReference key in _dictionary.Keys)
                keys.Add(new AssetReference_Internal(key));
            return keys;
        }

        public List<string> GetValues_Internal()
        {
            return new List<string>(_dictionary.Values);
        }

        public List<KeyValuePair<AssetReference_Internal, string>> ToList_Internal()
        {
            List<KeyValuePair<AssetReference_Internal, string>> list = new List<KeyValuePair<AssetReference_Internal, string>>(_dictionary.Count);
            foreach (KeyValuePair<AssetReference, string> pair in _dictionary)
                list.Add(new KeyValuePair<AssetReference_Internal, string>(new AssetReference_Internal(pair.Key), pair.Value));
            return list;
        }
    }

    public struct PingData_Internal
    {
        private PingData _pingData;

        internal PingData Target_Internal => _pingData;

        public bool isValid_Internal => _pingData != null;

        public float m_TimeStart_Internal
        {
            get => _pingData.m_TimeStart;
            set => _pingData.m_TimeStart = value;
        }

        public float m_PeakScale_Internal
        {
            get => _pingData.m_PeakScale;
            set => _pingData.m_PeakScale = value;
        }

        public float m_ZoomTime_Internal
        {
            get => _pingData.m_ZoomTime;
            set => _pingData.m_ZoomTime = value;
        }

        public float m_WaitTime_Internal
        {
            get => _pingData.m_WaitTime;
            set => _pingData.m_WaitTime = value;
        }

        public float m_FadeOutTime_Internal
        {
            get => _pingData.m_FadeOutTime;
            set => _pingData.m_FadeOutTime = value;
        }

        public float m_AvailableWidth_Internal
        {
            get => _pingData.m_AvailableWidth;
            set => _pingData.m_AvailableWidth = value;
        }

        public Rect m_ContentRect_Internal
        {
            get => _pingData.m_ContentRect;
            set => _pingData.m_ContentRect = value;
        }

        public Action<Rect> m_ContentDraw_Internal
        {
            get => _pingData.m_ContentDraw;
            set => _pingData.m_ContentDraw = value;
        }

        public GUIStyle m_PingStyle_Internal
        {
            get => _pingData.m_PingStyle;
            set => _pingData.m_PingStyle = value;
        }

        public bool isPinging_Internal => _pingData.isPinging;

        public PingData_Internal(PingData pingData)
        {
            _pingData = pingData;
        }

        public void HandlePing_Internal()
        {
            _pingData.HandlePing();
        }
    }

    public struct ProjectSearchSessionHandler_Internal
    {
        private ProjectSearchSessionHandler _handler;

        internal ProjectSearchSessionHandler Target_Internal => _handler;

        public bool isValid_Internal => _handler != null;

        public ProjectSearchSessionHandler_Internal(ProjectSearchSessionHandler handler)
        {
            _handler = handler;
        }

        public void Init_Internal(bool pullEngines)
        {
            _handler.Init(pullEngines);
        }

        public void PullEngines_Internal()
        {
            _handler.PullEngines();
        }

        public void BeginSession_Internal(Func<ProjectSearchContext> searchContextCreator)
        {
            _handler.BeginSession(searchContextCreator);
        }

        public void BeginSession_Internal(Func<ProjectSearchContext> searchContextCreator, SearchSessionOptions_Internal options)
        {
            _handler.BeginSession(searchContextCreator, options.Target_Internal);
        }

        public void EndSession_Internal()
        {
            _handler.EndSession();
        }

        public void BeginSearch_Internal(string query)
        {
            _handler.BeginSearch(query);
        }

        public IEnumerable<string> Search_Internal(string query, Action<IEnumerable<string>> asyncItemsReceived) =>
            _handler.Search(query, asyncItemsReceived);

        public void EndSearch_Internal()
        {
            _handler.EndSearch();
        }

        public void OnActiveEngineChanged_Internal(string newSearchEngineName)
        {
            _handler.OnActiveEngineChanged(newSearchEngineName);
        }
    }
}
