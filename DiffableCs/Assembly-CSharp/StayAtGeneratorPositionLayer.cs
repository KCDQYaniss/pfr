//Type is in global namespace

public class StayAtGeneratorPositionLayer : PatrolStayAtPositionLayer
{
	private const float RESET_COVER_TIMEOUT = 5; //Field offset: 0x0
	private float _lastResetCoverTime; //Field offset: 0xD0
	private readonly float _usingLayerDelay; //Field offset: 0xD4
	private float _firstTimeShallUse; //Field offset: 0xD8

	public StayAtGeneratorPositionLayer(BotOwner bot, int priority, bool tryFinGreenFirst, CoverLevel minGreenPointCoverLevel = 2, bool usePeriodForceReched = false) { }

	private bool ActivationDelayPassed(bool shallUse) { }

	public virtual AICoreActionResult GetDecision() { }

	private static bool IsNear(Vector3 left, Vector3 right, int radius) { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	public virtual bool ShallUseNow() { }

}

