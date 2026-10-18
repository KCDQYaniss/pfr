namespace UnityEngine.Timeline;

[DefaultMember("Item")]
internal struct MarkerList : ISerializationCallbackReceiver
{
	[HideInInspector]
	[SerializeField]
	private List m_Objects; //Field offset: 0x0
	[HideInInspector]
	private List m_Cache; //Field offset: 0x8
	private bool m_CacheDirty; //Field offset: 0x10
	private bool m_HasNotifications; //Field offset: 0x11

	public int Count
	{
		 get { } //Length: 75
	}

	public IMarker Item
	{
		 get { } //Length: 122
	}

	public List markers
	{
		 get { } //Length: 26
	}

	public MarkerList(int capacity) { }

	public void Add(ScriptableObject item) { }

	private void BuildCache() { }

	public void Clear() { }

	public bool Contains(ScriptableObject item) { }

	public IMarker CreateMarker(Type type, double time, TrackAsset owner) { }

	public int get_Count() { }

	public IMarker get_Item(int idx) { }

	public List get_markers() { }

	public IEnumerable GetMarkers() { }

	public List GetRawMarkerList() { }

	public bool HasNotifications() { }

	public bool Remove(IMarker item) { }

	public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

