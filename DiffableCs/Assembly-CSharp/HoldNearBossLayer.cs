//Type is in global namespace

public class HoldNearBossLayer : BaseLogicLayer
{

	public HoldNearBossLayer(BotOwner bot, int priority) { }

	private Vector3 BossPos() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

