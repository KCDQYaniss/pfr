//Type is in global namespace

public class ExUsecFreeBossLogic : ABossLogic
{
	private const float MAX_CORE_POINT_DIST = 100; //Field offset: 0x0
	[CompilerGenerated]
	private bool <HaveCorePoint>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector3 <CorePoint>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <CorePointIsIndoor>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <CorePointPlaceId>k__BackingField; //Field offset: 0x34

	public private Vector3 CorePoint
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private bool CorePointIsIndoor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int CorePointPlaceId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool HaveCorePoint
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ExUsecFreeBossLogic(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	public virtual void BossLogicUpdate() { }

	public virtual void CopyData(ABossLogic bossBossLogic) { }

	public virtual void Dispose() { }

	public void EnsureCorePoint() { }

	[CompilerGenerated]
	public Vector3 get_CorePoint() { }

	[CompilerGenerated]
	public bool get_CorePointIsIndoor() { }

	[CompilerGenerated]
	public int get_CorePointPlaceId() { }

	[CompilerGenerated]
	public bool get_HaveCorePoint() { }

	[CompilerGenerated]
	private void set_CorePoint(Vector3 value) { }

	[CompilerGenerated]
	private void set_CorePointIsIndoor(bool value) { }

	[CompilerGenerated]
	private void set_CorePointPlaceId(int value) { }

	[CompilerGenerated]
	private void set_HaveCorePoint(bool value) { }

	public virtual void SetPatrolMode() { }

	public void Support(Vector3 pos, BotOwner caller, int envId) { }

	private void TryClaimCorePoint() { }

}

