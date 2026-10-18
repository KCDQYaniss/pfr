//Type is in global namespace

public class ExtendedFlycam : MonoBehaviour
{
	public float cameraSensitivity; //Field offset: 0x20
	public float climbSpeed; //Field offset: 0x24
	public float normalMoveSpeed; //Field offset: 0x28
	public float slowMoveFactor; //Field offset: 0x2C
	public float fastMoveFactor; //Field offset: 0x30
	private float rotationX; //Field offset: 0x34
	private float rotationY; //Field offset: 0x38

	public ExtendedFlycam() { }

	private void Start() { }

	private void Update() { }

}

