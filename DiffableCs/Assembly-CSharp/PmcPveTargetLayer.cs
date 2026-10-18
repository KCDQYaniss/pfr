//Type is in global namespace

internal class PmcPveTargetLayer : BaseLogicLayer
{
	private const float DANGER_DISTANCE_SQR = 40000; //Field offset: 0x0
	private readonly bool _withSearch; //Field offset: 0x90
	private float _forgetTargetTime; //Field offset: 0x94

	public PmcPveTargetLayer(BotOwner bot, int priority, bool withSearch) { }

	protected virtual AICoreActionEnd EndAxeTarget() { }

	protected virtual AICoreActionEnd EndGoToLootPointNode() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndShootToSmoke() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void ResetWaitTimer(PlaceForCheck p1, PlaceForCheck p2) { }

	private bool ShallSearch() { }

	public virtual bool ShallUseNow() { }

}

