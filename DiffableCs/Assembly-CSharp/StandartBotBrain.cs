//Type is in global namespace

public class StandartBotBrain : BotData
{
	[CompilerGenerated]
	private AICoreAgent <Agent>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private BaseBrain <BaseBrain>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnSetStrategy; //Field offset: 0x28
	[CompilerGenerated]
	private string <GetStateName>k__BackingField; //Field offset: 0x30

	public event Action OnSetStrategy
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private AICoreAgent Agent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BaseBrain BaseBrain
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public string GetStateName
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Nullable LastDecision
	{
		 get { } //Length: 113
	}

	public StandartBotBrain(BotOwner owner) { }

	[CompilerGenerated]
	private AICoreNode <Activate>b__19_0(BotLogicDecision decision) { }

	public void Activate() { }

	public string ActiveLayerName() { }

	[CompilerGenerated]
	public void add_OnSetStrategy(Action value) { }

	public void Deactivate() { }

	public string DebugHandler() { }

	public void Dispose() { }

	public CustomNavigationPoint FindPoint(CoverSearchData data, Func getCoverPointMain2, bool checkCurrent) { }

	[CompilerGenerated]
	public AICoreAgent get_Agent() { }

	[CompilerGenerated]
	public BaseBrain get_BaseBrain() { }

	[CompilerGenerated]
	public string get_GetStateName() { }

	public Nullable get_LastDecision() { }

	public string GetActiveNodeReason() { }

	public string GetCustomData() { }

	public string GetLastNode() { }

	public bool IsProblem() { }

	public int NodeRepeats() { }

	[CompilerGenerated]
	public void remove_OnSetStrategy(Action value) { }

	[CompilerGenerated]
	private void set_Agent(AICoreAgent value) { }

	[CompilerGenerated]
	private void set_BaseBrain(BaseBrain value) { }

	[CompilerGenerated]
	public void set_GetStateName(string value) { }

	public void SetHandlerName(string info) { }

}

