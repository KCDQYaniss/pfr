//Type is in global namespace

public class MouseLook : MonoBehaviour
{
	internal enum InputAxisEnum
	{
		X = 0,
		Y = 1,
	}

	public float MaximumY; //Field offset: 0x20
	public float MinimumY; //Field offset: 0x24
	public Vector3 Axis; //Field offset: 0x28
	public Transform Root; //Field offset: 0x38
	public float SensitivityY; //Field offset: 0x40
	public InputAxisEnum InputAxis; //Field offset: 0x44
	private Quaternion _originalRotation; //Field offset: 0x48
	public bool UseLocalUpdate; //Field offset: 0x58
	private float _rotationY; //Field offset: 0x5C

	public float RotationY
	{
		 get { } //Length: 6
	}

	public MouseLook() { }

	public static float ClampAngle(float angle, float min, float max) { }

	public float get_RotationY() { }

	public void OnUpdate() { }

	private void Start() { }

	private void Update() { }

}

