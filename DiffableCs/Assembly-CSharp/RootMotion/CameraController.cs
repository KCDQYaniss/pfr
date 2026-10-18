namespace RootMotion;

public class CameraController : MonoBehaviour
{
	internal enum UpdateMode
	{
		Update = 0,
		FixedUpdate = 1,
		LateUpdate = 2,
	}

	public Transform target; //Field offset: 0x20
	public UpdateMode updateMode; //Field offset: 0x28
	public bool lockCursor; //Field offset: 0x2C
	public bool smoothFollow; //Field offset: 0x2D
	public float followSpeed; //Field offset: 0x30
	public float distance; //Field offset: 0x34
	public float minDistance; //Field offset: 0x38
	public float maxDistance; //Field offset: 0x3C
	public float zoomSpeed; //Field offset: 0x40
	public float zoomSensitivity; //Field offset: 0x44
	public float rotationSensitivity; //Field offset: 0x48
	public float yMinLimit; //Field offset: 0x4C
	public float yMaxLimit; //Field offset: 0x50
	public Vector3 offset; //Field offset: 0x54
	public bool rotateAlways; //Field offset: 0x60
	public bool rotateOnLeftButton; //Field offset: 0x61
	public bool rotateOnRightButton; //Field offset: 0x62
	public bool rotateOnMiddleButton; //Field offset: 0x63
	[CompilerGenerated]
	private float <x>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private float <y>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private float <distanceTarget>k__BackingField; //Field offset: 0x6C
	private Vector3 targetDistance; //Field offset: 0x70
	private Vector3 position; //Field offset: 0x7C
	private Quaternion rotation; //Field offset: 0x88
	private Vector3 smoothPosition; //Field offset: 0x98
	private Camera cam; //Field offset: 0xA8

	public private float distanceTarget
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float x
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float y
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	private float zoomAdd
	{
		private get { } //Length: 171
	}

	public CameraController() { }

	protected override void Awake() { }

	private float ClampAngle(float angle, float min, float max) { }

	protected override void FixedUpdate() { }

	[CompilerGenerated]
	public float get_distanceTarget() { }

	[CompilerGenerated]
	public float get_x() { }

	[CompilerGenerated]
	public float get_y() { }

	private float get_zoomAdd() { }

	protected override void LateUpdate() { }

	[CompilerGenerated]
	private void set_distanceTarget(float value) { }

	[CompilerGenerated]
	private void set_x(float value) { }

	[CompilerGenerated]
	private void set_y(float value) { }

	protected override void Update() { }

	public void UpdateInput() { }

	public void UpdateTransform() { }

	public void UpdateTransform(float deltaTime) { }

}

