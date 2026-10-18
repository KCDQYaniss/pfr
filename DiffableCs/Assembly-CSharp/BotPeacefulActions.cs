//Type is in global namespace

public class BotPeacefulActions : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public BotPeacefulActions <>4__this; //Field offset: 0x10
		public EInteraction gestus; //Field offset: 0x18
		public BotsPairData pairData; //Field offset: 0x20

		public <>c__DisplayClass13_0() { }

		internal void <SetActiveAction>g__doAction|0() { }

	}

	private const float STANDART_DELAY = 1; //Field offset: 0x0
	private readonly List _list; //Field offset: 0x18
	private float _nextGusture; //Field offset: 0x20
	private BotsPairData _activeData; //Field offset: 0x28
	private EInteraction _lastGesture; //Field offset: 0x30
	private bool _errorInited; //Field offset: 0x31
	[CompilerGenerated]
	private Action OnStartPeacefulMove; //Field offset: 0x38

	public event Action OnStartPeacefulMove
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private BotGlobalPatrolSettings _patrolSettings
	{
		private get { } //Length: 45
	}

	public BotPeacefulActions(BotOwner owner) { }

	[CompilerGenerated]
	public void add_OnStartPeacefulMove(Action value) { }

	public void Dispose() { }

	private BotGlobalPatrolSettings get__patrolSettings() { }

	public bool HaveActions() { }

	private void OnPairDataStops(BotsPairData obj) { }

	[CompilerGenerated]
	public void remove_OnStartPeacefulMove(Action value) { }

	public void RemovePlayer(IPlayer gamePerson) { }

	public void SetActiveAction(BotsPairData pairData, EInteraction gestus, float delay = -1) { }

	private void SetActiveData(BotsPairData data) { }

	public void StartDo(BotsPairData pairData) { }

	public void UpdateAction() { }

}

