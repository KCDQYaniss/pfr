namespace JBooth.MicroSplat;

public class StreamEmitter : MonoBehaviour
{
	internal enum EmitterType
	{
		Water = 0,
		Lava = 1,
	}

	public EmitterType emitterType; //Field offset: 0x20
	[Range(0, 1)]
	public float strength; //Field offset: 0x24
	private StreamManager streamMgr; //Field offset: 0x28

	public StreamEmitter() { }

	private void OnDisable() { }

	private void OnDrawGizmos() { }

	private void OnEnable() { }

}

