namespace RootMotion;

public class CameraControllerFPS : MonoBehaviour
{
	public float rotationSensitivity; //Field offset: 0x20
	public float yMinLimit; //Field offset: 0x24
	public float yMaxLimit; //Field offset: 0x28
	private float x; //Field offset: 0x2C
	private float y; //Field offset: 0x30

	public CameraControllerFPS() { }

	private void Awake() { }

	private float ClampAngle(float angle, float min, float max) { }

	public void LateUpdate() { }

}

