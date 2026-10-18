//Type is in global namespace

public class FreeCamera : MonoBehaviour
{
	public bool enableInputCapture; //Field offset: 0x20
	public bool holdRightMouseCapture; //Field offset: 0x21
	public float lookSpeed; //Field offset: 0x24
	public float moveSpeed; //Field offset: 0x28
	public float sprintSpeed; //Field offset: 0x2C
	private bool m_inputCaptured; //Field offset: 0x30
	private float m_yaw; //Field offset: 0x34
	private float m_pitch; //Field offset: 0x38

	public FreeCamera() { }

	private void Awake() { }

	private void CaptureInput() { }

	private void OnApplicationFocus(bool focus) { }

	private void OnValidate() { }

	private void ReleaseInput() { }

	private void Update() { }

}

