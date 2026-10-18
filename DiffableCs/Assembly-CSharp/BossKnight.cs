//Type is in global namespace

public class BossKnight : ABossLogic
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public int shootPosKey; //Field offset: 0x10

		public <>c__DisplayClass42_0() { }

		internal bool <ForceRecalcShootPos>b__0(FollowerSanitarLayersStrategy x) { }

	}

	private const float CHANCE_TO_DROP_MEDS = 160; //Field offset: 0x0
	private const float DIST_TO_C = 15; //Field offset: 0x0
	private const string IFAK_ID_TO_DROP = "590c678286f77426c9660122"; //Field offset: 0x0
	private const float MIN_DIST_TO_ENEMY_SQRT = 100; //Field offset: 0x0
	private const float NO_DROP_MEDS_SEC_FROM_START = 60; //Field offset: 0x0
	private const float TOTAL_PERIOD_USE_STIMULATORS = 10; //Field offset: 0x0
	public Dictionary FollowersPositions; //Field offset: 0x20
	public Action OnThrowRequest; //Field offset: 0x28
	private readonly List medsList; //Field offset: 0x30
	private readonly List _botsFightLogics; //Field offset: 0x38
	private BossKnightLayersStrategy _knightStrategy; //Field offset: 0x40
	private float _nextTimeCheckWannaFight; //Field offset: 0x48
	private Vector3 closestPosLeft; //Field offset: 0x4C
	private Vector3 closestPosRight; //Field offset: 0x58
	private Vector3 posToTarget; //Field offset: 0x64
	private float _activateTime; //Field offset: 0x70
	private float _nextPosibleSimulator; //Field offset: 0x74
	private readonly Dictionary _shooterPosGood; //Field offset: 0x78
	private float _nextPosibleForceRecalc; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnPositionsRecalculated; //Field offset: 0x88
	[CompilerGenerated]
	private bool <EnoughtHaveGoodCovers>k__BackingField; //Field offset: 0x90

	public event Action OnPositionsRecalculated
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public private bool EnoughtHaveGoodCovers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Nullable PointForBoss
	{
		 get { } //Length: 150
	}

	public BossKnight(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	[CompilerGenerated]
	public void add_OnPositionsRecalculated(Action value) { }

	public virtual void BossLogicUpdate() { }

	[CanBeNull]
	private Dictionary CalcOptimalPositions(List positions, List bots) { }

	public bool CanStartUseStimulator() { }

	private void CheckRecalcCore() { }

	private Dictionary Clone(Dictionary shooterPosGood) { }

	public virtual void Dispose() { }

	private Meds FindMedsToDropToBot() { }

	private void FindPositionsForFollowers(bool anyway) { }

	private void ForceRecalcShootPos(int shootPosKey) { }

	[CompilerGenerated]
	public bool get_EnoughtHaveGoodCovers() { }

	public Nullable get_PointForBoss() { }

	private bool IsEnoughtShootersPos() { }

	public virtual void OnDrawGizmosSelected() { }

	private void OnFollowerStatusChange(IBotOwner botFollower, FollowerStatusChange status) { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	private void OnSetStrategy(BaseBrain obj) { }

	private void OnStartPeacefulMove(BotsPairData obj) { }

	private void RefreshStrategy() { }

	[CompilerGenerated]
	public void remove_OnPositionsRecalculated(Action value) { }

	[CompilerGenerated]
	private void set_EnoughtHaveGoodCovers(bool value) { }

	public void SetFightPosition(bool isGood, BotOwner bot) { }

	public virtual void SetPatrolMode() { }

	public void SomebodyUseStimulator() { }

	private void UpdatePositions(bool anyway) { }

	public void WannHeal(BotOwner healTarget) { }

}

