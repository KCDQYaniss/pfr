namespace EFT;

public abstract class UnitySerializedDictionary`2 : Dictionary, ISerializationCallbackReceiver
{
	[HideInInspector]
	[SerializeField]
	private List _keyData; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private List _valueData; //Field offset: 0x0

	protected UnitySerializedDictionary`2() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

