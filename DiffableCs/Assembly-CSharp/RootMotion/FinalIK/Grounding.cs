namespace RootMotion.FinalIK;

public class Grounding
{
	internal class Leg
	{
		[CompilerGenerated]
		private bool <isGrounded>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Vector3 <IKPosition>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private Quaternion <rotationOffset>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private bool <initiated>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private float <heightFromGround>k__BackingField; //Field offset: 0x34
		[CompilerGenerated]
		private Vector3 <velocity>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private Transform <transform>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		private float <IKOffset>k__BackingField; //Field offset: 0x50
		private Grounding grounding; //Field offset: 0x58
		private float lastTime; //Field offset: 0x60
		private float deltaTime; //Field offset: 0x64
		private Vector3 lastPosition; //Field offset: 0x68
		private Quaternion toHitNormal; //Field offset: 0x74
		private Quaternion r; //Field offset: 0x84
		private RaycastHit heelHit; //Field offset: 0x94
		private Vector3 up; //Field offset: 0xC0

		public private float heightFromGround
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private float IKOffset
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private Vector3 IKPosition
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public private bool initiated
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private bool isGrounded
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		private float rootYOffset
		{
			private get { } //Length: 402
		}

		public private Quaternion rotationOffset
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public float stepHeightFromGround
		{
			 get { } //Length: 58
		}

		public private Transform transform
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private Vector3 velocity
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public Leg() { }

		[CompilerGenerated]
		public float get_heightFromGround() { }

		[CompilerGenerated]
		public float get_IKOffset() { }

		[CompilerGenerated]
		public Vector3 get_IKPosition() { }

		[CompilerGenerated]
		public bool get_initiated() { }

		[CompilerGenerated]
		public bool get_isGrounded() { }

		private float get_rootYOffset() { }

		[CompilerGenerated]
		public Quaternion get_rotationOffset() { }

		public float get_stepHeightFromGround() { }

		[CompilerGenerated]
		public Transform get_transform() { }

		[CompilerGenerated]
		public Vector3 get_velocity() { }

		private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel) { }

		private float GetHeightFromGround(Vector3 hitPoint) { }

		private RaycastHit GetRaycastHit(Vector3 offsetFromHeel) { }

		private Quaternion GetRotationOffsetTarget() { }

		public void Initiate(Grounding grounding, Transform transform) { }

		public void OnEnable() { }

		public void Process() { }

		public void Reset() { }

		private void RotateFoot() { }

		private Vector3 RotateNormal(Vector3 normal) { }

		[CompilerGenerated]
		private void set_heightFromGround(float value) { }

		[CompilerGenerated]
		private void set_IKOffset(float value) { }

		[CompilerGenerated]
		private void set_IKPosition(Vector3 value) { }

		[CompilerGenerated]
		private void set_initiated(bool value) { }

		[CompilerGenerated]
		private void set_isGrounded(bool value) { }

		[CompilerGenerated]
		private void set_rotationOffset(Quaternion value) { }

		[CompilerGenerated]
		private void set_transform(Transform value) { }

		[CompilerGenerated]
		private void set_velocity(Vector3 value) { }

		private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint) { }

		private void SetFootToPoint(Vector3 normal, Vector3 point) { }

	}

	internal class Pelvis
	{
		[CompilerGenerated]
		private Vector3 <IKOffset>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private float <heightOffset>k__BackingField; //Field offset: 0x1C
		private Grounding grounding; //Field offset: 0x20
		private Vector3 lastRootPosition; //Field offset: 0x28
		private float damperF; //Field offset: 0x34
		private bool initiated; //Field offset: 0x38
		private float lastTime; //Field offset: 0x3C

		public private float heightOffset
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private Vector3 IKOffset
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public Pelvis() { }

		[CompilerGenerated]
		public float get_heightOffset() { }

		[CompilerGenerated]
		public Vector3 get_IKOffset() { }

		public void Initiate(Grounding grounding) { }

		public void OnEnable() { }

		public void Process(float lowestOffset, float highestOffset, bool isGrounded) { }

		public void Reset() { }

		[CompilerGenerated]
		private void set_heightOffset(float value) { }

		[CompilerGenerated]
		private void set_IKOffset(Vector3 value) { }

	}

	internal enum Quality
	{
		Fastest = 0,
		Simple = 1,
		Best = 2,
	}

	[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
	public LayerMask layers; //Field offset: 0x10
	[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
	public float maxStep; //Field offset: 0x14
	[Tooltip("The height offset of the root.")]
	public float heightOffset; //Field offset: 0x18
	[Tooltip("The speed of moving the feet up/down.")]
	public float footSpeed; //Field offset: 0x1C
	[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
	public float footRadius; //Field offset: 0x20
	[Tooltip("Amount of velocity based prediction of the foot positions.")]
	public float prediction; //Field offset: 0x24
	[Range(0, 1)]
	[Tooltip("Weight of rotating the feet to the ground normal offset.")]
	public float footRotationWeight; //Field offset: 0x28
	[Tooltip("Speed of slerping the feet to their grounded rotations.")]
	public float footRotationSpeed; //Field offset: 0x2C
	[Range(0, 90)]
	[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
	public float maxFootRotationAngle; //Field offset: 0x30
	[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
	public bool rotateSolver; //Field offset: 0x34
	[Tooltip("The speed of moving the character up/down.")]
	public float pelvisSpeed; //Field offset: 0x38
	[Range(0, 1)]
	[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
	public float pelvisDamper; //Field offset: 0x3C
	[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
	public float lowerPelvisWeight; //Field offset: 0x40
	[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
	public float liftPelvisWeight; //Field offset: 0x44
	[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
	public float rootSphereCastRadius; //Field offset: 0x48
	[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
	public Quality quality; //Field offset: 0x4C
	[CompilerGenerated]
	private Leg[] <legs>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Pelvis <pelvis>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <isGrounded>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Transform <root>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private RaycastHit <rootHit>k__BackingField; //Field offset: 0x70
	private bool initiated; //Field offset: 0x9C

	public private bool isGrounded
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Leg[] legs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Pelvis pelvis
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Transform root
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool rootGrounded
	{
		 get { } //Length: 28
	}

	public private RaycastHit rootHit
	{
		[CompilerGenerated]
		 get { } //Length: 44
		[CompilerGenerated]
		private set { } //Length: 41
	}

	public Vector3 up
	{
		 get { } //Length: 142
	}

	private bool useRootRotation
	{
		private get { } //Length: 203
	}

	public Grounding() { }

	public Vector3 Flatten(Vector3 v) { }

	[CompilerGenerated]
	public bool get_isGrounded() { }

	[CompilerGenerated]
	public Leg[] get_legs() { }

	[CompilerGenerated]
	public Pelvis get_pelvis() { }

	[CompilerGenerated]
	public Transform get_root() { }

	public bool get_rootGrounded() { }

	[CompilerGenerated]
	public RaycastHit get_rootHit() { }

	public Vector3 get_up() { }

	private bool get_useRootRotation() { }

	public Vector3 GetLegsPlaneNormal() { }

	public RaycastHit GetRootHit(float maxDistanceMlp = 10) { }

	public float GetVerticalOffset(Vector3 p1, Vector3 p2) { }

	public void Initiate(Transform root, Transform[] feet) { }

	public bool IsValid(ref string errorMessage) { }

	public void LogWarning(string message) { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_isGrounded(bool value) { }

	[CompilerGenerated]
	private void set_legs(Leg[] value) { }

	[CompilerGenerated]
	private void set_pelvis(Pelvis value) { }

	[CompilerGenerated]
	private void set_root(Transform value) { }

	[CompilerGenerated]
	private void set_rootHit(RaycastHit value) { }

	public void Update() { }

}

