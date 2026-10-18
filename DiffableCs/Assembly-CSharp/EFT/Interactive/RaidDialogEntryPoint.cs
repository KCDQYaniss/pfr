namespace EFT.Interactive;

public sealed class RaidDialogEntryPoint : DialogEntryPointBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public RaidDialogEntryPoint <>4__this; //Field offset: 0x10
		public LocalPlayer localPlayer; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <StartDialogOffline>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public ClientPlayer player; //Field offset: 0x10
		public RaidDialogEntryPoint <>4__this; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <StartDialogOnline>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public RaidDialogEntryPoint entryPoint; //Field offset: 0x10
		public Action closeAction; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <ShowRaidTraderDialogScreen>b__0() { }

	}

	[CompilerGenerated]
	private struct <StartDialog>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RaidDialogEntryPoint <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartDialogOffline>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RaidDialogEntryPoint <>4__this; //Field offset: 0x20
		private <>c__DisplayClass11_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartDialogOnline>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RaidDialogEntryPoint <>4__this; //Field offset: 0x20
		private <>c__DisplayClass12_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string BUSY_LOCALE_KEY = "RaidDialogEntryPoint/Busy"; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Unique per instance on the location; used for occupancy on the server.")]
	private string _pointId; //Field offset: 0x90
	[SerializeField]
	private float _interactionDistance; //Field offset: 0x98
	private float _interactionDistanceSqr; //Field offset: 0x9C
	private GamePlayerOwner _gamePlayerOwner; //Field offset: 0xA0

	public string PointId
	{
		 get { } //Length: 8
	}

	public RaidDialogEntryPoint() { }

	[CompilerGenerated]
	private void <InteractionStates>b__9_0() { }

	private void Awake() { }

	public bool DistanceCheck(Vector3 playerPosition) { }

	public string get_PointId() { }

	public virtual void Init(IEnumerable traders) { }

	public AvailableInteractionState InteractionStates(GamePlayerOwner owner) { }

	private void OnDisable() { }

	private void OnOccupancyChanged(string pointId) { }

	public void OnRaidDialogClosed() { }

	private void ShowRaidTraderDialogScreen(GamePlayerOwner playerOwner, RaidDialogEntryPoint entryPoint, Player player, Action closeAction) { }

	[AsyncStateMachine(typeof(<StartDialog>d__10))]
	private Task StartDialog() { }

	private void StartDialogMediaPresenter(ClientDialogController dialogController) { }

	[AsyncStateMachine(typeof(<StartDialogOffline>d__11))]
	private Task StartDialogOffline() { }

	[AsyncStateMachine(typeof(<StartDialogOnline>d__12))]
	private Task StartDialogOnline() { }

	protected virtual void UpdateAvailability() { }

}

