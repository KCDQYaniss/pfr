//Type is in global namespace

public class BossSanitar : ABossLogic, IBossSanitar
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public int shootPosKey; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal bool <ForceRecalcShootPos>b__0(FollowerSanitarLayersStrategy x) { }

	}

	private const float DIST_TO_C = 15; //Field offset: 0x0
	private const float MIN_DIST_TO_ENEMY_SQRT = 100; //Field offset: 0x0
	private const float TOTAL_PERIOD_USE_STIMULATORS = 10; //Field offset: 0x0
	public Dictionary FollowersPositions; //Field offset: 0x20
	public Action OnThrowRequest; //Field offset: 0x28
	private readonly List _botsFightLogics; //Field offset: 0x30
	private BossSanitarLayersStrategy _sanitarStrategy; //Field offset: 0x38
	private float _nextTimeCheckWannaFight; //Field offset: 0x40
	private Vector3 closestPosLeft; //Field offset: 0x44
	private Vector3 closestPosRight; //Field offset: 0x50
	private Vector3 posToTarget; //Field offset: 0x5C
	private float _nextPosibleSimulator; //Field offset: 0x68
	private readonly Dictionary _shooterPosGood; //Field offset: 0x70
	private float _nextPosibleForceRecalc; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnPositionsRecalculated; //Field offset: 0x80
	[CompilerGenerated]
	private bool <EnoughtHaveGoodCovers>k__BackingField; //Field offset: 0x88

	public event Action OnPositionsRecalculated
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public private override bool EnoughtHaveGoodCovers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override Nullable PointForBoss
	{
		 get { } //Length: 150
	}

	public BossSanitar(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	[CompilerGenerated]
	public void add_OnPositionsRecalculated(Action value) { }

	public virtual void BossLogicUpdate() { }

	[CanBeNull]
	private Dictionary CalcOptimalPositions(List positions, List bots) { }

	public override bool CanStartUseStimulator() { }

	private void CheckRecalcCore() { }

	private Dictionary Clone(Dictionary shooterPosGood) { }

	public virtual void Dispose() { }

	private void FindPositionsForFollowers(bool anyway) { }

	private void ForceRecalcShootPos(int shootPosKey) { }

	[CompilerGenerated]
	public override bool get_EnoughtHaveGoodCovers() { }

	public override Nullable get_PointForBoss() { }

	private bool IsEnoughtShootersPos() { }

	public virtual void OnDrawGizmosSelected() { }

	private void OnFollowerStatusChange(IBotOwner botFollower, FollowerStatusChange status) { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	private void OnSetStrategy(BaseBrain obj) { }

	private void RefreshStrategy() { }

	[CompilerGenerated]
	public void remove_OnPositionsRecalculated(Action value) { }

	[CompilerGenerated]
	private void set_EnoughtHaveGoodCovers(bool value) { }

	public override void SetFightPosition(bool isGood, BotOwner bot) { }

	public virtual void SetPatrolMode() { }

	public override void SomebodyUseStimulator() { }

	private void UpdatePositions(bool anyway) { }

	public override void WantAskHeal(BotOwner healTarget) { }

}

