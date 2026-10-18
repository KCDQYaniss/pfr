//Type is in global namespace

public class BotFollower : BotData
{
	private PatrolDataFollower _patrolDataFollower; //Field offset: 0x18
	private BotFollowerFight _botFollowerFight; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnBossFinded; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnBossDead; //Field offset: 0x30
	[CompilerGenerated]
	private IBossToFollow <BossToFollow>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <Index>k__BackingField; //Field offset: 0x40

	public event Action OnBossDead
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnBossFinded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public IBossToFollow BossToFollow
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private BotFollowerFight BotFollowerFight
	{
		 get { } //Length: 268
		private set { } //Length: 82
	}

	public int FollowersTargetCount
	{
		 get { } //Length: 78
	}

	public bool HaveBoss
	{
		 get { } //Length: 83
	}

	public int Index
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool NeedToProtectBoss
	{
		 get { } //Length: 148
	}

	public private PatrolDataFollower PatrolDataFollower
	{
		 get { } //Length: 269
		private set { } //Length: 82
	}

	public BotFollower(BotOwner owner) { }

	public override void Activate() { }

	[CompilerGenerated]
	public void add_OnBossDead(Action value) { }

	[CompilerGenerated]
	public void add_OnBossFinded(Action value) { }

	protected void BossFindAction() { }

	public static BotFollower Create(BotOwner bot) { }

	public override bool Dispose() { }

	public void DrawGizmos() { }

	public void DrawGizmosSelected() { }

	private void FindBossSecond() { }

	private void FindPlayerBoss(Nullable maxDist = null) { }

	[CompilerGenerated]
	public IBossToFollow get_BossToFollow() { }

	public BotFollowerFight get_BotFollowerFight() { }

	public int get_FollowersTargetCount() { }

	public bool get_HaveBoss() { }

	[CompilerGenerated]
	public int get_Index() { }

	public override bool get_NeedToProtectBoss() { }

	public PatrolDataFollower get_PatrolDataFollower() { }

	private void OnPlayerDead(Player player, IPlayer lastAggressor, DamageInfo damageInfo, EBodyPart part) { }

	private void OnStartLookToBody(float period) { }

	private void PeacefulActions(BotsPairData pairData) { }

	[CompilerGenerated]
	public void remove_OnBossDead(Action value) { }

	[CompilerGenerated]
	public void remove_OnBossFinded(Action value) { }

	[CompilerGenerated]
	protected void set_BossToFollow(IBossToFollow value) { }

	private void set_BotFollowerFight(BotFollowerFight value) { }

	[CompilerGenerated]
	protected void set_Index(int value) { }

	private void set_PatrolDataFollower(PatrolDataFollower value) { }

	public override void SetToFollow(IBossToFollow boss, int index, bool changeLogicMode = false) { }

	private bool TryFindAIBoss(Nullable maxDist = null) { }

	public void TryFindBoss() { }

	public override void Update(BotOwner bot) { }

}

