//Type is in global namespace

public class BotCurrentCoverInfo
{
	private const float SIT_CHANGE_SPEED = 2; //Field offset: 0x0
	private const float UPPER_SIT_POS = 1.2; //Field offset: 0x0
	public float nextToLookTime; //Field offset: 0x10
	public int ShootsFromCover; //Field offset: 0x14
	public CoverWithPath CoverWithPath; //Field offset: 0x18
	private ShootCoverStatus _shootCoverStatus; //Field offset: 0x20
	private float nextCheckTime; //Field offset: 0x24
	private AttackFromCoverType AttackFromCoverType; //Field offset: 0x28
	private readonly BotOwner _owner; //Field offset: 0x30
	private int _shootsNear; //Field offset: 0x38
	private int _shootsToMe; //Field offset: 0x3C
	private int _shootsUnkownToMe; //Field offset: 0x40
	private bool _useDogFightOut; //Field offset: 0x44
	private float _shootsNearPeriod; //Field offset: 0x48
	private float _hideInCoverComplete; //Field offset: 0x4C
	private float _outOfCoverComplete; //Field offset: 0x50
	private float _sitState; //Field offset: 0x54
	[CompilerGenerated]
	private float <ComeToCoverTime>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private CustomNavigationPoint <LastCover>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private float <LeaveCoverTime>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private float <LastChangeCoverStatusTime>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private CustomNavigationPoint <CovPoint>k__BackingField; //Field offset: 0x70

	public private float ComeToCoverTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public ShootCoverStatus CoverStatus
	{
		 get { } //Length: 4
		 set { } //Length: 508
	}

	public private CustomNavigationPoint CovPoint
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool HaveCover
	{
		 get { } //Length: 9
	}

	public bool IsCoveringComplete
	{
		 get { } //Length: 90
	}

	public bool IsOutOfCoverComplete
	{
		 get { } //Length: 90
	}

	public private float LastChangeCoverStatusTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private CustomNavigationPoint LastCover
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float LeaveCoverTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public BotCurrentCoverInfo(BotOwner player) { }

	public void AddShootDirection() { }

	public float CalcSit() { }

	public bool CanChangeWayByDist() { }

	private void CheckSafe() { }

	public void ComeToCover() { }

	[CompilerGenerated]
	public float get_ComeToCoverTime() { }

	public ShootCoverStatus get_CoverStatus() { }

	[CompilerGenerated]
	public CustomNavigationPoint get_CovPoint() { }

	public bool get_HaveCover() { }

	public bool get_IsCoveringComplete() { }

	public bool get_IsOutOfCoverComplete() { }

	[CompilerGenerated]
	public float get_LastChangeCoverStatusTime() { }

	[CompilerGenerated]
	public CustomNavigationPoint get_LastCover() { }

	[CompilerGenerated]
	public float get_LeaveCoverTime() { }

	public void HitInCoverByEnemy(Vector3 position) { }

	public void HitInCoverByUnknown(Vector3 position) { }

	public void Leaved() { }

	[CompilerGenerated]
	private void set_ComeToCoverTime(float value) { }

	public void set_CoverStatus(ShootCoverStatus value) { }

	[CompilerGenerated]
	private void set_CovPoint(CustomNavigationPoint value) { }

	[CompilerGenerated]
	private void set_LastChangeCoverStatusTime(float value) { }

	[CompilerGenerated]
	private void set_LastCover(CustomNavigationPoint value) { }

	[CompilerGenerated]
	private void set_LeaveCoverTime(float value) { }

	public void SetCover(CustomNavigationPoint value, bool withSetOwner = true) { }

	public void SetPathToCover(CustomNavigationPoint resultPoint) { }

	public bool ShouldGoToCover() { }

	public void Spotted() { }

	public void TryCheckSafe() { }

	internal void UseDogFight() { }

	public bool UseDogFight(float delta) { }

}

