//Type is in global namespace

public class WedgeGrenadeLayer : BaseWedgeLayer
{
	private const float DIST_REACTION_LAYER = 15; //Field offset: 0x0
	private PeriodicCheck _distCheck; //Field offset: 0xB0

	public WedgeGrenadeLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsGoodDist() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

