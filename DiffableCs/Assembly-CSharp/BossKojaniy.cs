//Type is in global namespace

public class BossKojaniy : BossWithStayFollowersPosition, IBossKojaniy
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__39_0; //Field offset: 0x8
		public static Func <>9__39_2; //Field offset: 0x10
		public static Func <>9__39_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <SetPatrolMode>b__39_0(AIPlaceInfo x) { }

		internal bool <SetPatrolMode>b__39_1(PatrolWay x) { }

		internal bool <SetPatrolMode>b__39_2(AIPlaceInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public KeyValuePair enemyInfo; //Field offset: 0x10
		public BossKojaniy <>4__this; //Field offset: 0x20

		public <>c__DisplayClass47_0() { }

		internal void <OnPlayerEnter>g__ReportTask|0() { }

	}

	private const float DIST_TO_C = 40; //Field offset: 0x0
	private const string LOOT_ID = "Lootable_kojaniy"; //Field offset: 0x0
	private const float SDIST_NEAR_LOOT = 225; //Field offset: 0x0
	private const float MIN_DIST_TO_ENEMY_SQRT = 100; //Field offset: 0x0
	private const float RND_OFFST = 10; //Field offset: 0x0
	private const float Y_OFFSET = 3; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnThrowRequest; //Field offset: 0x50
	private readonly List _controlPoins; //Field offset: 0x58
	private float _nextTimeCheckWannaFight; //Field offset: 0x60
	private float _nextTimeCheckWannaSupress; //Field offset: 0x64
	private Vector3 _tarketToLook; //Field offset: 0x68
	private Vector3 _lastCorerecalc; //Field offset: 0x74
	private Vector3 closestPosLeft; //Field offset: 0x80
	private Vector3 closestPosRight; //Field offset: 0x8C
	private Vector3 posToTarget; //Field offset: 0x98
	private float _supressRequestTakenTime; //Field offset: 0xA4
	private readonly Vector3 _offsetCorePosition; //Field offset: 0xA8
	private AIPlaceInfo _cellWithLoot; //Field offset: 0xB8
	[CompilerGenerated]
	private Action OnPositionsRecalculated; //Field offset: 0xC0
	[CompilerGenerated]
	private Vector3 <LootPosition>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private bool <ShallAttack>k__BackingField; //Field offset: 0xD4

	public virtual event Action OnPositionsRecalculated
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override event Action OnThrowRequest
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private override Vector3 LootPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private override bool ShallAttack
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public BossKojaniy(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	[CompilerGenerated]
	public virtual void add_OnPositionsRecalculated(Action value) { }

	[CompilerGenerated]
	public override void add_OnThrowRequest(Action value) { }

	public virtual void BossLogicUpdate() { }

	public static Dictionary CalcOptimalPositions(List positions, List bots) { }

	[CanBeNull]
	public static Dictionary CalcOptimalPositions2(List positions, List bots) { }

	public override bool CanStartSuppress() { }

	private void CheckEndFight() { }

	private void CheckRecalcCore() { }

	private void CheckWannaAskSuppress() { }

	private void CheckWannaFight() { }

	private List ClosestPoints(int count, List posiblePositions, Vector3 closestTo, Vector3 enemyPos) { }

	public virtual void Dispose() { }

	private void EndFight() { }

	protected virtual void FindPositionsForFollowers(bool anyway) { }

	[CompilerGenerated]
	public override Vector3 get_LootPosition() { }

	[CompilerGenerated]
	public override bool get_ShallAttack() { }

	public virtual Vector3 GetTargetToLook() { }

	public override bool ISeeEnemy() { }

	public override bool IsNearLoot(EnemyInfo enemy) { }

	public override bool IsRunning() { }

	private void OnBulletNear(BotOwner bot, IPlayer source) { }

	public virtual void OnDrawGizmosSelected() { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	private void OnPlayerEnter(Player player) { }

	[CompilerGenerated]
	public virtual void remove_OnPositionsRecalculated(Action value) { }

	[CompilerGenerated]
	public override void remove_OnThrowRequest(Action value) { }

	[CompilerGenerated]
	private void set_LootPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_ShallAttack(bool value) { }

	protected virtual void SetLogicToFollower(FollowerKojaniyLayersStrategy followerLogic) { }

	public virtual void SetPatrolMode() { }

	public override void SetWannaFight() { }

	public override void SupressRequestTaken() { }

	public override bool TooManyEnemies() { }

	private void UpdatePositions(bool anyway) { }

}

