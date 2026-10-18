//Type is in global namespace

public class BlackDivisionDefence : BlackDivisionAbstract
{
	private readonly BotFindPlaceToShoot _finder; //Field offset: 0x98
	protected int MIN_ERFECT_ATTACK_DIST; //Field offset: 0xA0
	protected int PERFECT_ATTACK_DIST; //Field offset: 0xA4
	protected int PERIOD_TO_HEAL; //Field offset: 0xA8

	public BlackDivisionDefence(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

	private ShootToPoint ShootTo() { }

	private bool ShouldHeal() { }

}

