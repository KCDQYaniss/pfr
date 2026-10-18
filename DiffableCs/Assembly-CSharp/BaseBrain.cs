//Type is in global namespace

public abstract class BaseBrain : AICoreStrategy
{
	public const int DEBUG_LOGIC = 1000; //Field offset: 0x0
	public const int WAIT = 24; //Field offset: 0x0
	protected BotOwner _owner; //Field offset: 0x40
	private readonly DebugLogicLayer _debug; //Field offset: 0x48
	private WaitLayer _waitLayer; //Field offset: 0x50

	public AICoreLayer CurLayerInfo
	{
		 get { } //Length: 62
	}

	protected BaseBrain(BotOwner owner) { }

	public void ActivateDebug(DebugBotDesition logic) { }

	public void ActivateLayers(List layers) { }

	private void AddEventsLayers(BotOwner owner) { }

	public void CalcActionNextFrame() { }

	public void DeactivateDebug() { }

	public string DebugHandler() { }

	protected abstract BotEventsPriority EventsPriority() { }

	public CustomNavigationPoint FindPoint(CoverSearchData data, Func getCoverPointMain2, bool checkCurrent) { }

	public AICoreLayer get_CurLayerInfo() { }

	protected void InitAddWaitLayer(BotOwner owner) { }

	public abstract string ShortName() { }

}

