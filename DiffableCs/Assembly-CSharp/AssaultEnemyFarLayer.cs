//Type is in global namespace

public class AssaultEnemyFarLayer : BaseLogicLayer
{
	private float _visibleEndHoldTime; //Field offset: 0x90
	private float _nextUsageTime; //Field offset: 0x94

	public AssaultEnemyFarLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	private float FightDistanceForCurrentWeapon() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

