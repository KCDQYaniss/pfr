//Type is in global namespace

public class BossSectantPriest : BossWithStayFollowersPosition
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__45_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetSecondClose>b__45_0(IBotOwner x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public Player arg1Player; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal bool <HaveFollower>b__0(IBotOwner x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public Vector3 pos; //Field offset: 0x10

		public <>c__DisplayClass45_0() { }

		internal float <GetSecondClose>b__1(IBotOwner x) { }

	}

	private const float CENTER_OFFSET = 14; //Field offset: 0x0
	private const float DIST_TO_BOSS_PATROL = 33; //Field offset: 0x0
	private const float DIST_TO_TALK = 30; //Field offset: 0x0
	private const float GROUP_PERIOD_KNIFE = 8; //Field offset: 0x0
	private const float MAX_DELAY_TO_SUPPORT_SEC = 8; //Field offset: 0x0
	private const float MIN_DELAY_TO_SUPPORT_SEC = 1; //Field offset: 0x0
	private const float PERIOD_CAN_CHNAGE_TO_MELEE = 15; //Field offset: 0x0
	private float _nextTimeCheckWannaFight; //Field offset: 0x50
	private readonly Dictionary _startHitTarget; //Field offset: 0x58
	private readonly Vector3 _centerOffset; //Field offset: 0x60
	private bool _prevDistLess30; //Field offset: 0x6C
	private float _checkByDistPeriod; //Field offset: 0x70
	private float _changeToMeleeFromSupport; //Field offset: 0x74
	[CompilerGenerated]
	private Action OnPositionsRecalculated; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnRemoveFollower; //Field offset: 0x80

	public virtual event Action OnPositionsRecalculated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnRemoveFollower
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public BotOwner Owner
	{
		 get { } //Length: 5
	}

	public BossSectantPriest(BotOwner owner, BotBoss bossLogic) { }

	[CompilerGenerated]
	public virtual void add_OnPositionsRecalculated(Action value) { }

	[CompilerGenerated]
	public void add_OnRemoveFollower(Action value) { }

	public void AllFollowersDoAttack() { }

	public virtual void BossLogicUpdate() { }

	public bool CanChangeToMeleeFromSupport() { }

	public bool CanHit(Player trg) { }

	public void ChangeToMeleeFromSUpport() { }

	private void CheckEnemyDist() { }

	private void CheckFollowersCoversNearMe() { }

	protected virtual void FindPositionsForFollowers(bool anyway) { }

	private void FollowerDied(EDamageType damageType) { }

	public void FollowerTalkCheck() { }

	public void FollowerUnderAttack(BotOwner attackedWarriod) { }

	public BotOwner get_Owner() { }

	private IBotOwner GetSecondClose() { }

	public virtual Vector3 GetTargetToLook() { }

	public bool HaveFollower(Player arg1Player) { }

	private void OnFollowerGrenadeThrowComplete(ThrowWeap obj) { }

	private void Refresh() { }

	[CompilerGenerated]
	public virtual void remove_OnPositionsRecalculated(Action value) { }

	[CompilerGenerated]
	public void remove_OnRemoveFollower(Action value) { }

	protected virtual void SetLogicToFollower(SectantWarriorLayersStrategy followerLogic) { }

	public virtual void SetPatrolMode() { }

	public bool ShallAttack(Player arg1Player) { }

	public void StartAttackWithKnife(BotOwner hitter, Vector3 enemyPos) { }

	public void StartHitPLayer(Player trg) { }

	public void StartRunAway() { }

	protected virtual void SubAddFollower(IBotOwner botOwner) { }

	protected virtual void SubRemoveFollower(IBotOwner botOwner) { }

	public void TriggerPressedBy(BotOwner owner) { }

	private void UpdatePositions() { }

}

