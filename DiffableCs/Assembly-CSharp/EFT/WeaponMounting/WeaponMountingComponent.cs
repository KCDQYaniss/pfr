namespace EFT.WeaponMounting;

public sealed class WeaponMountingComponent : IWeaponMountingComponent, IDisposable
{
	private const float PITCH_DEGREE_TO_POSE_LEVEL = 50; //Field offset: 0x0
	private readonly Vector3 _localRsOffset; //Field offset: 0x10
	private readonly Vector3 _localSitRsOffset; //Field offset: 0x1C
	private readonly Vector3 _localLsOffset; //Field offset: 0x28
	private readonly Vector3 _localSitLsOffset; //Field offset: 0x34
	private readonly WeaponMountingView _view; //Field offset: 0x40
	private readonly MovementContext _movementContext; //Field offset: 0x48
	private readonly ProceduralWeaponAnimation _proceduralWeaponAnimation; //Field offset: 0x50
	private readonly PlayerSpring _playerSpring; //Field offset: 0x58
	private MountingPointDetectionSystem _detectionSystem; //Field offset: 0x60
	private readonly Collider[] _secondaryCheckColliders; //Field offset: 0x68
	private readonly RaycastHit[] _boxCastHits; //Field offset: 0x70
	private FirearmController _currentController; //Field offset: 0x78
	[CompilerGenerated]
	private readonly IMountingPointDetectionSettings <MountingPointDetectionSettings>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private readonly IMountingMovementSettings <MountingMovementSettings>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Action <OnNothingFound>k__BackingField; //Field offset: 0x90

	public IMountingMovementSettings MountingMovementSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override IMountingPointDetectionSettings MountingPointDetectionSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override Action OnNothingFound
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public WeaponMountingComponent(WeaponMountingView view, MovementContext movementContext, ProceduralWeaponAnimation proceduralWeaponAnimation, IMountingPointDetectionSettings mountingPointDetectionSettings, IMountingMovementSettings mountingMovementSettings, PlayerSpring playerSpring) { }

	public override void CancelFindingPoint() { }

	private bool CheckIfTargetPosReachable(Vector3 targetPos, Quaternion targetBodyRotation) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public IMountingMovementSettings get_MountingMovementSettings() { }

	[CompilerGenerated]
	public override IMountingPointDetectionSettings get_MountingPointDetectionSettings() { }

	[CompilerGenerated]
	public override Action get_OnNothingFound() { }

	private void NoPointFound() { }

	private void OnFoundPoint(MountPointData mountPointData) { }

	[CompilerGenerated]
	public override void set_OnNothingFound(Action value) { }

	private bool TryFoundInteractiveObject(Vector3 mountPoint, out WorldInteractiveObject interactive) { }

	private bool TryFoundMovingPlatformObject(Vector3 mountPoint, out MovingPlatform movingPlatform) { }

	public override void TryMountWeapon(FirearmController controller) { }

	private bool TrySetPlayerMountingPointData(MountPointData mountPointData) { }

}

