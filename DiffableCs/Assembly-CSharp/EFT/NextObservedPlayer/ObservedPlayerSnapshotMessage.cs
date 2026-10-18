namespace EFT.NextObservedPlayer;

public struct ObservedPlayerSnapshotMessage : Snapshot, ISerializableMessage
{
	private const float FALL_TIME_MAX = 5; //Field offset: 0x0
	private const float BODY_ROTATION_VERTICAL_MAX = 90; //Field offset: 0x0
	private const float HEAD_ROTATION_X_MIN = -50; //Field offset: 0x0
	private const float HEAD_ROTATION_X_MAX = 20; //Field offset: 0x0
	private const float HEAD_ROTATION_Y_MIN = -40; //Field offset: 0x0
	private const float HEAD_ROTATION_Y_MAX = 40; //Field offset: 0x0
	private const float MOVEMENT_DIRECTION_MIN = -1; //Field offset: 0x0
	private const float MOVEMENT_DIRECTION_MAX = 1; //Field offset: 0x0
	private const float VELOCITY_MIN = -25; //Field offset: 0x0
	private const float VELOCITY_MAX = 25; //Field offset: 0x0
	private const float TILT_MIN = -5; //Field offset: 0x0
	private const float TILT_MAX = 5; //Field offset: 0x0
	private const int STEP_MIN = -1; //Field offset: 0x0
	private const int STEP_MAX = 1; //Field offset: 0x0
	private const int BLIND_FIRE_MIN = -1; //Field offset: 0x0
	private const int BLIND_FIRE_MAX = 1; //Field offset: 0x0
	private const float SPEED_MIN = 0; //Field offset: 0x0
	private const float SPEED_MAX = 1; //Field offset: 0x0
	private const float POSE_LEVEL_MIN = 0; //Field offset: 0x0
	private const float POSE_LEVEL_MAX = 1; //Field offset: 0x0
	private const float IN_HANDS_OBJECT_OVERLAP_MIN = 0; //Field offset: 0x0
	private const float IN_HANDS_OBJECT_OVERLAP_MAX = 1; //Field offset: 0x0
	private const float JUMP_HEIGHT_MIN = -5; //Field offset: 0x0
	private const float JUMP_HEIGHT_MAX = 5; //Field offset: 0x0
	private const float FALL_HEIGHT_MIN = 0; //Field offset: 0x0
	private const float FALL_HEIGHT_MAX = 10; //Field offset: 0x0
	private const float BODY_ROTATION_VERTICAL_MIN = -90; //Field offset: 0x0
	private const float FALL_TIME_MIN = 0; //Field offset: 0x0
	[CompilerGenerated]
	private double <remoteTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private double <localTime>k__BackingField; //Field offset: 0x8
	public float ClientTime; //Field offset: 0x10
	public float WorldTime; //Field offset: 0x14
	public Vector3 BodyPosition; //Field offset: 0x18
	public Vector2 BodyRotation; //Field offset: 0x24
	public Vector3 WeaponLocalPosition; //Field offset: 0x2C
	public Vector3 WeaponLocalRotation; //Field offset: 0x38
	public Vector2 HeadRotation; //Field offset: 0x44
	public Vector2 MovementDirection; //Field offset: 0x4C
	public Vector3 Velocity; //Field offset: 0x54
	public float Tilt; //Field offset: 0x60
	public int Step; //Field offset: 0x64
	public int BlindFire; //Field offset: 0x68
	public int StateAnimatorIndex; //Field offset: 0x6C
	public EPlayerState State; //Field offset: 0x70
	public EPhysicalCondition PhysicalCondition; //Field offset: 0x74
	public float MovementSpeed; //Field offset: 0x78
	public float SprintSpeed; //Field offset: 0x7C
	public float MaxSpeed; //Field offset: 0x80
	public EPlayerPose Pose; //Field offset: 0x84
	public float PoseLevel; //Field offset: 0x88
	public float InHandsObjectOverlap; //Field offset: 0x8C
	public bool IsGrounded; //Field offset: 0x90
	public float JumpHeight; //Field offset: 0x94
	public float FallHeight; //Field offset: 0x98
	public float FallTime; //Field offset: 0x9C
	public bool LeftStance; //Field offset: 0xA0
	public float AimRotation; //Field offset: 0xA4
	public Quaternion FootRotation; //Field offset: 0xA8

	public override double localTime
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override double remoteTime
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	private void BlindFireDeserialize(NetworkReader reader) { }

	private void BlindFireSerialize(NetworkWriter writer) { }

	private void BodyRotationDeserialize(NetworkReader reader) { }

	private void BodyRotationSerialize(NetworkWriter writer) { }

	public static ObservedPlayerSnapshotMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	private void FallHeightDeserialize(NetworkReader reader) { }

	private void FallHeightSerialize(NetworkWriter writer) { }

	private void FallTimeDeserialize(NetworkReader reader) { }

	private void FallTimeSerialize(NetworkWriter writer) { }

	[CompilerGenerated]
	[IsReadOnly]
	public override double get_localTime() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override double get_remoteTime() { }

	private void HeadRotationDeserialize(NetworkReader reader) { }

	private void HeadRotationSerialize(NetworkWriter writer) { }

	private void InHandsObjectOverlapDeserialize(NetworkReader reader) { }

	private void InHandsObjectOverlapSerialize(NetworkWriter writer) { }

	public static ObservedPlayerSnapshotMessage Interpolate(ObservedPlayerSnapshotMessage fromSnapshot, ObservedPlayerSnapshotMessage toSnapshot, float t) { }

	private void JumpHeightDeserialize(NetworkReader reader) { }

	private void JumpHeightSerialize(NetworkWriter writer) { }

	private void MaxSpeedDeserialize(NetworkReader reader) { }

	private void MaxSpeedSerialize(NetworkWriter writer) { }

	private void MovementDirectionDeserialize(NetworkReader reader) { }

	private void MovementDirectionSerialize(NetworkWriter writer) { }

	private void MovementSpeedDeserialize(NetworkReader reader) { }

	private void MovementSpeedSerialize(NetworkWriter writer) { }

	private void PoseLevelDeserialize(NetworkReader reader) { }

	private void PoseLevelSerialize(NetworkWriter writer) { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public override void set_localTime(double value) { }

	[CompilerGenerated]
	public override void set_remoteTime(double value) { }

	private void SprintSpeedDeserialize(NetworkReader reader) { }

	private void SprintSpeedSerialize(NetworkWriter writer) { }

	private void StateAnimatorIndexDeserialize(NetworkReader reader) { }

	private void StateAnimatorIndexSerialize(NetworkWriter writer) { }

	private void StepDeserialize(NetworkReader reader) { }

	private void StepSerialize(NetworkWriter writer) { }

	private void TiltDeserialize(NetworkReader reader) { }

	private void TiltSerialize(NetworkWriter writer) { }

	private void VelocityDeserialize(NetworkReader reader) { }

	private void VelocitySerialize(NetworkWriter writer) { }

}

