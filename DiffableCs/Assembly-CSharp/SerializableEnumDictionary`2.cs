//Type is in global namespace

public abstract class SerializableEnumDictionary`2 : Dictionary, ISerializationCallbackReceiver
{
	[HideInInspector]
	[SerializeField]
	private List _keys; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private List _values; //Field offset: 0x0

	protected SerializableEnumDictionary`2() { }

	[CanBeNull]
	public T GetValueOrDefault(TEnum key) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

