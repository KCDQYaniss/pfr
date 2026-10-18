//Type is in global namespace

public class WedgeMidDist : BaseWedgeLayer
{
	private readonly BossWedgeDistTracker _distTracker; //Field offset: 0xB0
	private float _possibleSuppress; //Field offset: 0xB8
	private float _startSuppress; //Field offset: 0xBC
	private float _endAttackMoving; //Field offset: 0xC0

	public WedgeMidDist(BotOwner bot, int priority, BossWedgeDistTracker distTracker) { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndAttackMovingFlank() { }

	protected virtual AICoreActionEnd EndAttackMovingFlankToPoint() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	protected virtual AICoreActionEnd EndSuppressFromCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private bool GettedHitSoon() { }

	public virtual string Name() { }

	private bool SawEnemyLongTime() { }

	public virtual bool ShallUseNow() { }

	private bool WannaHelp() { }

	private bool WannaSupress() { }

}

