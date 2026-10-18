namespace Sirenix.Serialization;

public struct SerializationData
{
	public const string PrefabModificationsReferencedUnityObjectsFieldName = "PrefabModificationsReferencedUnityObjects"; //Field offset: 0x0
	public const string PrefabModificationsFieldName = "PrefabModifications"; //Field offset: 0x0
	public const string PrefabFieldName = "Prefab"; //Field offset: 0x0
	[SerializeField]
	public DataFormat SerializedFormat; //Field offset: 0x0
	[SerializeField]
	public byte[] SerializedBytes; //Field offset: 0x8
	[SerializeField]
	public List ReferencedUnityObjects; //Field offset: 0x10
	[SerializeField]
	public string SerializedBytesString; //Field offset: 0x18
	[SerializeField]
	public Object Prefab; //Field offset: 0x20
	[SerializeField]
	public List PrefabModificationsReferencedUnityObjects; //Field offset: 0x28
	[SerializeField]
	public List PrefabModifications; //Field offset: 0x30
	[SerializeField]
	public List SerializationNodes; //Field offset: 0x38

	public bool ContainsData
	{
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use ContainsData instead")]
	public bool HasEditorData
	{
		 get { } //Length: 419
	}

	public bool get_ContainsData() { }

	public bool get_HasEditorData() { }

	public void Reset() { }

}

