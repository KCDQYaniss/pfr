namespace CW2;

public class AdditiveMeshBaker : MonoBehaviour
{
	public bool SaveCollider; //Field offset: 0x20
	public bool DontDesttroyComponents; //Field offset: 0x21
	[HideInInspector]
	public Rigidbody Rigidbody; //Field offset: 0x28

	public AdditiveMeshBaker() { }

	private void Awake() { }

	private void FixedUpdate() { }

}

