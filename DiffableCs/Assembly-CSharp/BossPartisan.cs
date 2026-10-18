//Type is in global namespace

public class BossPartisan : ABossLogic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ApplyShot>b__28_0(BodyPartCollider x) { }

	}

	private const float SDIST_TO_PERSUIT_SAVAGE = 90000; //Field offset: 0x0
	private const float CHANCE_TO_ATTACK_ZERO_KARMA = 120; //Field offset: 0x0
	public const float SAVAGE_KARMA_TO_SEARCH = 0.5; //Field offset: 0x0
	public const float MINES_RADIUS = 50; //Field offset: 0x0
	public const float SDIST_SAFE_PREWARM = 81; //Field offset: 0x0
	private const float SDIST_PREWARM = 2500; //Field offset: 0x0
	private const int DAMAGE_TO_HEAD = 20; //Field offset: 0x0
	private const int MAX_PREWARERPLANTED = 20; //Field offset: 0x0
	private float _lastMinesPlantComplete; //Field offset: 0x20
	private AIPeriodAction _period; //Field offset: 0x28
	private AIPlaceInfo _lastUsing; //Field offset: 0x30
	private bool _willAttackZeroKarma; //Field offset: 0x38
	private bool _isWorstFinded; //Field offset: 0x39
	private bool _isFirstCheck; //Field offset: 0x3A
	private float SAVAGE_LOW_KARMA_TO_FIRST_KILL; //Field offset: 0x3C
	private float _lastExtraDamage; //Field offset: 0x40
	private bool _isMinesPrewarmed; //Field offset: 0x44
	private List _listOfPrewarms; //Field offset: 0x48
	private EBossPartisanEnemyType _partisanEnemyType; //Field offset: 0x50

	public EBossPartisanEnemyType PartisanEnemyType
	{
		 get { } //Length: 4
	}

	public BossPartisan(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	protected void ApplyShot(Player player, bool lethal) { }

	public virtual void BossLogicUpdate() { }

	public static bool CanPersuit(IPlayer player, BotSettingsComponents bot) { }

	private void CheckKnife() { }

	public virtual void Dispose() { }

	public int EnemiesAtClosestsZone() { }

	public EBossPartisanEnemyType get_PartisanEnemyType() { }

	private void OnEnemyHitted(BotOwner arg1, Player target) { }

	private void OnTripwireChangeState(TripwireSynchronizableObject obj) { }

	private void PeriodSetInfo() { }

	private void PrewarmMines() { }

	public virtual void SetPatrolMode() { }

}

