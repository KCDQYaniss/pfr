//Type is in global namespace

public class BossBoar : ABossLogic, IBossAskingForSuppress
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public BotOwner bot; //Field offset: 0x10
		public BossBoar <>4__this; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <OnBotAdd>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public Vector3 posToSuppress; //Field offset: 0x10
		public Func <>9__0; //Field offset: 0x20

		public <>c__DisplayClass30_0() { }

		internal Vector3 <OnBulletNear>b__0() { }

	}

	private const float BOSS_HIT_RUSH_PERIOD = 10; //Field offset: 0x0
	private const float CHECK_SMOKE_PERIOD = 4; //Field offset: 0x0
	private const float DIST_TO_ATTACK_NOW = 30; //Field offset: 0x0
	private const string EVENT_ID = "BossBoarBorn"; //Field offset: 0x0
	private const int NEED_ENEMIES_TO_SMOKE = 2; //Field offset: 0x0
	private const float PERIOD_SUPPRESS = 5; //Field offset: 0x0
	private const float PeriodToStopHoldAndAttack = 5; //Field offset: 0x0
	private const float SDIST_TO_SUPPRESS_AGS = 6400; //Field offset: 0x0
	public float _lastTimeHit; //Field offset: 0x20
	private float _nextPossibleSuppress; //Field offset: 0x24
	private float _nextSmokeCheck; //Field offset: 0x28
	private readonly float _periodToStopHoldAndAttack; //Field offset: 0x2C
	private float _lastFollowerStartAttack; //Field offset: 0x30
	private float _lastGoalSetted; //Field offset: 0x34
	private float _endWantSuppress; //Field offset: 0x38
	private float _nextPossibleWant; //Field offset: 0x3C

	public bool IsHitted
	{
		 get { } //Length: 94
	}

	public BossBoar(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	public virtual void BossLogicUpdate() { }

	public bool CanStartMoveToAttackPoint(BotOwner askingBot) { }

	private void CheckingSmokeGrenade() { }

	public virtual void Dispose() { }

	public bool get_IsHitted() { }

	private bool HaveSmokeGrenade(IBotOwner mem) { }

	private void OnBossGetHit(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	private void OnBotAdd(BotOwner bot) { }

	private void OnBulletNear(BotOwner bot, IPlayer source) { }

	private void OnFollowerStatusChange(IBotOwner follower, FollowerStatusChange status) { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	public override void ReportEnemy(IPlayer enemy, Vector3 enemypos, EEnemyPartVisibleType visibleType) { }

	public virtual void SetPatrolMode() { }

	public override void SetWantSuppress() { }

	public void StartMoveToAttackPoint(int id) { }

	public override bool WantSuppress() { }

}

