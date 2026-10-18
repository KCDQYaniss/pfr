//Type is in global namespace

public class VSRFDefence : BaseLogicLayer
{
	protected int MAX_SDIST_FROM_BOSS; //Field offset: 0x90
	protected int PERIOD_TO_HEAL; //Field offset: 0x94
	protected int MIN_ERFECT_ATTACK_DIST; //Field offset: 0x98
	protected int PERFECT_ATTACK_DIST; //Field offset: 0x9C
	protected int PERFECT_DIST; //Field offset: 0xA0
	protected CustomNavigationPoint _coverInMiddle; //Field offset: 0xA8
	private float _nextCheckCoverInMiddle; //Field offset: 0xB0
	private readonly BotFindPlaceToShoot _finder; //Field offset: 0xB8

	public VSRFDefence(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected void RecheckCoverAtMiddle() { }

	public virtual bool ShallUseNow() { }

	protected CoverSearchData ShootData() { }

	private ShootToPoint ShootTo() { }

	private bool ShouldHeal() { }

}

