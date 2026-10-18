namespace Diz.Skinning;

public class Skeleton : MonoBehaviour, ISerializationCallbackReceiver
{
	public Dictionary Bones; //Field offset: 0x20
	[SerializeField]
	private List _keys; //Field offset: 0x28
	[SerializeField]
	private List _values; //Field offset: 0x30

	public Skeleton() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}

