namespace EFT.Interactive;

public class Appliance : InteractableObject, ISerializationCallbackReceiver, ISupportsPrefabSerialization
{
	[SerializeField]
	private List _ambianceObjects; //Field offset: 0x48
	[SerializeField]
	private string _objectId; //Field offset: 0x50
	private bool _enabled; //Field offset: 0x58
	[HideInInspector]
	[SerializeField]
	private SerializationData _serializationData; //Field offset: 0x60

	public bool Enabled
	{
		 get { } //Length: 5
	}

	public string ObjectId
	{
		 get { } //Length: 5
	}

	private override SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.SerializationData
	{
		private get { } //Length: 41
		private set { } //Length: 114
	}

	public Appliance() { }

	private void Awake() { }

	public bool get_Enabled() { }

	public string get_ObjectId() { }

	private void SetActive(bool value) { }

	private override SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData() { }

	private override void Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(SerializationData value) { }

	public void TurnOff() { }

	public void TurnOn() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

