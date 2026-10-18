namespace EFT.MovingPlatforms;

public abstract class MovingPlatform : MonoBehaviour, IPhysicsTrigger
{
	internal interface IPlatformTransportee
	{

		public void Board(MovingPlatform platform) { }

		public void GetOff(MovingPlatform platform) { }

	}

	internal class NetworkAdapter
	{
		public const float SYNC_SMOOTHNESS = 1.5; //Field offset: 0x0
		public Locomotive Platform; //Field offset: 0x10
		public byte Id; //Field offset: 0x18
		private PlatformSyncPacket _incomingPacket; //Field offset: 0x1C
		private float _vel; //Field offset: 0x24
		private bool _hasIncomingPacket; //Field offset: 0x28

		public bool HasNetPacket
		{
			 get { } //Length: 162
		}

		public NetworkAdapter() { }

		public void ApplyStoredPackets() { }

		public bool get_HasNetPacket() { }

		public PlatformSyncPacket GetNetPacket() { }

		public void StoreNetPacket(PlatformSyncPacket packet) { }

	}

	internal class PreciseInterpolator
	{
		public float Distance1; //Field offset: 0x10
		public float Distance2; //Field offset: 0x14
		public Vector3 Point1; //Field offset: 0x18
		public Vector3 Point2; //Field offset: 0x24

		public PreciseInterpolator() { }

		public Vector3 GetPosition(Vector3 initial, float distance) { }

		public Vector3 GetPosition(Vector3 initial, float distance, out float blendFactor) { }

	}

	[FormerlySerializedAs("Spline")]
	[SerializeField]
	private BezierSpline _spline; //Field offset: 0x20
	[SerializeField]
	private float _approxLength; //Field offset: 0x28
	[SerializeField]
	protected float _routeDuration; //Field offset: 0x2C
	[SerializeField]
	private int DebugViewSteps; //Field offset: 0x30
	[SerializeField]
	protected Vector3 _forwardRotation; //Field offset: 0x34
	[SerializeField]
	protected float _currentDistance; //Field offset: 0x40
	[SerializeField]
	protected float _currentTime; //Field offset: 0x44
	[SerializeField]
	protected Vector3 _contactPoint; //Field offset: 0x48
	public AnimationCurve MovementCurve; //Field offset: 0x58
	public BindableList Passengers; //Field offset: 0x60
	public float Precision; //Field offset: 0x68
	[HideInInspector]
	protected Transform Transform; //Field offset: 0x70
	public PreciseInterpolator LinearInterpolator; //Field offset: 0x78
	public BoxCollider Area; //Field offset: 0x80
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Vector3[] <CachedDirections>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnPlatformMoving; //Field offset: 0x98
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0xA0
	public Vector3 JitterDirection; //Field offset: 0xA8
	public Vector3 JitterAngle; //Field offset: 0xB4
	public float JitterPeriod; //Field offset: 0xC0
	private Quaternion _oldRotation; //Field offset: 0xC4
	private readonly List _passengerPositions; //Field offset: 0xD8
	private DateTime _depart; //Field offset: 0xE0

	public event Action OnPlatformMoving
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override Vector3[] CachedDirections
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float CTime
	{
		 get { } //Length: 6
	}

	public float CurrentRouteTime
	{
		 get { } //Length: 215
	}

	public override float CurveApproxLength
	{
		 get { } //Length: 6
	}

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool Initialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public float NormalCurvePosition
	{
		 get { } //Length: 27
	}

	public float Position
	{
		 get { } //Length: 6
	}

	public Quaternion RotationAtCurrentDistance
	{
		 get { } //Length: 42
	}

	public override BezierSpline Spline
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	protected MovingPlatform() { }

	[CompilerGenerated]
	public void add_OnPlatformMoving(Action value) { }

	public override void CalculateLength() { }

	public override void FixedUpdate() { }

	[CompilerGenerated]
	public override Vector3[] get_CachedDirections() { }

	public float get_CTime() { }

	public float get_CurrentRouteTime() { }

	public override float get_CurveApproxLength() { }

	[CompilerGenerated]
	public override string get_Description() { }

	[CompilerGenerated]
	public bool get_Initialized() { }

	public float get_NormalCurvePosition() { }

	public float get_Position() { }

	public Quaternion get_RotationAtCurrentDistance() { }

	public override BezierSpline get_Spline() { }

	public override void Init(DateTime depart) { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public void Jitter(ref Vector3 position, ref Quaternion rotation) { }

	public override void Move(bool force = false) { }

	public override void OnDrawGizmosSelected() { }

	public override void OnRouteFinished() { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	public abstract void PlaceAtEndPosition() { }

	public abstract void PlaceAtStartPosition() { }

	[CompilerGenerated]
	public void remove_OnPlatformMoving(Action value) { }

	public Quaternion RotationAtDistance(float distance) { }

	[CompilerGenerated]
	public override void set_CachedDirections(Vector3[] value) { }

	[CompilerGenerated]
	public void set_Initialized(bool value) { }

	public override void set_Spline(BezierSpline value) { }

	public override void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	protected void StorePassengers() { }

	public override void Update() { }

	protected void UpdatePassengerPositions() { }

}

