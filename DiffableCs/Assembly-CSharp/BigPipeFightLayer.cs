//Type is in global namespace

public class BigPipeFightLayer : BossKillaLayer
{
	private const float LAST_SUPPRESS_DELTA_SDIST = 4; //Field offset: 0x0
	private const float PERIOD_AFTER_START = 60; //Field offset: 0x0
	private const float PERIOD_CHECK = 10; //Field offset: 0x0
	private const float CHECK_BAD_VAL_PERIOD = 10; //Field offset: 0x0
	private readonly BigPipeBotWeaponSelector _weaponController; //Field offset: 0xD0
	private readonly List _massSuppressCenter; //Field offset: 0xD8
	private NavMeshPath _path; //Field offset: 0xE0
	private float _nextSuppressCheck; //Field offset: 0xE8
	private float _prevBadValTime; //Field offset: 0xEC
	private float _lastShootSuppress; //Field offset: 0xF0
	private Vector3 _lastSuppressPointEnemy; //Field offset: 0xF4

	public BigPipeFightLayer(BotOwner owner, int priority) { }

	private BotLogicDecision AttackOrSuppressZigZag() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private AICoreActionResult MainFight() { }

	private AICoreActionResult MidDistPipe() { }

	public virtual string Name() { }

	private BotLogicDecision SuppressFireEnemy(EnemyInfo enemy) { }

	private bool TryWannaMassSuppress() { }

}

