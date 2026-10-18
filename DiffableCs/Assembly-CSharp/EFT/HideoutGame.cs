namespace EFT;

internal sealed class HideoutGame : BaseLocalGame
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8
		public static Func <>9__6_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <PlayerFactory>b__6_0() { }

		internal float <PlayerFactory>b__6_1() { }

	}

	[CompilerGenerated]
	private struct <DisposeAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <InitSessionUI>d__7 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HideoutGame <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <InitSessionUI>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <PlayerFactory>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameWorld gameWorld; //Field offset: 0x20
		public int playerId; //Field offset: 0x28
		public Vector3 position; //Field offset: 0x2C
		public Quaternion rotation; //Field offset: 0x38
		public Profile profile; //Field offset: 0x48
		public HideoutGame <>4__this; //Field offset: 0x50
		public EUpdateMode armsUpdateMode; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private OfflineInventoryController _originalInventory; //Field offset: 0x150
	private OfflineHealthController _healthController; //Field offset: 0x158
	private QuestController _questController; //Field offset: 0x160
	private AchievementsController _achievementsController; //Field offset: 0x168
	private ClientDialogController _dialogController; //Field offset: 0x170

	public HideoutGame() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0() { }

	internal static HideoutGame Create(IInputTree inputTree, GameWorld gameWorld, Profile profile, OfflineInventoryController originalInventory, GameDateTime backendDateTime, InsuranceCompany insurance, GameUI gameUI, Location location, TimeAndWeatherSettings timeAndWeather, WavesSettings wavesSettings, EDateTime dateTime, Callback callback, float fixedDeltaTime, EUpdateQueue updateQueue, IEftSession backEndSession, OfflineHealthController healthController, ClientDialogController dialogController, QuestController questController, AchievementsController achievementsController) { }

	public virtual void Dispose() { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__10))]
	private Task DisposeAsync() { }

	[IteratorStateMachine(typeof(<InitSessionUI>d__7))]
	protected virtual IEnumerator InitSessionUI() { }

	protected virtual void LocalLeaveGame() { }

	[AsyncStateMachine(typeof(<PlayerFactory>d__6))]
	protected virtual Task PlayerFactory(GameWorld gameWorld, int playerId, Vector3 position, Quaternion rotation, string layerName, string prefix, EPointOfView pointOfView, Profile profile, bool aiControl, EUpdateQueue updateQueue, EUpdateMode armsUpdateMode, EUpdateMode bodyUpdateMode, Mode characterControllerMode, Func getSensitivity, Func getAimingSensitivity, IStatisticsManager statisticsManager, IEftSession session, ELocalMode localMode) { }

	protected virtual void SessionRun() { }

}

