//Type is in global namespace

internal class AdvAssaultTargetLayer : BaseLogicLayer
{
	private readonly bool _withSearch; //Field offset: 0x90
	private readonly bool _useLimitedHeardHold; //Field offset: 0x91
	private bool _holdTimerStarted; //Field offset: 0x92
	private float _reactedUntilTime; //Field offset: 0x94

	public AdvAssaultTargetLayer(BotOwner bot, int priority, bool withSearch) { }

	private void CloseHeardIncident() { }

	protected virtual AICoreActionEnd EndAxeTarget() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndShootToSmoke() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private AICoreActionResult GetLimitedHeardHoldDecision() { }

	private bool HasNewerHeardStimulus() { }

	public virtual string Name() { }

	private bool ShallSearch() { }

	public virtual bool ShallUseNow() { }

}

