//Type is in global namespace

public abstract class ISyncAble : MonoBehaviour
{
	private static int _iterator; //Field offset: 0x0
	[SerializeField]
	protected uint _random; //Field offset: 0x20
	private uint _scenePathHash; //Field offset: 0x24

	protected ISyncAble() { }

	private void Awake() { }

	public abstract void Deserialize(IBitReaderStream readerStream) { }

	private uint GetRandomUInt() { }

	public ulong GetSceneId() { }

	protected uint GetScenePathHash() { }

	protected void OnValidate() { }

	public void RegenerateRandom() { }

	public abstract void Serialize(IBitWriterStream writerStream) { }

}

