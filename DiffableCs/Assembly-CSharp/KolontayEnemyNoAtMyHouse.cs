//Type is in global namespace

public class KolontayEnemyNoAtMyHouse : KolontayAbstractFightLayer
{
	private const bool MUST_BE_PERIOD_TO_LEAVE_ZONE = True; //Field offset: 0x0
	private const float PERIOD_TO_LEAVE_ZONE = 6; //Field offset: 0x0
	private readonly BossFinder _boss; //Field offset: 0xA0

	public KolontayEnemyNoAtMyHouse(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

