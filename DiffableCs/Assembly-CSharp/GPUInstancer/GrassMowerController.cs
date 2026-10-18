namespace GPUInstancer;

public class GrassMowerController : MonoBehaviour
{
	public float engineTorque; //Field offset: 0x20
	public float enginePower; //Field offset: 0x24
	private Rigidbody grassMowerRigidbody; //Field offset: 0x28
	private float thrustInput; //Field offset: 0x30
	private float yawInput; //Field offset: 0x34

	public GrassMowerController() { }

	private void Awake() { }

	private void FixedUpdate() { }

	private void GetInputs() { }

	private void Move() { }

}

