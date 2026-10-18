//Type is in global namespace

public class BotBoss : BotData, IBossToFollow
{
	protected BotBossFollowers _followers; //Field offset: 0x18
	private IPatrolMove _patrolMove; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnBossDead; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnBecomeBoss; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnFollowerStatusChange; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IamBoss>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private ABossLogic <BossLogic>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <NeedProtection>k__BackingField; //Field offset: 0x50

	public event Action OnBecomeBoss
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnBossDead
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnFollowerStatusChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool AllowRequestSelf
	{
		 get { } //Length: 57
	}

	public private ABossLogic BossLogic
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public List DebugInfoFollower
	{
		 get { } //Length: 42
	}

	public override List Followers
	{
		 get { } //Length: 42
	}

	public override int FollowersTargetCount
	{
		 get { } //Length: 42
	}

	public private bool IamBoss
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int Id
	{
		 get { } //Length: 29
	}

	public override bool IsAI
	{
		 get { } //Length: 3
	}

	public override bool IsAlive
	{
		 get { } //Length: 102
	}

	public override float MoveSpeed
	{
		 get { } //Length: 43
	}

	public private override bool NeedProtection
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotOwner Owner
	{
		 get { } //Length: 5
	}

	public override PatrollingData PatrollingData
	{
		 get { } //Length: 30
	}

	public override Vector3 Position
	{
		 get { } //Length: 95
	}

	public override Vector3 PositionIfInCover
	{
		 get { } //Length: 202
	}

	public override Vector3 PositionOrTargetCover
	{
		 get { } //Length: 196
	}

	public int TargetFollowersCount
	{
		 get { } //Length: 42
	}

	public BotBoss(BotOwner owner) { }

	private void Activate() { }

	[CompilerGenerated]
	public void add_OnBecomeBoss(Action value) { }

	[CompilerGenerated]
	public void add_OnBossDead(Action value) { }

	[CompilerGenerated]
	public void add_OnFollowerStatusChange(Action value) { }

	public override EnemyInfo CurEnemy() { }

	public void DeletePlayer(Player getPlayer) { }

	public void Dispose() { }

	public bool get_AllowRequestSelf() { }

	[CompilerGenerated]
	public ABossLogic get_BossLogic() { }

	public List get_DebugInfoFollower() { }

	public override List get_Followers() { }

	public override int get_FollowersTargetCount() { }

	[CompilerGenerated]
	public bool get_IamBoss() { }

	public int get_Id() { }

	public override bool get_IsAI() { }

	public override bool get_IsAlive() { }

	public override float get_MoveSpeed() { }

	[CompilerGenerated]
	public override bool get_NeedProtection() { }

	public BotOwner get_Owner() { }

	public override PatrollingData get_PatrollingData() { }

	public override Vector3 get_Position() { }

	public override Vector3 get_PositionIfInCover() { }

	public override Vector3 get_PositionOrTargetCover() { }

	public int get_TargetFollowersCount() { }

	public override ABossLogic GetBossLogic() { }

	public override IBotOwner GetFirstFollower(bool withGrenade) { }

	public override PatrolPoint GetPatrolPosByIndex(int botFollowerIndex) { }

	public bool HaveFollowers() { }

	public static bool IsFollowerSuitableForBoss(WildSpawnType follower, WildSpawnType boss) { }

	public override bool IsMe(IPlayer player) { }

	public void ManualUpdate() { }

	public bool OfferSelf(IBotOwner offer) { }

	public override IPlayer Player() { }

	[CompilerGenerated]
	public void remove_OnBecomeBoss(Action value) { }

	[CompilerGenerated]
	public void remove_OnBossDead(Action value) { }

	[CompilerGenerated]
	public void remove_OnFollowerStatusChange(Action value) { }

	public override void RemoveFollower(BotOwner botFollower) { }

	[CompilerGenerated]
	private void set_BossLogic(ABossLogic value) { }

	[CompilerGenerated]
	private void set_IamBoss(bool value) { }

	[CompilerGenerated]
	private void set_NeedProtection(bool value) { }

	public void SetBoss(int followersCount) { }

	private void SetPatrolMode() { }

}

