//Type is in global namespace

public sealed class BossWedgeFlankNavMetrics
{
	public const float COOLDOWN = 10; //Field offset: 0x0
	public const float COOLDOWN_GOTO_ENEMY = 10; //Field offset: 0x0
	private const float PATH_CACHE_PERIOD = 5; //Field offset: 0x0
	private readonly NavMeshPath _navPathBuffer; //Field offset: 0x10
	private float _pathToEnemyCacheTime; //Field offset: 0x18
	private float _pathToEnemyCacheLength; //Field offset: 0x1C
	private int _pathToEnemyCacheBotId; //Field offset: 0x20
	private int _pathToEnemyCacheGoalEnemyRaidId; //Field offset: 0x24
	private float _lastFlankToPointStartTime; //Field offset: 0x28
	private float _lastGoToEnemyStartTime; //Field offset: 0x2C
	private BotOwner _lastFlankToPointStarter; //Field offset: 0x30
	private BotOwner _lastGoToEnemyStarter; //Field offset: 0x38

	public BossWedgeFlankNavMetrics() { }

	public void CopyFrom(BossWedgeFlankNavMetrics other) { }

	public float GetPathLengthToGoalEnemy(BotOwner bot) { }

	public static float GetRemainingDistanceAlongActivePath(BotOwner bot) { }

	public void OnGroupMemberRemoved(BotOwner removedMember) { }

	public void RegisterAttackMovingFlankToPointStarted(BotOwner starter) { }

	public void RegisterGoToEnemyStarted(BotOwner starter) { }

	public bool ShallDeferFlankBecauseRecentGroupFlank(BotOwner requestingBot, out BotLogicDecision substituteDecision) { }

	public bool ShallHoldBecauseRecentGroupGoToEnemy(BotOwner requestingBot) { }

}

