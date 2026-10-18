//Type is in global namespace

public abstract class BossWithStayFollowersPosition`2 : ABossLogic, IPatrolMoveBossStayAtPlace
{
	protected Dictionary _followersPositions; //Field offset: 0x0
	protected readonly List _botsFightLogics; //Field offset: 0x0
	private readonly Dictionary HaveGoodCovers; //Field offset: 0x0
	[CompilerGenerated]
	private bool <EnoughtHaveGoodCovers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Nullable <PointForBoss>k__BackingField; //Field offset: 0x0

	public abstract event Action OnPositionsRecalculated
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public private override bool EnoughtHaveGoodCovers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override Nullable PointForBoss
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected BossWithStayFollowersPosition`2(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	[CompilerGenerated]
	public abstract void add_OnPositionsRecalculated(Action value) { }

	public virtual void Dispose() { }

	protected abstract void FindPositionsForFollowers(bool b) { }

	public override Dictionary FollowersPositions() { }

	[CompilerGenerated]
	public override bool get_EnoughtHaveGoodCovers() { }

	[CompilerGenerated]
	public override Nullable get_PointForBoss() { }

	public abstract Vector3 GetTargetToLook() { }

	private void OnFollowerStatusChange(IBotOwner botFollower, FollowerStatusChange arg2) { }

	[CompilerGenerated]
	public abstract void remove_OnPositionsRecalculated(Action value) { }

	[CompilerGenerated]
	private void set_EnoughtHaveGoodCovers(bool value) { }

	[CompilerGenerated]
	protected void set_PointForBoss(Nullable value) { }

	private void SetALlLogicToFollowers() { }

	public override void SetFollowersPositions() { }

	public override void SetHaveGoodCover(BotOwner id, bool noGoodCover) { }

	protected abstract void SetLogicToFollower(T followerLogic) { }

	protected override void SubAddFollower(IBotOwner botOwner) { }

	protected override void SubRemoveFollower(IBotOwner botOwner) { }

}

