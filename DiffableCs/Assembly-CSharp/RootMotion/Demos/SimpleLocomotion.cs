namespace RootMotion.Demos;

[RequireComponent(typeof(Animator))]
public class SimpleLocomotion : MonoBehaviour
{
	internal enum RotationMode
	{
		Smooth = 0,
		Linear = 1,
	}

	[SerializeField]
	[Tooltip("The component that updates the camera.")]
	private CameraController cameraController; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Acceleration of movement.")]
	private float accelerationTime; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Turning speed.")]
	private float turnTime; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
	private bool walkByDefault; //Field offset: 0x30
	[SerializeField]
	[Tooltip("Smooth or linear rotation.")]
	private RotationMode rotationMode; //Field offset: 0x34
	[SerializeField]
	[Tooltip("Procedural motion speed (if not using root motion).")]
	private float moveSpeed; //Field offset: 0x38
	[CompilerGenerated]
	private bool <isGrounded>k__BackingField; //Field offset: 0x3C
	private Animator animator; //Field offset: 0x40
	private float speed; //Field offset: 0x48
	private float angleVel; //Field offset: 0x4C
	private float speedVel; //Field offset: 0x50
	private Vector3 linearTargetDirection; //Field offset: 0x54
	private CharacterController characterController; //Field offset: 0x60

	public private bool isGrounded
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public SimpleLocomotion() { }

	[CompilerGenerated]
	public bool get_isGrounded() { }

	private Vector3 GetInputVector() { }

	private Vector3 GetInputVectorRaw() { }

	private void LateUpdate() { }

	private void Move() { }

	private void Rotate() { }

	[CompilerGenerated]
	private void set_isGrounded(bool value) { }

	private void Start() { }

	private void Update() { }

}

