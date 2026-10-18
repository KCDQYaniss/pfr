namespace EFT.WeaponMounting;

public class PlayerMountingPointData
{
	[CompilerGenerated]
	private MountPointData <MountPointData>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Vector3 <PlayerTargetPos>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <TargetHandsRotation>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private Quaternion <TargetBodyRotation>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Vector2 <PoseLimit>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Vector2 <PitchLimit>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Vector2 <YawLimit>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private float <TargetPoseLevel>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private float <CurrentApproachTime>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private float <CurrentMountingPointVerticalOffset>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <TransitionMounting>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private float <TransitionProgress>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Vector3 <WeaponMountingPos>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private Action OnMountedStateChanged; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnStartExitMountedState; //Field offset: 0x78
	public Action OnEnterMountedState; //Field offset: 0x80
	public Action OnExitMountedState; //Field offset: 0x88
	private WorldInteractiveObject _interactive; //Field offset: 0x90
	private MovingPlatform _movingPlatform; //Field offset: 0x98

	public event Action OnMountedStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnStartExitMountedState
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private float CurrentApproachTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public float CurrentMountingPointVerticalOffset
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public MountPointData MountPointData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private Vector2 PitchLimit
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private Vector3 PlayerTargetPos
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private Vector2 PoseLimit
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private Quaternion TargetBodyRotation
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private float TargetHandsRotation
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float TargetPoseLevel
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public bool TransitionMounting
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public float TransitionProgress
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public Vector3 WeaponMountingPos
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public private Vector2 YawLimit
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public PlayerMountingPointData() { }

	[CompilerGenerated]
	public void add_OnMountedStateChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnStartExitMountedState(Action value) { }

	private void CheckChanges(WorldInteractiveObject obj, EDoorState prevState, EDoorState nextState) { }

	public void ClearData() { }

	[CompilerGenerated]
	public float get_CurrentApproachTime() { }

	[CompilerGenerated]
	public float get_CurrentMountingPointVerticalOffset() { }

	[CompilerGenerated]
	public MountPointData get_MountPointData() { }

	[CompilerGenerated]
	public Vector2 get_PitchLimit() { }

	[CompilerGenerated]
	public Vector3 get_PlayerTargetPos() { }

	[CompilerGenerated]
	public Vector2 get_PoseLimit() { }

	[CompilerGenerated]
	public Quaternion get_TargetBodyRotation() { }

	[CompilerGenerated]
	public float get_TargetHandsRotation() { }

	[CompilerGenerated]
	public float get_TargetPoseLevel() { }

	[CompilerGenerated]
	public bool get_TransitionMounting() { }

	[CompilerGenerated]
	public float get_TransitionProgress() { }

	[CompilerGenerated]
	public Vector3 get_WeaponMountingPos() { }

	[CompilerGenerated]
	public Vector2 get_YawLimit() { }

	[CompilerGenerated]
	public void remove_OnMountedStateChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnStartExitMountedState(Action value) { }

	[CompilerGenerated]
	private void set_CurrentApproachTime(float value) { }

	[CompilerGenerated]
	public void set_CurrentMountingPointVerticalOffset(float value) { }

	[CompilerGenerated]
	public void set_MountPointData(MountPointData value) { }

	[CompilerGenerated]
	private void set_PitchLimit(Vector2 value) { }

	[CompilerGenerated]
	private void set_PlayerTargetPos(Vector3 value) { }

	[CompilerGenerated]
	private void set_PoseLimit(Vector2 value) { }

	[CompilerGenerated]
	private void set_TargetBodyRotation(Quaternion value) { }

	[CompilerGenerated]
	private void set_TargetHandsRotation(float value) { }

	[CompilerGenerated]
	private void set_TargetPoseLevel(float value) { }

	[CompilerGenerated]
	public void set_TransitionMounting(bool value) { }

	[CompilerGenerated]
	public void set_TransitionProgress(float value) { }

	[CompilerGenerated]
	public void set_WeaponMountingPos(Vector3 value) { }

	[CompilerGenerated]
	private void set_YawLimit(Vector2 value) { }

	public void SetCurrentInteractive(WorldInteractiveObject interactive) { }

	public void SetData(MountPointData mountPointData, Vector3 playerTargetPos, float targetPoseLevel, float targetHandsRotation, float currentApproachTime, Quaternion targetBodyRotation, Vector2 poseLimit, Vector2 pitchLimit, Vector2 yawLimit) { }

	public void SetMovingPlatform(MovingPlatform movingPlatform) { }

	private void Unsubscribe() { }

}

