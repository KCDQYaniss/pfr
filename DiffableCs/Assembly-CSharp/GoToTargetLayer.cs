//Type is in global namespace

public class GoToTargetLayer : BaseLogicLayer
{
	private bool _tryInited; //Field offset: 0x90
	private bool _isEnbaled; //Field offset: 0x91
	private AIPlaceInfoLogicGoToTarget _target; //Field offset: 0x98
	private Nullable _cached; //Field offset: 0xA0
	private float _comingSDist; //Field offset: 0xB0

	public GoToTargetLayer(BotOwner bot, float comingDist, int priority) { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	public virtual AICoreActionResult GetDecision() { }

	private void LazyInit() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	public virtual bool ShallUseNow() { }

}

