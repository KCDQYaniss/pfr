//Type is in global namespace

public class BotEnemiesMissController : BotData
{
	private const string MissLogSameRole = "[BotEnemiesMiss|SameRole]"; //Field offset: 0x0
	private const string MissLogSameGroup = "[BotEnemiesMiss|SameGroup]"; //Field offset: 0x0
	private const string MissLogSharedFireMiss = "[BotEnemiesMiss|SharedFireIndexMiss]"; //Field offset: 0x0
	private const string MissLogTransitionProneStand = "[BotEnemiesMiss|TransitionProneStand]"; //Field offset: 0x0
	private const string MissLogTransitionLowPose = "[BotEnemiesMiss|TransitionLowPose]"; //Field offset: 0x0
	private const string MissLogAfterSprint = "[BotEnemiesMiss|AfterSprint]"; //Field offset: 0x0
	private const string MissLogHeadRange = "[BotEnemiesMiss|HeadLongRange]"; //Field offset: 0x0
	private const string MissLogMovePath = "[BotEnemiesMiss|MovePath]"; //Field offset: 0x0
	private const string MissLogAimBudget = "[BotEnemiesMiss|AimMissBudget]"; //Field offset: 0x0
	private BotEnemiesController _botEnemies; //Field offset: 0x18
	private float _lastEndWay; //Field offset: 0x20
	private float PERIOD_AFTER_ENDS_SPRINT; //Field offset: 0x24
	private int _afterSprintShootsMissRemain; //Field offset: 0x28
	private int _lastFireIndex; //Field offset: 0x2C
	private bool _lastGets; //Field offset: 0x30
	private float _shouldMissOnDist; //Field offset: 0x34

	private float _allMissDist
	{
		private get { } //Length: 58
	}

	private bool _shouldMissAfterSprint
	{
		private get { } //Length: 57
	}

	private bool _shouldMissOnMove
	{
		private get { } //Length: 57
	}

	private bool _shouldMissOnSameBot
	{
		private get { } //Length: 57
	}

	private bool _shouldMissOnSameGroup
	{
		private get { } //Length: 57
	}

	private bool _shouldMissOnTransitions
	{
		private get { } //Length: 57
	}

	private bool _shouldMissToHead
	{
		private get { } //Length: 57
	}

	public BotEnemiesMissController(BotEnemiesController botEnemiesController, BotOwner owner) { }

	public void Activate() { }

	public void Dispose() { }

	private float get__allMissDist() { }

	private bool get__shouldMissAfterSprint() { }

	private bool get__shouldMissOnMove() { }

	private bool get__shouldMissOnSameBot() { }

	private bool get__shouldMissOnSameGroup() { }

	private bool get__shouldMissOnTransitions() { }

	private bool get__shouldMissToHead() { }

	private void OnWayChanged(bool obj) { }

	public bool ShouldApplyDamage(Player target, DamageInfo damage, EBodyPart bodyPartType) { }

	private bool ShouldMiss(EnemyInfo info, DamageInfo damage) { }

}

