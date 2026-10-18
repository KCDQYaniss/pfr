//Type is in global namespace

public class MotionEffector : IEffector
{
	[CompilerGenerated]
	private Transform <Transform>k__BackingField; //Field offset: 0x10
	public Vector3 Motion; //Field offset: 0x18
	public Vector3 Velocity; //Field offset: 0x24
	public float RotationInputClamp; //Field offset: 0x30
	private Vector3 _lastPosition; //Field offset: 0x34
	private Vector3 _lastForward; //Field offset: 0x40
	public Vector3 PositionVelocity; //Field offset: 0x4C
	public Vector2 RotationVelocity; //Field offset: 0x58
	public Vector3 PositionAcceleration; //Field offset: 0x60
	public Vector2 RotationAcceleration; //Field offset: 0x6C
	public Vector3 SwayFactors; //Field offset: 0x74
	private Vector3 _lastPositionVelocity; //Field offset: 0x80
	private Vector2 _lastRotationVelocity; //Field offset: 0x8C
	private Vector2 _rotVelSum; //Field offset: 0x94
	private Vector2 _rotAccSum; //Field offset: 0x9C
	private Vector3 lastRotation; //Field offset: 0xA4
	public float Intensity; //Field offset: 0xB0
	public float BipodModifier; //Field offset: 0xB4
	private Vector3 _platformMovement; //Field offset: 0xB8
	private Vector2 v; //Field offset: 0xC4
	private Vector2 v4; //Field offset: 0xCC
	private BetterValProcessor[] _mouseProcessors; //Field offset: 0xD8
	private ValProcessor[] _movementProcessors; //Field offset: 0xE0
	public MotionEffectorParameters MouseParameters; //Field offset: 0xE8
	public MotionEffectorParameters MovementParameters; //Field offset: 0xF0
	private bool _isMounted; //Field offset: 0xF8
	private bool _isBipodUsed; //Field offset: 0xF9
	private bool _initialized; //Field offset: 0xFA
	private Vector3 v2; //Field offset: 0xFC
	private Vector3 v3; //Field offset: 0x108
	private bool _needReset; //Field offset: 0x114

	public Transform Transform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MotionEffector() { }

	public void AddPlatformMovement(Vector3 movement) { }

	public override string DebugOutput() { }

	public void FixedTracking(float deltaTime) { }

	[CompilerGenerated]
	public Transform get_Transform() { }

	private Vector2 GetGyro() { }

	public override void Initialize(PlayerSpring playerSpring) { }

	public override void Process(float deltaTime) { }

	public void Reset() { }

	private void ResetNow() { }

	[CompilerGenerated]
	public void set_Transform(Transform value) { }

	public void SetBipod(bool isBipodUsed) { }

	public void SetMounting(bool isMounted) { }

}

