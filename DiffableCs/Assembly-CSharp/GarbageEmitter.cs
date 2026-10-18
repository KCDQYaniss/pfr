//Type is in global namespace

public class GarbageEmitter : MonoBehaviour
{
	public GameObject[] Garbage; //Field offset: 0x20
	public float Speed; //Field offset: 0x28
	public float Delay; //Field offset: 0x2C
	public bool SaveCollider; //Field offset: 0x30
	public bool DontDesttroyComponents; //Field offset: 0x31
	private float _nextTime; //Field offset: 0x34

	public GarbageEmitter() { }

	private void ThrowObject(GameObject prefab, Vector3 position, Vector3 direction) { }

	private void Update() { }

}

