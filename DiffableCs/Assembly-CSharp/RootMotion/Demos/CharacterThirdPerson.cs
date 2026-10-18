namespace RootMotion.Demos;

public class CharacterThirdPerson : CharacterBase
{
	internal struct AnimState
	{
		public Vector3 moveDirection; //Field offset: 0x0
		public bool jump; //Field offset: 0xC
		public bool crouch; //Field offset: 0xD
		public bool onGround; //Field offset: 0xE
		public bool isStrafing; //Field offset: 0xF
		public float yVelocity; //Field offset: 0x10

	}

	internal enum MoveMode
	{
		Directional = 0,
		Strafe = 1,
	}

	[Header("References")]
	[SerializeField]
	private CharacterAnimationBase characterAnimation; //Field offset: 0x68
	[SerializeField]
	private UserControlThirdPerson userControl; //Field offset: 0x70
	[SerializeField]
	private CameraController cam; //Field offset: 0x78
	[Header("Movement")]
	public MoveMode moveMode; //Field offset: 0x80
	public bool smoothPhysics; //Field offset: 0x84
	public float smoothAccelerationTime; //Field offset: 0x88
	public float linearAccelerationSpeed; //Field offset: 0x8C
	public float platformFriction; //Field offset: 0x90
	public float groundStickyEffect; //Field offset: 0x94
	public float maxVerticalVelocityOnGround; //Field offset: 0x98
	public float velocityToGroundTangentWeight; //Field offset: 0x9C
	[Header("Rotation")]
	public bool lookInCameraDirection; //Field offset: 0xA0
	public float turnSpeed; //Field offset: 0xA4
	public float stationaryTurnSpeedMlp; //Field offset: 0xA8
	[Header("Jumping and Falling")]
	public float airSpeed; //Field offset: 0xAC
	public float airControl; //Field offset: 0xB0
	public float jumpPower; //Field offset: 0xB4
	public float jumpRepeatDelayTime; //Field offset: 0xB8
	[Header("Wall Running")]
	[SerializeField]
	private LayerMask wallRunLayers; //Field offset: 0xBC
	public float wallRunMaxLength; //Field offset: 0xC0
	public float wallRunMinMoveMag; //Field offset: 0xC4
	public float wallRunMinVelocityY; //Field offset: 0xC8
	public float wallRunRotationSpeed; //Field offset: 0xCC
	public float wallRunMaxRotationAngle; //Field offset: 0xD0
	public float wallRunWeightSpeed; //Field offset: 0xD4
	[Header("Crouching")]
	public float crouchCapsuleScaleMlp; //Field offset: 0xD8
	[CompilerGenerated]
	private bool <onGround>k__BackingField; //Field offset: 0xDC
	public AnimState animState; //Field offset: 0xE0
	private Vector3 moveDirection; //Field offset: 0xF4
	private Animator animator; //Field offset: 0x100
	private Vector3 normal; //Field offset: 0x108
	private Vector3 platformVelocity; //Field offset: 0x114
	private RaycastHit hit; //Field offset: 0x120
	private float jumpLeg; //Field offset: 0x14C
	private float jumpEndTime; //Field offset: 0x150
	private float forwardMlp; //Field offset: 0x154
	private float groundDistance; //Field offset: 0x158
	private float lastAirTime; //Field offset: 0x15C
	private float stickyForce; //Field offset: 0x160
	private Vector3 wallNormal; //Field offset: 0x164
	private Vector3 moveDirectionVelocity; //Field offset: 0x170
	private float wallRunWeight; //Field offset: 0x17C
	private float lastWallRunWeight; //Field offset: 0x180
	private Vector3 fixedDeltaPosition; //Field offset: 0x184
	private bool fixedFrame; //Field offset: 0x190
	private float wallRunEndTime; //Field offset: 0x194

	public private bool onGround
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public CharacterThirdPerson() { }

	private bool CanWallRun() { }

	private void FixedUpdate() { }

	[CompilerGenerated]
	public bool get_onGround() { }

	private Vector3 GetForwardDirection() { }

	private Vector3 GetMoveDirection() { }

	private void GroundCheck() { }

	protected override bool Jump() { }

	protected override void LateUpdate() { }

	public virtual void Move(Vector3 deltaPosition) { }

	private void MoveFixed(Vector3 deltaPosition) { }

	private void OnAnimatorMove() { }

	protected override void Rotate() { }

	[CompilerGenerated]
	private void set_onGround(bool value) { }

	protected virtual void Start() { }

	protected override void Update() { }

	private void WallRun() { }

}

