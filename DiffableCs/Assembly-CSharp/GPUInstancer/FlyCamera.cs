namespace GPUInstancer;

public class FlyCamera : MonoBehaviour
{
	public float mainSpeed; //Field offset: 0x20
	public float shiftSpeed; //Field offset: 0x24
	public float rotationSpeed; //Field offset: 0x28
	private Vector3 _inputVector; //Field offset: 0x2C
	private Vector3 _rotationEuler; //Field offset: 0x38

	public FlyCamera() { }

	private void CalculateInputVector() { }

	private void Start() { }

	private void Update() { }

}

