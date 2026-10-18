namespace JBooth.MicroSplat;

public class StreamCollider : MonoBehaviour
{
	internal enum ColliderType
	{
		Water = 0,
		Lava = 1,
		Both = 2,
	}

	private StreamManager streamMgr; //Field offset: 0x20
	public ColliderType colliderType; //Field offset: 0x28

	public StreamCollider() { }

	private void OnDisable() { }

	private void OnDrawGizmos() { }

	private void OnEnable() { }

}

