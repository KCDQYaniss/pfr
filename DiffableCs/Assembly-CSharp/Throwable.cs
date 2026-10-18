//Type is in global namespace

public abstract class Throwable : MonoBehaviour
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__Interpolate; //Field offset: 0x0

	}

	private const float COLLISION_TRACK_TIMEOUT = 0.5; //Field offset: 0x0
	private const int SERVER_FRAMERATE = 30; //Field offset: 0x0
	private const float SMOOTH_DAMP_TIME = 0.07; //Field offset: 0x0
	private static readonly SnapshotInterpolatorOptions THROWABLE_OPTIONS; //Field offset: 0x0
	private const int _velocityBelowThresholdCountMax = 180; //Field offset: 0x0
	[CompilerGenerated]
	private Action DestroyEvent; //Field offset: 0x20
	[CompilerGenerated]
	private Action VelocityBelowThreshold; //Field offset: 0x28
	protected Rigidbody Rigidbody; //Field offset: 0x30
	protected Vector3 Velocity; //Field offset: 0x38
	protected float IgnoreCollisionTrackingTimer; //Field offset: 0x44
	private int _velocityBelowThresholdCount; //Field offset: 0x48
	private bool _live; //Field offset: 0x4C
	private bool _isDestroyed; //Field offset: 0x4D
	private ThrowableSettings _throwableSettings; //Field offset: 0x50
	private float _timePass; //Field offset: 0x58
	private byte _collisionNumber; //Field offset: 0x5C
	private SnapshotInterpolator _interpolator; //Field offset: 0x60
	private bool _interpolatorInitialized; //Field offset: 0x68
	private bool _networkDone; //Field offset: 0x69
	private byte _lastSyncedCollisionNumber; //Field offset: 0x6A
	private bool _forceAuthoritativeCorrection; //Field offset: 0x6B
	private bool _disableForwardOnlyCorrection; //Field offset: 0x6C
	private Vector3 _smoothDampVelocity; //Field offset: 0x70

	public event Action DestroyEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action VelocityBelowThreshold
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public byte CollisionNumber
	{
		 get { } //Length: 5
		 set { } //Length: 117
	}

	public abstract bool HasNetData
	{
		 get { } //Length: 0
	}

	public abstract int Id
	{
		 get { } //Length: 0
	}

	private static Throwable() { }

	protected Throwable() { }

	[CompilerGenerated]
	public void add_DestroyEvent(Action value) { }

	[CompilerGenerated]
	public void add_VelocityBelowThreshold(Action value) { }

	private void ApplyForwardOnlyCorrection(ref GrenadeSnapshotMessage state, Vector3 smoothedPos) { }

	private void ApplyInterpolatedState(ref GrenadeSnapshotMessage state) { }

	public override void ApplyNetPacket(GrenadeSyncPacket packet, float remoteTime) { }

	private void ApplyNetPacketSnapshot(ref GrenadeSyncPacket packet, float remoteTime) { }

	private void FixedUpdate() { }

	public byte get_CollisionNumber() { }

	public abstract bool get_HasNetData() { }

	public abstract int get_Id() { }

	public override GrenadeSyncPacket GetNetPacket() { }

	public override void Init(ThrowableSettings throwableSettings) { }

	private void InitializeInterpolator() { }

	private bool IsOwnedByLocalPlayer() { }

	public override void OnCollisionHandler() { }

	protected override void OnDestroy() { }

	protected override void OnDoneFromNet() { }

	[CompilerGenerated]
	public void remove_DestroyEvent(Action value) { }

	[CompilerGenerated]
	public void remove_VelocityBelowThreshold(Action value) { }

	public void set_CollisionNumber(byte value) { }

	public void SetKinematic(bool isKinematic) { }

	private bool ShouldSkipBackwardCorrection(ref GrenadeSnapshotMessage state) { }

	private Vector3 SmoothPosition(Vector3 fromPosition, Vector3 toPosition) { }

	protected override void Update() { }

	private void UpdateSnapshotInterpolation(float deltaTime) { }

}

