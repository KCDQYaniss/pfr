//Type is in global namespace

public class BotsList
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public EPlayerSide side; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <GetOtherSideRule>b__0(BotOwner x) { }

	}

	private static readonly Stopwatch _botUpdateMeasureSw; //Field offset: 0x0
	private readonly HashSet _internalStorage; //Field offset: 0x10
	private BotsConnections _connections; //Field offset: 0x18
	private HashSet _loggedErrors; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnBotAdd; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnBotRemove; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnPlayerRemove; //Field offset: 0x38
	private List _botsToAdd; //Field offset: 0x40

	public event Action OnBotAdd
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnBotRemove
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnPlayerRemove
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public IEnumerable BotOwners
	{
		 get { } //Length: 5
	}

	public int Count
	{
		 get { } //Length: 65
	}

	private static BotsList() { }

	public BotsList(BotsConnections connections) { }

	public void Add(BotOwner bot) { }

	[CompilerGenerated]
	public void add_OnBotAdd(Action value) { }

	[CompilerGenerated]
	public void add_OnBotRemove(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerRemove(Action value) { }

	public void AddFromList() { }

	public void AddPlayer(Player player) { }

	public void CheckActivation() { }

	public void Clear() { }

	public BotOwner FirstOrDefault() { }

	public IEnumerable get_BotOwners() { }

	public int get_Count() { }

	public BotsConnections GetConnector() { }

	public List GetListByZone(BotZone zone) { }

	public IEnumerable GetOtherSideRule(EPlayerSide side) { }

	public bool Remove(BotOwner bot) { }

	[CompilerGenerated]
	public void remove_OnBotAdd(Action value) { }

	[CompilerGenerated]
	public void remove_OnBotRemove(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerRemove(Action value) { }

	public void RemovePlayer(Player player) { }

	public void Stop() { }

	public void UpdateByUnity() { }

}

