//Type is in global namespace

public class BlackDivisionFight : BlackDivisionAbstract
{
	private const float SHOULD_FIGHT_WITH_AI = 20; //Field offset: 0x0
	private readonly BotFindPlaceToShoot _finder; //Field offset: 0x98
	protected int MIN_ERFECT_ATTACK_DIST; //Field offset: 0xA0
	protected int PERFECT_ATTACK_DIST; //Field offset: 0xA4

	public BlackDivisionFight(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

	private ShootToPoint ShootTo() { }

}

