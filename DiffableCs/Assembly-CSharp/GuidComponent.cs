//Type is in global namespace

[DisallowMultipleComponent]
[ExecuteInEditMode]
public class GuidComponent : MonoBehaviour, ISerializationCallbackReceiver
{
	private Guid guid; //Field offset: 0x20
	[SerializeField]
	private byte[] serializedGuid; //Field offset: 0x30

	public byte[] AsByteGuid
	{
		 get { } //Length: 76
	}

	public GuidComponent() { }

	private void Awake() { }

	private void CreateGuid() { }

	public byte[] get_AsByteGuid() { }

	public Guid GetGuid() { }

	public bool IsGuidAssigned() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public void OnDestroy() { }

	private void OnValidate() { }

}

