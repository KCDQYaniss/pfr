namespace EFT;

public sealed class TarkovApplication : CommonClientApplication, IRaidCounter
{
	[CompilerGenerated]
	private struct <<ExitApplication>g__ForceShutdown|218_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<ExitApplication>g__LogOut|218_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<InitIconCreators>g__CreateIconCreator|198_3>d`3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Func constructor; //Field offset: 0x0
		private Token <>7__wrap1; //Field offset: 0x0
		private TCreator <iconCreator>5__3; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<ShowSessionResult>g__LoadSessionResultScene|247_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private IDisposable <>7__wrap1; //Field offset: 0x20
		private OperationAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__112_0; //Field offset: 0x8
		public static Func <>9__198_2; //Field offset: 0x10
		public static Func <>9__215_1; //Field offset: 0x18
		public static Action <>9__216_3; //Field offset: 0x20
		public static Action <>9__217_1; //Field offset: 0x28
		public static Action <>9__221_2; //Field offset: 0x30
		public static Func <>9__233_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal void <AppLoadReconnectScenario>b__216_3() { }

		internal void <ExitApplicationWithConfirm>b__217_1() { }

		internal PlayerIconCreator <InitIconCreators>b__198_2() { }

		internal int <LocalGameMatching>b__233_0(RaidPlayer p) { }

		internal IEnumerable <Run>b__215_1(RepeatableQuestsRange questRange) { }

		internal void <ShowTimeHasComeScreen>b__221_2() { }

		internal void <ValidateAnticheat>b__112_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass111_0
	{
		public string gameMap; //Field offset: 0x10

		public <>c__DisplayClass111_0() { }

		internal bool <InternalStartGame>b__0(Location v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass128_0
	{
		public ErrorWindowContext context; //Field offset: 0x10

		public <>c__DisplayClass128_0() { }

		internal void <ShowCriticalBackendErrorDialog>g__CloseHandler|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass139_0
	{
		public TarkovApplication <>4__this; //Field offset: 0x10
		public bool fullReload; //Field offset: 0x18

		public <>c__DisplayClass139_0() { }

		internal void <ShowExpansionsConfirmationPopup>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass154_0
	{
		public TaskCompletionSource completion; //Field offset: 0x10

		public <>c__DisplayClass154_0() { }

		internal void <ShowLanguageSelection>g__LanguageSelectedHandler|0() { }

		internal void <ShowLanguageSelection>g__ScreenClosedHandler|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass198_0
	{
		public IEasyAssets easyAssets; //Field offset: 0x10

		public <>c__DisplayClass198_0() { }

		internal ItemIconCreator <InitIconCreators>b__0() { }

		internal ClothingIconCreator <InitIconCreators>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass212_0
	{
		public bool isLeaving; //Field offset: 0x10
		public TarkovApplication <>4__this; //Field offset: 0x18
		public bool isPet; //Field offset: 0x20
		public bool isMatching; //Field offset: 0x21

		public <>c__DisplayClass212_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass212_1
	{
		public bool refreshed; //Field offset: 0x10
		public <>c__DisplayClass212_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass212_1() { }

		internal void <WaitLeaving>b__0(Result _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass215_0
	{
		public ProfileStatus profileStatus; //Field offset: 0x10
		public TarkovApplication <>4__this; //Field offset: 0x18

		public <>c__DisplayClass215_0() { }

		internal bool <Run>b__0(Location loc) { }

		internal void <Run>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass216_0
	{
		private struct <<AppLoadReconnectScenario>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass216_0 <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public TarkovApplication <>4__this; //Field offset: 0x10
		public ProfileStatus profileStatus; //Field offset: 0x18
		public bool isPet; //Field offset: 0x20
		public Profile savageProfile; //Field offset: 0x28
		public ReconnectionScreenController reconnectProcessScreenController; //Field offset: 0x30
		public Action <>9__5; //Field offset: 0x38

		public <>c__DisplayClass216_0() { }

		[AsyncStateMachine(typeof(<<AppLoadReconnectScenario>b__0>d))]
		internal void <AppLoadReconnectScenario>b__0() { }

		internal void <AppLoadReconnectScenario>b__1(EMenuType menuType, bool selected) { }

		internal void <AppLoadReconnectScenario>b__5() { }

		internal void <AppLoadReconnectScenario>g__ReconnectLeaveAction|2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass216_1
	{
		private struct <<AppLoadReconnectScenario>b__4>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass216_1 <>4__this; //Field offset: 0x28
			public IResult result; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public Task unloadNarrate; //Field offset: 0x10
		public Task unloadHideout; //Field offset: 0x18
		public <>c__DisplayClass216_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass216_1() { }

		[AsyncStateMachine(typeof(<<AppLoadReconnectScenario>b__4>d))]
		internal void <AppLoadReconnectScenario>b__4(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass221_0
	{
		public TarkovApplication <>4__this; //Field offset: 0x10
		public bool isPet; //Field offset: 0x18
		public CancellationTokenSource cancellationToken; //Field offset: 0x20

		public <>c__DisplayClass221_0() { }

		internal void <ShowTimeHasComeScreen>b__1(IResult result) { }

		internal void <ShowTimeHasComeScreen>g__MatchingAbortHandler|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass228_0
	{
		public TarkovApplication <>4__this; //Field offset: 0x10
		public string matchingName; //Field offset: 0x18
		public bool handled; //Field offset: 0x20

		public <>c__DisplayClass228_0() { }

		internal void <HandleError>b__0() { }

		internal bool <HandleError>g__Handle|1(Exception x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass233_0
	{
		public TarkovApplication <>4__this; //Field offset: 0x10
		public CancellationTokenSource cancellationTokenSource; //Field offset: 0x18

		public <>c__DisplayClass233_0() { }

		internal void <LocalGameMatching>b__1(InitLevelProgress p) { }

		internal bool <LocalGameMatching>b__2(Exception x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass234_0
	{
		public CancellationTokenSource cancellationTokenSource; //Field offset: 0x10
		public TarkovApplication <>4__this; //Field offset: 0x18
		public Action <>9__1; //Field offset: 0x20

		public <>c__DisplayClass234_0() { }

		internal void <NetworkGameMatching>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass234_1
	{
		public AggregateException e; //Field offset: 0x10
		public <>c__DisplayClass234_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass234_1() { }

		internal bool <NetworkGameMatching>b__0(Exception x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass236_0
	{
		public TarkovApplication <>4__this; //Field offset: 0x10
		public float totalCacheProgress; //Field offset: 0x18
		public ProgressAggregator cacheProgressAggregator; //Field offset: 0x20

		public <>c__DisplayClass236_0() { }

		internal void <LoadMapAndData>b__0(float totalProgress) { }

		internal void <LoadMapAndData>b__1(float pr) { }

		internal void <LoadMapAndData>b__2(InitLevelProgress pr) { }

		internal void <LoadMapAndData>b__4(float pr) { }

		internal void <LoadMapAndData>b__5(float pr) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass236_1
	{
		public ClientGameWorld gameWorldCached; //Field offset: 0x10

		public <>c__DisplayClass236_1() { }

		internal void <LoadMapAndData>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass238_0
	{
		public TarkovApplication <>4__this; //Field offset: 0x10
		public string profileId; //Field offset: 0x18
		public Profile savageProfile; //Field offset: 0x20
		public Location location; //Field offset: 0x28

		public <>c__DisplayClass238_0() { }

		internal void <NetworkGameCreate>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass238_1
	{
		public TaskCanceledException e; //Field offset: 0x10
		public <>c__DisplayClass238_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass238_1() { }

		internal void <NetworkGameCreate>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass239_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass239_0() { }

		internal bool <NetworkGameCreateJob>b__0(ProfileStatus status) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass240_0
	{
		public TarkovApplication <>4__this; //Field offset: 0x10
		public ClientGameWorld gameWorld; //Field offset: 0x18
		public ProfileStatus profileStatus; //Field offset: 0x20
		public Profile savageProfile; //Field offset: 0x28
		public Location location; //Field offset: 0x30
		public EftNetworkGame game; //Field offset: 0x38
		public NetworkGameSession session; //Field offset: 0x40

		public <>c__DisplayClass240_0() { }

		internal void <NetworkGameCreate>b__0() { }

		internal void <NetworkGameCreate>b__2() { }

		internal void <NetworkGameCreate>b__3() { }

		internal void <NetworkGameCreate>b__4() { }

		internal void <NetworkGameCreate>b__5() { }

		internal void <NetworkGameCreate>g__GameEndCallback|1(Result result) { }

		internal void <NetworkGameCreate>g__MatchingStatusFromGameChanged|6(EMatchingStage stage, Nullable progress) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass243_0
	{
		public TarkovApplication <>4__this; //Field offset: 0x10
		public Profile profile; //Field offset: 0x18
		public Profile savageProfile; //Field offset: 0x20
		public Location location; //Field offset: 0x28
		public LocalGame localGame; //Field offset: 0x30

		public <>c__DisplayClass243_0() { }

		internal void <LocalGameCreate>b__0(Result result) { }

		internal void <LocalGameCreate>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass247_0
	{
		private struct <<ShowSessionResult>g__PreparePostRaidProfileDeferred|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass247_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28
			private Token <>7__wrap1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public TarkovApplication <>4__this; //Field offset: 0x10
		public ProfileStats stats; //Field offset: 0x18

		public <>c__DisplayClass247_0() { }

		[AsyncStateMachine(typeof(<<ShowSessionResult>g__PreparePostRaidProfileDeferred|1>d))]
		internal Task <ShowSessionResult>g__PreparePostRaidProfileDeferred|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass258_0
	{
		public string locationId; //Field offset: 0x10

		public <>c__DisplayClass258_0() { }

		internal bool <TryGetLocationById>b__0(Location loc) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static RequestFailHandler <0>__HandleError; //Field offset: 0x0
		public static Action <1>__Quit; //Field offset: 0x8

	}

	[CompilerGenerated]
	private struct <AppLoadMatchWaitScenario>d__219 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public ProfileStatus profileStatus; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AwaitGameOverSaveStatusAsync>d__183 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AwaitMenuSecondBatchPrefetchAsync>d__205 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private IDisposable <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ComebackToMainMenu>d__250 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool sendLoadStats; //Field offset: 0x20
		public TarkovApplication <>4__this; //Field offset: 0x28
		public bool waitForGameOverSaveStatus; //Field offset: 0x30
		private TaskCompletionSource <menuUiLoadTcs>5__2; //Field offset: 0x38
		private IDisposable <>7__wrap2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private OperationAwaiter <>u__2; //Field offset: 0x50
		private TaskAwaiter <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateBackend>d__121 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public EGameMode gameMode; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureCharacterSelectionSessionAlive>d__147 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureNotificationManagerAsync>d__134 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExecuteCharacterSelection>d__157 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CharacterSelectionResult result; //Field offset: 0x20
		public bool startupFlow; //Field offset: 0x38
		public TarkovApplication <>4__this; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExitApplication>d__218 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GamePrepare>d__237 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool isRaid; //Field offset: 0x20
		public TarkovApplication <>4__this; //Field offset: 0x28
		private Token <>7__wrap1; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private OperationAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GameReconnect>d__220 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public bool inTransition; //Field offset: 0x28
		public bool isPet; //Field offset: 0x29
		public bool canEscape; //Field offset: 0x2A
		public string profileId; //Field offset: 0x30
		public Profile savageProfile; //Field offset: 0x38
		private CancellationTokenSource <cancellationTokenSource>5__2; //Field offset: 0x40
		private ClientMetricsEvents <metricsEvents>5__3; //Field offset: 0x48
		private ClientGameWorld <gameWorld>5__4; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60
		private TaskAwaiter <>u__3; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleExpansionsNotificationAsync>d__138 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NotificationExpansions expansionsNotification; //Field offset: 0x20
		public TarkovApplication <>4__this; //Field offset: 0x28
		private ExpansionsShopNotificationEffects <effects>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitIconCreators>d__198 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitPreloaderUI>d__133 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private LoadSceneOperation <operation>5__2; //Field offset: 0x28
		private LoadSceneOperation <preloaderUiSceneLoading>5__3; //Field offset: 0x30
		private OperationAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InternalStartGame>d__111 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string gameMap; //Field offset: 0x20
		public TarkovApplication <>4__this; //Field offset: 0x28
		public bool isLocalGame; //Field offset: 0x30
		public bool isBotEnabled; //Field offset: 0x31
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAvailableLanguages>d__124 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCharacterSelectionBootstrap>d__149 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private Task <seasonalPerksTask>5__2; //Field offset: 0x28
		private Task <expansionsSettingsTask>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40
		private CharacterSelectionDataResponse <>7__wrap3; //Field offset: 0x48
		private SeasonalPerksData <>7__wrap4; //Field offset: 0x50
		private TaskAwaiter <>u__3; //Field offset: 0x58
		private TaskAwaiter <>u__4; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCharacterSelectionData>d__150 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCharacterSelectionExpansionsSettings>d__151 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadLocations>d__210 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private Token <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadLoginScenes>d__109 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private Token <>7__wrap1; //Field offset: 0x28
		private OperationAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMapAndData>d__236 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public bool isLocalGame; //Field offset: 0x28
		public ScenePresetLoadConfig scenePreset; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x40
		private <>c__DisplayClass236_0 <>8__1; //Field offset: 0x48
		public bool resetRaidPoolsBeforeInit; //Field offset: 0x50
		private <>c__DisplayClass236_1 <>8__2; //Field offset: 0x58
		public bool canEscape; //Field offset: 0x60
		private string <profileId>5__2; //Field offset: 0x68
		private ClientGameWorld <gameWorld>5__3; //Field offset: 0x70
		private int <timeSliceBefore>5__4; //Field offset: 0x78
		private int <bufferSizeBefore>5__5; //Field offset: 0x7C
		private Token <>7__wrap5; //Field offset: 0x80
		private TaskAwaiter <>u__1; //Field offset: 0x88
		private LoadScenesFromPresetOperation <loadSceneOperation>5__7; //Field offset: 0x90
		private OperationAwaiter <>u__2; //Field offset: 0x98
		private YieldAwaiter <>u__3; //Field offset: 0xA0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMenuSecondBatchColdAsync>d__206 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private ChatsDataLoader <chatsLoader>5__2; //Field offset: 0x28
		private IDisposable <>7__wrap2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMenuUISceneAsync>d__173 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private OperationAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LocalGameCreate>d__243 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public ClientMetricsEvents metricsEvents; //Field offset: 0x28
		private <>c__DisplayClass243_0 <>8__1; //Field offset: 0x30
		public GameWorld gameWorld; //Field offset: 0x38
		public TimeAndWeatherSettings timeAndWeather; //Field offset: 0x40
		public ClientMetricsConfig metricsConfig; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70
		private TaskAwaiter <>u__3; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LocalGameMatching>d__233 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public bool inTransition; //Field offset: 0x28
		private <>c__DisplayClass233_0 <>8__1; //Field offset: 0x30
		public TimeAndWeatherSettings timeAndWeather; //Field offset: 0x38
		private TimeHasComeScreenController <screenController>5__2; //Field offset: 0x58
		private GameWorld <gameWorld>5__3; //Field offset: 0x60
		private ClientMetricsEvents <metricsEvents>5__4; //Field offset: 0x68
		private Exception <exceptionToPropagate>5__5; //Field offset: 0x70
		private ClientMetricsConfig <metricsConfig>5__6; //Field offset: 0x78
		private TaskAwaiter <>u__1; //Field offset: 0x80
		private TaskAwaiter <>u__2; //Field offset: 0x88
		private TaskAwaiter <>u__3; //Field offset: 0x90
		private TaskAwaiter <>u__4; //Field offset: 0x98

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Logout>d__129 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private Task <unloadNarrate>5__2; //Field offset: 0x28
		private Task <unloadHideout>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MainMenu>d__222 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private CancellationToken <menuLoadCancellationToken>5__2; //Field offset: 0x28
		private IDisposable <>7__wrap2; //Field offset: 0x30
		private IDisposable <>7__wrap3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private Token <>7__wrap4; //Field offset: 0x50
		private TaskAwaiter <>u__3; //Field offset: 0x58
		private YieldAwaiter <>u__4; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MainMenuLoad>d__132 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private Task <result>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <NetworkGameCreate>d__238 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public string profileId; //Field offset: 0x28
		public Profile savageProfile; //Field offset: 0x30
		public Location location; //Field offset: 0x38
		public ClientMetricsEvents metricsEvents; //Field offset: 0x40
		public ClientGameWorld gameWorld; //Field offset: 0x48
		private <>c__DisplayClass238_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <NetworkGameCreateJob>d__239 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string profileId; //Field offset: 0x20
		public TarkovApplication <>4__this; //Field offset: 0x28
		public Profile savageProfile; //Field offset: 0x30
		public ClientGameWorld gameWorld; //Field offset: 0x38
		public ClientMetricsEvents metricsEvents; //Field offset: 0x40
		private ProfileStatus <profileStatus>5__2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <NetworkGameMatching>d__234 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public string groupId; //Field offset: 0x28
		private <>c__DisplayClass234_0 <>8__1; //Field offset: 0x30
		public EMatchingType type; //Field offset: 0x38
		private <>c__DisplayClass234_1 <>8__2; //Field offset: 0x40
		private ClientMetricsEvents <metricsEvents>5__2; //Field offset: 0x48
		private TimeHasComeScreenController <timeHasComeScreenController>5__3; //Field offset: 0x50
		private Task <matchingTask>5__4; //Field offset: 0x58
		private ClientGameWorld <gameWorld>5__5; //Field offset: 0x60
		private Exception <exceptionToPropagate>5__6; //Field offset: 0x68
		private bool <needLeaveCleanup>5__7; //Field offset: 0x70
		private Profile <savageProfile>5__8; //Field offset: 0x78
		private Location <location>5__9; //Field offset: 0x80
		private TaskAwaiter <>u__1; //Field offset: 0x88
		private TaskAwaiter <>u__2; //Field offset: 0x90
		private object <>7__wrap9; //Field offset: 0x98
		private int <>7__wrap10; //Field offset: 0xA0
		private TaskAwaiter <>u__3; //Field offset: 0xA8
		private TaskAwaiter <>u__4; //Field offset: 0xB0
		private TaskAwaiter <>u__5; //Field offset: 0xB8
		private Exception <e>5__12; //Field offset: 0xC0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnGameEnd>d__246 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x28
		public Result result; //Field offset: 0x30
		public string profileId; //Field offset: 0x50
		public Profile savageProfile; //Field offset: 0x58
		public Location location; //Field offset: 0x60
		private Token <>7__wrap1; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnLogoutDone>d__130 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public Task unloadNarrateTask; //Field offset: 0x28
		public Task unloadHideoutTask; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private OperationAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnReadyToStartMatchingAsync>d__226 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenCharacterSelectionFromMenu>d__143 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private ProfileLoadingScreenController <profileLoadingScreenController>5__2; //Field offset: 0x28
		private CharacterSelectionDataResponse <data>5__3; //Field offset: 0x30
		private CharacterSelectionResult <inRaidResult>5__4; //Field offset: 0x38
		private SeasonalPerksData <seasonalPerks>5__5; //Field offset: 0x50
		private ExtensionsSettings <expansionsSettings>5__6; //Field offset: 0x58
		private EGameMode <initialGameMode>5__7; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68
		private object <>7__wrap7; //Field offset: 0x70
		private int <>7__wrap8; //Field offset: 0x78
		private TaskAwaiter <>u__2; //Field offset: 0x80
		private TaskAwaiter <>u__3; //Field offset: 0x88
		private TaskAwaiter <>u__4; //Field offset: 0x90

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrefetchMenuDataPrepareOperation>d__193 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public CancellationToken cancellation; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareData>d__200 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private CancellationToken <menuLoadCancellationToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareDataJob>d__201 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public CancellationToken menuLoadCancellationToken; //Field offset: 0x28
		private Profile <profile>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareGame>d__165 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareGameJob>d__197 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private GlobalsDataLoader <globalsLoader>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private YieldAwaiter <>u__2; //Field offset: 0x38
		private TaskAwaiter <>u__3; //Field offset: 0x40
		private Token <>7__wrap2; //Field offset: 0x48
		private ProfileLoadingScreenController <controller>5__4; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RecoverTransitMatchingOrShowError>d__231 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public Exception e; //Field offset: 0x28
		public string matchingName; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RecreateBackend>d__117 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public EGameMode gameMode; //Field offset: 0x28
		public bool force; //Field offset: 0x2C
		public bool showLoadingScreen; //Field offset: 0x2D
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RecreateBackendWithResult>d__118 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public EGameMode gameMode; //Field offset: 0x28
		public bool force; //Field offset: 0x2C
		public bool showLoadingScreen; //Field offset: 0x2D
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RecreateCurrentBackend>d__119 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RecreateCurrentBackendWithResult>d__120 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private EGameMode <sessionModeToSet>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38
		private TaskAwaiter <>u__3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReloadCharacterSelection>d__141 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public bool fullReload; //Field offset: 0x28
		private CharacterSelectionScreenController <controller>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private CharacterSelectionScreenController <>7__wrap2; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReloadCharacterSelectionSession>d__142 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public CharacterSelectionScreenController controller; //Field offset: 0x28
		private EGameMode <gameMode>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestBuildList>d__209 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Run>d__215 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ProfileStatus profileStatus; //Field offset: 0x20
		public TarkovApplication <>4__this; //Field offset: 0x28
		public bool isPet; //Field offset: 0x30
		public Profile profile; //Field offset: 0x38
		private <>c__DisplayClass215_0 <>8__1; //Field offset: 0x40
		public Profile savageProfile; //Field offset: 0x48
		private IDisposable <>7__wrap1; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60
		private TaskAwaiter <>u__3; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunCharacterSelectionFlow>d__156 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool canGoBackToLanguage; //Field offset: 0x20
		public TarkovApplication <>4__this; //Field offset: 0x28
		public CharacterSelectionDataResponse data; //Field offset: 0x30
		public bool startupFlow; //Field offset: 0x38
		public SeasonalPerksData seasonalPerks; //Field offset: 0x40
		public ExtensionsSettings expansionsSettings; //Field offset: 0x48
		public Nullable returnGameMode; //Field offset: 0x50
		private CharacterSelectionResult <result>5__2; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x70
		private TaskAwaiter <>u__2; //Field offset: 0x78
		private TaskAwaiter <>u__3; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunDeferredRagfairWarmup>d__224 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunInitialLobbyFlow>d__146 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private CharacterSelectionBootstrapResult <bootstrap>5__2; //Field offset: 0x28
		private Nullable <overriddenGameMode>5__3; //Field offset: 0x40
		private CharacterSelectionResult <inRaidResult>5__4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private TaskAwaiter <>u__2; //Field offset: 0x68
		private TaskAwaiter <>u__3; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunPostRaidMenuWarmupAsync>d__184 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunPostRaidResourceCleanupAsync>d__185 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private IDisposable <>7__wrap1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunProfiledFirstBatchNetworkLoad>d__190 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunProfiledSecondBatchNetworkLoad>d__191 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunValidateAnticheat>d__223 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private IDisposable <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowCharacterSelectionScreen>d__155 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CharacterSelectionDataResponse data; //Field offset: 0x20
		public bool startupFlow; //Field offset: 0x28
		public string profileId; //Field offset: 0x30
		public Nullable currentGameMode; //Field offset: 0x38
		public SeasonalPerksData seasonalPerks; //Field offset: 0x40
		public ExtensionsSettings expansionsSettings; //Field offset: 0x48
		public bool canGoBack; //Field offset: 0x50
		public TarkovApplication <>4__this; //Field offset: 0x58
		private CharacterSelectionScreenController <screenController>5__2; //Field offset: 0x60
		private YieldAwaiter <>u__1; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70
		private SeasonsIntroScreenController <introController>5__3; //Field offset: 0x78
		private TaskAwaiter <>u__3; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowLanguageSelection>d__154 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private <>c__DisplayClass154_0 <>8__1; //Field offset: 0x28
		private EftWelcomeScreenController <screenController>5__2; //Field offset: 0x30
		private object <>7__wrap2; //Field offset: 0x38
		private int <>7__wrap3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowLanguageSelectionIfNeeded>d__153 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CharacterSelectionDataResponse profiles; //Field offset: 0x20
		public TarkovApplication <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowLegacyLoginDialog>d__126 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private Token <>7__wrap1; //Field offset: 0x28
		private Login <login>5__3; //Field offset: 0x30
		private EftLoginShowOperation <operation>5__4; //Field offset: 0x38
		private OperationAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowLegacyLoginScreen>d__131 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowProfileLoadingScreen>d__127 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowSessionResult>d__247 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public Profile savageProfile; //Field offset: 0x28
		public string profileId; //Field offset: 0x30
		public ClientMetrics clientMetrics; //Field offset: 0x38
		public Location location; //Field offset: 0x40
		public ExitStatus exitStatus; //Field offset: 0x48
		public TimeSpan exitTime; //Field offset: 0x50
		private <>c__DisplayClass247_0 <>8__1; //Field offset: 0x58
		private Profile <profileSavage>5__2; //Field offset: 0x60
		private Profile <targetProfile>5__3; //Field offset: 0x68
		private Token <>7__wrap3; //Field offset: 0x70
		private SessionResultShowOperation <resultOperation>5__5; //Field offset: 0x78
		private TaskAwaiter <>u__1; //Field offset: 0x80
		private OperationAwaiter <>u__2; //Field offset: 0x88

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowTransitSaveWaitScreen>d__256 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartOnlineTransitMatching>d__255 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartTask>d__104 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartTutorial>d__225 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public bool blockScreen; //Field offset: 0x28
		public bool tutorialProfile; //Field offset: 0x29
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryReconnectIfTransitDestStarted>d__254 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private bool <isPet>5__2; //Field offset: 0x28
		private int <i>5__3; //Field offset: 0x2C
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryRecoverAlreadyInMatching>d__230 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Exception exception; //Field offset: 0x20
		public TarkovApplication <>4__this; //Field offset: 0x28
		private bool <recovered>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnloadPostRaidScenesAsync>d__176 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private Enumerator <>7__wrap1; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateAnticheat>d__112 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private AnticheatValidationOperation <anticheatValidationOperation>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateEnvironmentUI>d__199 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		private SettingsWithController <gameSettings>5__2; //Field offset: 0x28
		private EEnvironmentUIType <currentEnvironmentUiType>5__3; //Field offset: 0x30
		private Task <setEnvironmentTask>5__4; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForProfileStatus>d__213 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public EProfileStatus status; //Field offset: 0x28
		public bool isPet; //Field offset: 0x2C
		public int interval; //Field offset: 0x30
		public int maxAttempts; //Field offset: 0x34
		private int <attempts>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitLeaving>d__212 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TarkovApplication <>4__this; //Field offset: 0x20
		public bool isMatching; //Field offset: 0x28
		private <>c__DisplayClass212_0 <>8__1; //Field offset: 0x30
		private <>c__DisplayClass212_1 <>8__2; //Field offset: 0x38
		private int <timeout>5__2; //Field offset: 0x40
		private float <time>5__3; //Field offset: 0x44
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class AchievementDataLoader
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			private struct <<Load>g__LoadGlobalProgress|0>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass0_0 <>4__this; //Field offset: 0x20
				private AchievementsGlobalProgressStorage <>7__wrap1; //Field offset: 0x28
				private TaskAwaiter <>u__1; //Field offset: 0x30

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadTemplates|1>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass0_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			public IEftSession session; //Field offset: 0x10

			public <>c__DisplayClass0_0() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadGlobalProgress|0>d))]
			internal Task <Load>g__LoadGlobalProgress|0() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadTemplates|1>d))]
			internal Task <Load>g__LoadTemplates|1() { }

		}

		[CompilerGenerated]
		private struct <Load>d__0 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IEftSession session; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		public AchievementDataLoader() { }

		[AsyncStateMachine(typeof(<Load>d__0))]
		public Task Load(IEftSession session) { }

	}

	[IsReadOnly]
	private struct CharacterSelectionBootstrapResult
	{
		[CompilerGenerated]
		private readonly CharacterSelectionDataResponse <Profiles>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly SeasonalPerksData <SeasonalPerks>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private readonly ExtensionsSettings <ExpansionsSettings>k__BackingField; //Field offset: 0x10

		public ExtensionsSettings ExpansionsSettings
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public CharacterSelectionDataResponse Profiles
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public SeasonalPerksData SeasonalPerks
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public CharacterSelectionBootstrapResult(CharacterSelectionDataResponse profiles, SeasonalPerksData seasonalPerks, ExtensionsSettings expansionsSettings) { }

		[CompilerGenerated]
		public ExtensionsSettings get_ExpansionsSettings() { }

		[CompilerGenerated]
		public CharacterSelectionDataResponse get_Profiles() { }

		[CompilerGenerated]
		public SeasonalPerksData get_SeasonalPerks() { }

	}

	internal class ChatsDataLoader
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			private struct <<Load>g__LoadDialogList|1>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass8_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadFriendList|0>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass8_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			public IEftSession session; //Field offset: 0x10
			public ChatsDataLoader <>4__this; //Field offset: 0x18

			public <>c__DisplayClass8_0() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadDialogList|1>d))]
			internal Task <Load>g__LoadDialogList|1() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadFriendList|0>d))]
			internal Task <Load>g__LoadFriendList|0() { }

		}

		[CompilerGenerated]
		private struct <Load>d__8 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IEftSession session; //Field offset: 0x20
			public ChatsDataLoader <>4__this; //Field offset: 0x28
			private <>c__DisplayClass8_0 <>8__1; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private Result <ChatContacts>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Result <DialogList>k__BackingField; //Field offset: 0x28

		public private Result ChatContacts
		{
			[CompilerGenerated]
			 get { } //Length: 21
			[CompilerGenerated]
			private set { } //Length: 98
		}

		public private Result DialogList
		{
			[CompilerGenerated]
			 get { } //Length: 21
			[CompilerGenerated]
			private set { } //Length: 98
		}

		public ChatsDataLoader() { }

		[CompilerGenerated]
		public Result get_ChatContacts() { }

		[CompilerGenerated]
		public Result get_DialogList() { }

		[AsyncStateMachine(typeof(<Load>d__8))]
		public Task Load(IEftSession session) { }

		[CompilerGenerated]
		private void set_ChatContacts(Result value) { }

		[CompilerGenerated]
		private void set_DialogList(Result value) { }

	}

	private sealed class CustomizationDataLoader
	{
		[CompilerGenerated]
		private struct <Load>d__2 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IClientSession session; //Field offset: 0x20
			public CustomizationDataLoader <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30
			private TaskAwaiter <>u__2; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <LoadTemplates>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IClientSession session; //Field offset: 0x20
			public CustomizationDataLoader <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private Dictionary _cachedCustomizations; //Field offset: 0x10

		public CustomizationDataLoader() { }

		[AsyncStateMachine(typeof(<Load>d__2))]
		public Task Load(IClientSession session) { }

		[AsyncStateMachine(typeof(<LoadTemplates>d__1))]
		public Task LoadTemplates(IClientSession session) { }

	}

	private enum EPrepareGameResult
	{
		Success = 0,
		ProfileCreationCancelled = 1,
		Failed = 2,
	}

	private sealed class GlobalsDataLoader
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			private struct <<Load>g__LoadBattlePasses|9>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadClientSettings|1>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadCutscenesSubtitles|12>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadGlobalsConfig|0>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadGroupProfileVariable|6>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadMainQuestSettings|4>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadPrestigeSettings|3>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadQuestNoteTemplate|5>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadSeasonalPerks|7>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadSeasonalRewards|8>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadTapesSubtitles|11>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadTraderDialogs|10>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private struct <<Load>g__LoadTraderSettings|2>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass13_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			public IEftSession session; //Field offset: 0x10
			public GlobalsDataLoader <>4__this; //Field offset: 0x18

			public <>c__DisplayClass13_0() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadBattlePasses|9>d))]
			internal Task <Load>g__LoadBattlePasses|9() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadClientSettings|1>d))]
			internal Task <Load>g__LoadClientSettings|1() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadCutscenesSubtitles|12>d))]
			internal Task <Load>g__LoadCutscenesSubtitles|12() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadGlobalsConfig|0>d))]
			internal Task <Load>g__LoadGlobalsConfig|0() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadGroupProfileVariable|6>d))]
			internal Task <Load>g__LoadGroupProfileVariable|6() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadMainQuestSettings|4>d))]
			internal Task <Load>g__LoadMainQuestSettings|4() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadPrestigeSettings|3>d))]
			internal Task <Load>g__LoadPrestigeSettings|3() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadQuestNoteTemplate|5>d))]
			internal Task <Load>g__LoadQuestNoteTemplate|5() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadSeasonalPerks|7>d))]
			internal Task <Load>g__LoadSeasonalPerks|7() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadSeasonalRewards|8>d))]
			internal Task <Load>g__LoadSeasonalRewards|8() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadTapesSubtitles|11>d))]
			internal Task <Load>g__LoadTapesSubtitles|11() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadTraderDialogs|10>d))]
			internal Task <Load>g__LoadTraderDialogs|10() { }

			[AsyncStateMachine(typeof(<<Load>g__LoadTraderSettings|2>d))]
			internal Task <Load>g__LoadTraderSettings|2() { }

		}

		[CompilerGenerated]
		private struct <Apply>d__14 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public GlobalsDataLoader <>4__this; //Field offset: 0x20
			public IEftSession session; //Field offset: 0x28
			public IClientBackEnd clientBackEnd; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <Load>d__13 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IEftSession session; //Field offset: 0x20
			public GlobalsDataLoader <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private UnparsedData _globalsData; //Field offset: 0x10
		private ClientSettingsResponse _clientSettingsResponse; //Field offset: 0x18
		private TraderSettings[] _traderSettings; //Field offset: 0x20
		private PrestigeSettings _prestigeSettings; //Field offset: 0x28
		private MainQuestSettings _mainQuestSettings; //Field offset: 0x30
		private QuestNoteTemplate[] _questNoteTemplate; //Field offset: 0x38
		private GroupProfileVariable[] _profileVariables; //Field offset: 0x40
		private Result _traderDialogs; //Field offset: 0x48
		private Result _tapesSubtitlesData; //Field offset: 0x60
		private Result _cutscenesSubtitlesData; //Field offset: 0x78
		private SeasonalPerksData _seasonalPerks; //Field offset: 0x90
		private ActiveSeasonResponse _seasonalRewards; //Field offset: 0x98
		private BattlePassConfig _battlePassData; //Field offset: 0xA0

		public GlobalsDataLoader() { }

		[CompilerGenerated]
		private GlobalConfigurationResponse <Apply>b__14_0() { }

		[AsyncStateMachine(typeof(<Apply>d__14))]
		public Task Apply(IEftSession session, IClientBackEnd clientBackEnd) { }

		private void ApplyCutsceneSubtitles() { }

		private void ApplyPrestigeIcons(IEftSession session) { }

		public void ApplyTapeSubtitles() { }

		private void ApplyTraderDialogs() { }

		private void ConfigureSendRequest() { }

		[AsyncStateMachine(typeof(<Load>d__13))]
		public Task Load(IEftSession session) { }

		private void MarkNotImportantErrors() { }

	}

	private sealed class HandbookDataLoader
	{
		[CompilerGenerated]
		private struct <Load>d__3 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IEftSession session; //Field offset: 0x20
			public HandbookDataLoader <>4__this; //Field offset: 0x28
			private HandbookInfo <sentForCache>5__2; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private static HandbookInfo _lastAppliedInfo; //Field offset: 0x0
		private HandbookInfo _handbookInfo; //Field offset: 0x10
		private bool _serverReturnedCache; //Field offset: 0x18

		public HandbookDataLoader() { }

		public void Apply(IEftSession session, Profile profile) { }

		[AsyncStateMachine(typeof(<Load>d__3))]
		public Task Load(IEftSession session) { }

	}

	internal sealed class HideoutController
	{
		[CompilerGenerated]
		private struct <HideoutSelectedHandler>d__4 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public HideoutController <>4__this; //Field offset: 0x20
			public HideoutEntryPoint entryPoint; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30
			private TaskAwaiter <>u__2; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <TryLoadHideout>d__5 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public HideoutController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <UnloadHideout>d__8 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public HideoutController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		internal sealed class HideoutEntrance
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x0
				public static Func <>9__9_0; //Field offset: 0x8

				private static <>c() { }

				public <>c() { }

				internal bool <ShowHideoutScreen>b__9_0(AreaData x) { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass6_0
			{
				public HideoutDialogEntryPoint dialogEntryPoint; //Field offset: 0x10

				public <>c__DisplayClass6_0() { }

				internal bool <HideoutSelectedHandler>b__0(HideoutDialogEntryPoint dialogueInitiator) { }

			}

			[CompilerGenerated]
			private struct <Enter>d__5 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutEntrance <>4__this; //Field offset: 0x20
				public Action entranceFinishedCallback; //Field offset: 0x28
				public IEftSession session; //Field offset: 0x30
				public HideoutPlayerOwner playerOwner; //Field offset: 0x38
				public HideoutEntryPoint entryPoint; //Field offset: 0x40
				private TaskAwaiter <>u__1; //Field offset: 0x48

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <HideoutSelectedHandler>d__6 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutDialogEntryPoint dialogEntryPoint; //Field offset: 0x20
				public HideoutEntrance <>4__this; //Field offset: 0x28
				private <>c__DisplayClass6_0 <>8__1; //Field offset: 0x30
				private HideoutDialogEntryPoint <entryPoint>5__2; //Field offset: 0x38
				private TaskAwaiter <>u__1; //Field offset: 0x40

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <HideoutSelectedHandler>d__7 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutEntrance <>4__this; //Field offset: 0x20
				public HideoutAreaEntryPoint areaEntryPoint; //Field offset: 0x28
				private TaskAwaiter <>u__1; //Field offset: 0x30

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <HideoutSelectedHandler>d__8 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutData hideoutData; //Field offset: 0x20
				public HideoutEntrance <>4__this; //Field offset: 0x28
				private bool <resetCameraPosition>5__2; //Field offset: 0x30
				private TaskAwaiter <>u__1; //Field offset: 0x38

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private const int DIALOGUE_START_DELAY = 500; //Field offset: 0x0
			private HideoutPlayerOwner _playerOwner; //Field offset: 0x10
			private HideoutScreenController _hideoutScreenController; //Field offset: 0x18
			private IEftSession _session; //Field offset: 0x20
			private Action _entranceFinishedCallback; //Field offset: 0x28

			public HideoutEntrance() { }

			[AsyncStateMachine(typeof(<Enter>d__5))]
			public Task Enter(HideoutEntryPoint entryPoint, HideoutPlayerOwner playerOwner, IEftSession session, Action entranceFinishedCallback) { }

			[AsyncStateMachine(typeof(<HideoutSelectedHandler>d__6))]
			private Task HideoutSelectedHandler(HideoutDialogEntryPoint dialogEntryPoint) { }

			[AsyncStateMachine(typeof(<HideoutSelectedHandler>d__7))]
			private Task HideoutSelectedHandler(HideoutAreaEntryPoint areaEntryPoint) { }

			[AsyncStateMachine(typeof(<HideoutSelectedHandler>d__8))]
			private Task HideoutSelectedHandler(HideoutData hideoutData) { }

			private void ShowHideoutScreen(HideoutPlayerOwner playerOwner, bool resetCameraPosition, string ownerName = "") { }

		}

		public sealed class HideoutGameLoader
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x0
				public static Func <>9__14_0; //Field offset: 0x8
				public static Func <>9__17_0; //Field offset: 0x10
				public static Func <>9__17_1; //Field offset: 0x18
				public static Func <>9__23_0; //Field offset: 0x20

				private static <>c() { }

				public <>c() { }

				internal bool <LoadHideout>b__14_0(KeyValuePair x) { }

				internal ResourceKey <LoadHideoutBundles>b__23_0(string x) { }

				internal MongoID <PrepareProductionSchemesBundles>b__17_0(ProductionScheme scheme) { }

				internal bool <PrepareProductionSchemesBundles>b__17_1(MongoID id) { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass15_0
			{
				public GameWorld gameWorldCache; //Field offset: 0x10

				public <>c__DisplayClass15_0() { }

				internal void <LoadMapAndDataForHideout>b__0() { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass17_0
			{
				public ItemFactory itemFactory; //Field offset: 0x10
				public TaskCompletionSource source; //Field offset: 0x18

				public <>c__DisplayClass17_0() { }

				internal string <PrepareProductionSchemesBundles>b__2(MongoID id) { }

				internal void <PrepareProductionSchemesBundles>b__3() { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass18_0
			{
				public HideoutGameLoader <>4__this; //Field offset: 0x10
				public Location location; //Field offset: 0x18
				public HideoutGame localGame; //Field offset: 0x20

				public <>c__DisplayClass18_0() { }

				internal void <LocalGameCreateForHideout>b__1() { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass18_1
			{
				public Profile originalProfile; //Field offset: 0x10
				public Profile savageProfile; //Field offset: 0x18
				public <>c__DisplayClass18_0 CS$<>8__locals1; //Field offset: 0x20

				public <>c__DisplayClass18_1() { }

				internal void <LocalGameCreateForHideout>b__0(Result result) { }

			}

			[CompilerGenerated]
			private struct <Load>d__13 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutGameLoader <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <LoadHideout>d__14 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutGameLoader <>4__this; //Field offset: 0x20
				private Location <hideoutLocation>5__2; //Field offset: 0x28
				private Token <>7__wrap2; //Field offset: 0x30
				private TaskAwaiter <>u__1; //Field offset: 0x38
				private TaskAwaiter <>u__2; //Field offset: 0x40
				private TaskAwaiter <>u__3; //Field offset: 0x48

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <LoadHideoutBundles>d__23 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutGameLoader <>4__this; //Field offset: 0x20
				public YieldDelegate yield; //Field offset: 0x28
				private Token <>7__wrap1; //Field offset: 0x30
				private TaskAwaiter <>u__1; //Field offset: 0x38

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <LoadHideoutMap>d__20 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutGameLoader <>4__this; //Field offset: 0x20
				private int <timeSliceBefore>5__2; //Field offset: 0x28
				private int <bufferSizeBefore>5__3; //Field offset: 0x2C
				private TaskAwaiter <>u__1; //Field offset: 0x30

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <LoadHideoutResources>d__16 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutGameLoader <>4__this; //Field offset: 0x20
				private Token <>7__wrap1; //Field offset: 0x28
				private TaskAwaiter <>u__1; //Field offset: 0x30

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <LoadMapAndDataForHideout>d__15 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutGameLoader <>4__this; //Field offset: 0x20
				private <>c__DisplayClass15_0 <>8__1; //Field offset: 0x28
				private string <profileId>5__2; //Field offset: 0x30
				private GameWorld <gameWorld>5__3; //Field offset: 0x38
				private Token <>7__wrap3; //Field offset: 0x40
				private TaskAwaiter <>u__1; //Field offset: 0x48
				private YieldAwaiter <>u__2; //Field offset: 0x50

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <LocalGameCreateForHideout>d__18 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutGameLoader <>4__this; //Field offset: 0x20
				public Location location; //Field offset: 0x28
				public GameWorld gameWorld; //Field offset: 0x30
				public TimeAndWeatherSettings timeAndWeather; //Field offset: 0x38
				private <>c__DisplayClass18_0 <>8__1; //Field offset: 0x58
				private TaskAwaiter <>u__1; //Field offset: 0x60

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <UnloadHideout>d__27 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public HideoutGameLoader <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28
				private TaskAwaiter <>u__2; //Field offset: 0x30

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private TarkovApplication _application; //Field offset: 0x10
			private Task _loadHideoutTask; //Field offset: 0x18
			private Task _loadHideoutMapTask; //Field offset: 0x20
			private Task _loadHideoutBundlesTask; //Field offset: 0x28
			private GameWorld _hideoutGameWorld; //Field offset: 0x30
			private LevelSettings _hideoutLevelSettings; //Field offset: 0x38
			private SceneToken _hideoutSceneToken; //Field offset: 0x40
			private Token _productionSchemesBundles; //Field offset: 0x48
			public HideoutPlayerOwner _playerOwner; //Field offset: 0x50
			private readonly CompositeDisposable _unsubscriber; //Field offset: 0x58

			public bool IsLoaded
			{
				 get { } //Length: 203
			}

			public HideoutGameLoader(TarkovApplication application) { }

			private void DeInit() { }

			public bool get_IsLoaded() { }

			public void HideHideout() { }

			[AsyncStateMachine(typeof(<Load>d__13))]
			public Task Load() { }

			public void LoadBundles() { }

			[AsyncStateMachine(typeof(<LoadHideout>d__14))]
			private Task LoadHideout() { }

			[AsyncStateMachine(typeof(<LoadHideoutBundles>d__23))]
			private Task LoadHideoutBundles(YieldDelegate yield) { }

			[AsyncStateMachine(typeof(<LoadHideoutMap>d__20))]
			private Task LoadHideoutMap() { }

			[AsyncStateMachine(typeof(<LoadHideoutResources>d__16))]
			private Task LoadHideoutResources() { }

			public void LoadMap() { }

			[AsyncStateMachine(typeof(<LoadMapAndDataForHideout>d__15))]
			private Task LoadMapAndDataForHideout() { }

			[AsyncStateMachine(typeof(<LocalGameCreateForHideout>d__18))]
			private Task LocalGameCreateForHideout(GameWorld gameWorld, Location location, TimeAndWeatherSettings timeAndWeather) { }

			private void OnHideoutStart() { }

			private Task PrepareProductionSchemesBundles() { }

			public void ReInit() { }

			[AsyncStateMachine(typeof(<UnloadHideout>d__27))]
			public Task UnloadHideout() { }

		}

		private readonly TarkovApplication _application; //Field offset: 0x10
		private readonly HideoutEntrance _hideoutEntrance; //Field offset: 0x18
		private readonly HideoutGameLoader _hideoutGameLoader; //Field offset: 0x20

		public HideoutController(TarkovApplication application) { }

		public void HideHideout() { }

		[AsyncStateMachine(typeof(<HideoutSelectedHandler>d__4))]
		public Task HideoutSelectedHandler(HideoutEntryPoint entryPoint) { }

		public void StartLoadHideoutBundles() { }

		public void StartLoadHideoutMap() { }

		[AsyncStateMachine(typeof(<TryLoadHideout>d__5))]
		private Task TryLoadHideout() { }

		[AsyncStateMachine(typeof(<UnloadHideout>d__8))]
		public Task UnloadHideout() { }

	}

	private sealed class ItemTemplatesDataLoader
	{
		[CompilerGenerated]
		private struct <Load>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IEftSession session; //Field offset: 0x20
			public ItemTemplatesDataLoader <>4__this; //Field offset: 0x28
			public IClientBackEnd clientBackEnd; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38
			private TaskAwaiter <>u__2; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private ItemTemplates _cachedItemTemplates; //Field offset: 0x10

		public ItemTemplatesDataLoader() { }

		[AsyncStateMachine(typeof(<Load>d__1))]
		public Task Load(IEftSession session, IClientBackEnd clientBackEnd) { }

	}

	internal sealed class NarrateController
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__11_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal ResourceKey <LoadBundles>b__11_0(string x) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			public MongoID traderId; //Field offset: 0x10
			public NarrateController <>4__this; //Field offset: 0x28
			public TaskCompletionSource finishTask; //Field offset: 0x30

			public <>c__DisplayClass10_0() { }

			internal bool <Show>b__0(Trader trader) { }

			internal void <Show>b__2() { }

			internal void <Show>g__FinishShow|1() { }

		}

		[CompilerGenerated]
		private struct <Hide>d__14 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public NarrateController <>4__this; //Field offset: 0x20
			public bool withError; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <LoadBundles>d__11 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public NarrateController <>4__this; //Field offset: 0x20
			private Token <>7__wrap1; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <Show>d__10 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public NarrateController <>4__this; //Field offset: 0x20
			public ETraderType vendor; //Field offset: 0x28
			private <>c__DisplayClass10_0 <>8__1; //Field offset: 0x30
			public Nullable dialogId; //Field offset: 0x38
			private ClientBackendDialogController <dialogController>5__2; //Field offset: 0x58
			private TaskAwaiter <>u__1; //Field offset: 0x60
			private TaskAwaiter <>u__2; //Field offset: 0x68
			private YieldAwaiter <>u__3; //Field offset: 0x70

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <ShowDialog>d__12 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public NarrateController <>4__this; //Field offset: 0x20
			public ETraderType source; //Field offset: 0x28
			public Nullable dialogId; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x50

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <ShowDialogScreen>d__16 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public ETraderType source; //Field offset: 0x20
			public NarrateController <>4__this; //Field offset: 0x28
			public NPCObject npc; //Field offset: 0x30
			public Nullable dialogId; //Field offset: 0x38
			private MongoID <traderId>5__2; //Field offset: 0x58
			private MainMenuShowOperation <mainMenuOperation>5__3; //Field offset: 0x70
			private ITraderAnimationController <animationController>5__4; //Field offset: 0x78
			private TaskAwaiter <>u__1; //Field offset: 0x80

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <Unload>d__15 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public NarrateController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public static VendorScenePresets Scenes; //Field offset: 0x0
		private readonly TarkovApplication _application; //Field offset: 0x10
		private readonly CompositeDisposable _unsubscriber; //Field offset: 0x18
		private NarrateGame _game; //Field offset: 0x20
		private NarrateGameWorld _gameWorld; //Field offset: 0x28
		private LevelSettings _levelSettings; //Field offset: 0x30
		private NPCObject _npcObject; //Field offset: 0x38
		private Task _loadBundlesTask; //Field offset: 0x40
		private ClientBackendDialogController _dialogController; //Field offset: 0x48

		private static NarrateController() { }

		public NarrateController(TarkovApplication application) { }

		[CompilerGenerated]
		private void <ShowDialogScreen>b__16_0() { }

		private void End() { }

		private void HandleActionFinished(DialogAction dialogAction) { }

		[AsyncStateMachine(typeof(<Hide>d__14))]
		public Task Hide(bool withError = false) { }

		[AsyncStateMachine(typeof(<LoadBundles>d__11))]
		private Task LoadBundles() { }

		[AsyncStateMachine(typeof(<Show>d__10))]
		public Task Show(ETraderType vendor, Nullable dialogId) { }

		[AsyncStateMachine(typeof(<ShowDialog>d__12))]
		private Task ShowDialog(ETraderType source, Nullable dialogId) { }

		[AsyncStateMachine(typeof(<ShowDialogScreen>d__16))]
		private Task ShowDialogScreen(ETraderType source, NPCObject npc, Nullable dialogId) { }

		[AsyncStateMachine(typeof(<Unload>d__15))]
		public Task Unload() { }

	}

	private sealed class PendingCharacterSelection
	{
		public string ProfileId; //Field offset: 0x10

		public PendingCharacterSelection() { }

	}

	private sealed class ProfileDataLoader
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public ProfileDataLoader <>4__this; //Field offset: 0x10
			public string pendingProfileId; //Field offset: 0x18

			public <>c__DisplayClass2_0() { }

			internal ProfileDescriptor[] <Apply>b__0() { }

			internal bool <Apply>b__1(Profile profile) { }

		}

		[CompilerGenerated]
		private static class <>O
		{
			public static Action <0>__Quit; //Field offset: 0x0

		}

		[CompilerGenerated]
		private struct <Apply>d__2 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public ProfileDataLoader <>4__this; //Field offset: 0x20
			public string pendingProfileId; //Field offset: 0x28
			public IEftSession session; //Field offset: 0x30
			public string buildVersion; //Field offset: 0x38
			public bool allowCreateProfileCancellation; //Field offset: 0x40
			private <>c__DisplayClass2_0 <>8__1; //Field offset: 0x48
			private TaskAwaiter <>u__1; //Field offset: 0x50
			private TaskAwaiter <>u__2; //Field offset: 0x58
			private TaskAwaiter <>u__3; //Field offset: 0x60
			private TaskAwaiter <>u__4; //Field offset: 0x68

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <CreateProfile>d__3 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IEftSession session; //Field offset: 0x20
			public bool allowCancellation; //Field offset: 0x28
			public string buildVersion; //Field offset: 0x30
			private EftCreateProfileOperation <createProfileOperation>5__2; //Field offset: 0x38
			private TaskAwaiter <>u__1; //Field offset: 0x40
			private OperationAwaiter <>u__2; //Field offset: 0x48
			private TaskAwaiter <>u__3; //Field offset: 0x50

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <Load>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IEftSession session; //Field offset: 0x20
			public ProfileDataLoader <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private UnparsedData _profilesRaw; //Field offset: 0x10

		public ProfileDataLoader() { }

		[AsyncStateMachine(typeof(<Apply>d__2))]
		public Task Apply(IEftSession session, string buildVersion, string pendingProfileId = null, bool allowCreateProfileCancellation = false) { }

		[AsyncStateMachine(typeof(<CreateProfile>d__3))]
		private Task CreateProfile(IEftSession session, string buildVersion, bool allowCancellation) { }

		[AsyncStateMachine(typeof(<Load>d__1))]
		public Task Load(IEftSession session) { }

	}

	internal class QuestsDataLoader
	{
		[CompilerGenerated]
		private struct <Load>d__0 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public IEftSession session; //Field offset: 0x20
			private Task <questsTemplatesTask>5__2; //Field offset: 0x28
			private Task <questChainsTask>5__3; //Field offset: 0x30
			private List <questsTemplates>5__4; //Field offset: 0x38
			private TaskAwaiter <>u__1; //Field offset: 0x40
			private TaskAwaiter <>u__2; //Field offset: 0x48
			private TaskAwaiter <>u__3; //Field offset: 0x50

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		public QuestsDataLoader() { }

		[AsyncStateMachine(typeof(<Load>d__0))]
		public Task Load(IEftSession session) { }

	}

	private static readonly WaitForSeconds _waitFor1Second; //Field offset: 0x0
	[SerializeField]
	private SplashScreenPanel _splashScreenPanel; //Field offset: 0xB8
	[SerializeField]
	private Camera _temporaryCamera; //Field offset: 0xC0
	[HideInInspector]
	[SerializeField]
	private GameDateTime _localGameDateTime; //Field offset: 0xC8
	[Header("Locations debug settings")]
	public bool UnlockAndShowAllLocations; //Field offset: 0xD0
	[SerializeField]
	private bool _customRaidSettings; //Field offset: 0xD1
	[SerializeField]
	private RaidSettings _raidSettings; //Field offset: 0xD8
	public FastGameInfo FastGameInfo_EXPERIMENTAL; //Field offset: 0xE0
	private Coroutine _afkTimeoutCoroutine; //Field offset: 0xE8
	private string _cachedPhpSessionId; //Field offset: 0xF0
	private bool _startTutorial; //Field offset: 0xF8
	private MatchmakerOperation _localMatchmakerOperation; //Field offset: 0x100
	private TransitTimeHasComeScreenController _transitTimeHasComeScreenController; //Field offset: 0x108
	private bool _transitMatchingInFlight; //Field offset: 0x110
	private bool _transitMatchingRecoveryInProgress; //Field offset: 0x111
	private LocalRaidSettings _localRaidSettings; //Field offset: 0x118
	private HideoutRepresentation _hideout; //Field offset: 0x120
	private UIInputRoot _uiInputRoot; //Field offset: 0x128
	private EmptyInputNode _screensNode; //Field offset: 0x130
	private MainMenuShowOperation _menuOperation; //Field offset: 0x138
	private SettingsScreenResolver _settingsScreenResolver; //Field offset: 0x140
	private string _messageOnLoadMenu; //Field offset: 0x148
	private bool _isFirstTimeApplicationLoad; //Field offset: 0x150
	private bool _suppressNextPrepareDataForcedGc; //Field offset: 0x151
	private Task _menuFirstBatchPrefetchTask; //Field offset: 0x158
	private ItemTemplatesDataLoader _prefetchedItemsLoader; //Field offset: 0x160
	private CustomizationDataLoader _prefetchedCustomizationLoader; //Field offset: 0x168
	private GlobalsDataLoader _prefetchedGlobalsLoader; //Field offset: 0x170
	private Task _menuSecondBatchPrefetchTask; //Field offset: 0x178
	private QuestsDataLoader _prefetchedQuestsLoader; //Field offset: 0x180
	private AchievementDataLoader _prefetchedAchievementsLoader; //Field offset: 0x188
	private ChatsDataLoader _prefetchedChatsLoader; //Field offset: 0x190
	private GameDateTime _prefetchedGameDateTime; //Field offset: 0x198
	private CancellationTokenSource _menuSecondBatchCancellation; //Field offset: 0x1A0
	private Task _postRaidMenuWarmupTask; //Field offset: 0x1A8
	private Task _postRaidResourceCleanupTask; //Field offset: 0x1B0
	private Task _prefetchedTutorialInfoTask; //Field offset: 0x1B8
	private Task _prefetchedDailyQuestsTask; //Field offset: 0x1C0
	private bool _postRaidUnloadGameCompleted; //Field offset: 0x1C8
	private bool _postRaidMemoryCleanupCompleted; //Field offset: 0x1C9
	private bool _deferredRagfairSetupPending; //Field offset: 0x1CA
	private PendingCharacterSelection _pendingCharacterSelection; //Field offset: 0x1D0
	private bool _characterSelectionFromMenuBusy; //Field offset: 0x1D8
	private bool _characterSelectionReloadPending; //Field offset: 0x1D9
	private CharacterSelectionScreenController _characterSelectionController; //Field offset: 0x1E0
	private CancellationTokenSource _menuLoadCts; //Field offset: 0x1E8
	private Task _menuUiLoadTask; //Field offset: 0x1F0
	[CompilerGenerated]
	private int <CurrentRaidNum>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	private int <CurrentTotalRaidNum>k__BackingField; //Field offset: 0x1FC
	[CompilerGenerated]
	private HideoutController <HideoutControllerAccess>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	private NarrateController <NarrateControllerAccess>k__BackingField; //Field offset: 0x208
	private TransitionStatus _transitionStatus; //Field offset: 0x210
	[CompilerGenerated]
	private int <TransitHopPlayersCount>k__BackingField; //Field offset: 0x230
	[CompilerGenerated]
	private Action AfterApplicationLoaded; //Field offset: 0x238
	private readonly CompositeDisposable _unsubscriber; //Field offset: 0x240
	[CompilerGenerated]
	private bool <GameOverSaveStatusReceived>k__BackingField; //Field offset: 0x248
	[CompilerGenerated]
	private RpcGameOverSaveStatusMessage <GameOverSaveStatusMessage>k__BackingField; //Field offset: 0x250
	[CompilerGenerated]
	private bool <GameOverSaveStatusFailed>k__BackingField; //Field offset: 0x258
	[CompilerGenerated]
	private Action GameOverSaveStatusApplied; //Field offset: 0x260
	private HandbookDataLoader _handbookLoader; //Field offset: 0x268
	private HideoutDataLoader _hideoutLoader; //Field offset: 0x270
	private ProfileDataLoader _profileLoader; //Field offset: 0x278

	public event Action AfterApplicationLoaded
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action GameOverSaveStatusApplied
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private override int CurrentRaidNum
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public RaidSettings CurrentRaidSettings
	{
		 get { } //Length: 8
	}

	public private override int CurrentTotalRaidNum
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool GameOverSaveStatusFailed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public RpcGameOverSaveStatusMessage GameOverSaveStatusMessage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool GameOverSaveStatusReceived
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private HideoutController HideoutControllerAccess
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool IsInMatchmakerGroup
	{
		 get { } //Length: 127
	}

	private MatchmakerPlayersController Matchmaker
	{
		private get { } //Length: 33
	}

	private MatchmakerOperation MatchmakerOperation
	{
		private get { } //Length: 783
	}

	public private NarrateController NarrateControllerAccess
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private bool ShouldReloadCharacterSelection
	{
		private get { } //Length: 32
	}

	public int TransitHopPlayersCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public TransitionStatus TransitionStatus
	{
		 get { } //Length: 25
		 set { } //Length: 115
	}

	private static TarkovApplication() { }

	public TarkovApplication() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[CompilerGenerated]
	private void <ComebackToMainMenu>b__250_1() { }

	[CompilerGenerated]
	internal static void <ComebackToMainMenu>g__MenuSceneLoaded|250_0(Scene scene, LoadSceneMode mode) { }

	[AsyncStateMachine(typeof(<<ExitApplication>g__ForceShutdown|218_0>d))]
	[CompilerGenerated]
	internal static Task <ExitApplication>g__ForceShutdown|218_0() { }

	[AsyncStateMachine(typeof(<<ExitApplication>g__LogOut|218_1>d))]
	[CompilerGenerated]
	private Task <ExitApplication>g__LogOut|218_1() { }

	[CompilerGenerated]
	private void <ExitApplicationWithConfirm>b__217_0() { }

	[CompilerGenerated]
	private void <GamePrepare>b__237_0() { }

	[AsyncStateMachine(typeof(<<InitIconCreators>g__CreateIconCreator|198_3>d`3))]
	[CompilerGenerated]
	internal static Task <InitIconCreators>g__CreateIconCreator|198_3(Func constructor) { }

	[CompilerGenerated]
	private void <InitPreloaderUI>b__133_0(EMenuType menuType, bool isOn) { }

	[CompilerGenerated]
	private void <InitPreloaderUI>b__133_2() { }

	[CompilerGenerated]
	private void <InitPreloaderUI>g__Failed|133_1(string operationName, string error) { }

	[CompilerGenerated]
	private void <MainMenu>b__222_3() { }

	[CompilerGenerated]
	private void <MainMenu>g__OnGameModeToggle|222_0(EGameMode gameMode) { }

	[CompilerGenerated]
	private void <MainMenu>g__OnProfileReloadEnd|222_2() { }

	[CompilerGenerated]
	private void <MainMenu>g__OnReadyToStartMatching|222_1() { }

	[CompilerGenerated]
	private void <OnGameEnd>b__246_0() { }

	[CompilerGenerated]
	private void <OnReadyToStartMatchingAsync>b__226_0() { }

	[CompilerGenerated]
	private void <PrepareData>b__200_0() { }

	[CompilerGenerated]
	private void <RecoverTransitMatchingOrShowError>b__231_0() { }

	[CompilerGenerated]
	internal static void <ShowCriticalBackendErrorDialog>g__QitApplication|128_1() { }

	[AsyncStateMachine(typeof(<<ShowSessionResult>g__LoadSessionResultScene|247_0>d))]
	[CompilerGenerated]
	internal static Task <ShowSessionResult>g__LoadSessionResultScene|247_0() { }

	[CompilerGenerated]
	private void <StartTask>b__104_0() { }

	[CompilerGenerated]
	public void add_AfterApplicationLoaded(Action value) { }

	[CompilerGenerated]
	public void add_GameOverSaveStatusApplied(Action value) { }

	[AsyncStateMachine(typeof(<AppLoadMatchWaitScenario>d__219))]
	private Task AppLoadMatchWaitScenario(ProfileStatus profileStatus) { }

	private void AppLoadReconnectScenario(Profile profile, ProfileStatus profileStatus, bool isPet, Profile savageProfile) { }

	public void ApplyGameOverSaveStatus(RpcGameOverSaveStatusMessage message) { }

	private void ApplyMenuSecondBatchPrefetchResults(ChatsDataLoader chatsLoader) { }

	private void ApplyPrefetchLocationsToLocalState() { }

	private void ApplyUnlockAllLocationsEditorDebug() { }

	[AsyncStateMachine(typeof(<AwaitGameOverSaveStatusAsync>d__183))]
	private Task AwaitGameOverSaveStatusAsync() { }

	[AsyncStateMachine(typeof(<AwaitMenuSecondBatchPrefetchAsync>d__205))]
	private Task AwaitMenuSecondBatchPrefetchAsync() { }

	public Task AwaitPostRaidMenuWarmupAsync() { }

	public Task AwaitPostRaidResourceCleanupAsync() { }

	public void BeginPostRaidMenuWarmup() { }

	protected virtual Task BundleCheck(string bundlePath) { }

	private void ClearMenuFirstBatchPrefetchState() { }

	private void ClearMenuNetworkPrefetchState() { }

	private void ClearMenuSecondBatchPrefetchState() { }

	private void ClearPendingCharacterSelection() { }

	private void ClearPostRaidMenuWarmupState() { }

	[AsyncStateMachine(typeof(<ComebackToMainMenu>d__250))]
	private Task ComebackToMainMenu(bool sendLoadStats = false, bool waitForGameOverSaveStatus = false) { }

	protected virtual bool ConfigureApplication() { }

	[AsyncStateMachine(typeof(<CreateBackend>d__121))]
	protected virtual Task CreateBackend(EGameMode gameMode) { }

	private IClientBackEnd CreateBackendInstance(bool developMode, string sessionId, EGameMode gameMode) { }

	protected virtual void DestroyApplication() { }

	private void DestroyMenuUIAndInvalidateMenuLoad(bool destroyImmediate = true) { }

	private void DestroyNotificationManager() { }

	private void DiscardLocalMatchmaker() { }

	private void DisposeMenuSecondBatchCancellation() { }

	[AsyncStateMachine(typeof(<EnsureCharacterSelectionSessionAlive>d__147))]
	private Task EnsureCharacterSelectionSessionAlive() { }

	private void EnsureComebackMenuNetworkPrefetchStarted() { }

	private Task EnsureMenuUIReadyAsync() { }

	[AsyncStateMachine(typeof(<EnsureNotificationManagerAsync>d__134))]
	private Task EnsureNotificationManagerAsync() { }

	private void EnsureObjectsFactoryCreated() { }

	[AsyncStateMachine(typeof(<ExecuteCharacterSelection>d__157))]
	private Task ExecuteCharacterSelection(CharacterSelectionResult result, bool startupFlow) { }

	public static bool Exist(out TarkovApplication tarkovApplication) { }

	[AsyncStateMachine(typeof(<ExitApplication>d__218))]
	private Task ExitApplication() { }

	private void ExitApplicationWithConfirm() { }

	public void FailGameOverSaveStatus(string reason) { }

	[AsyncStateMachine(typeof(<GamePrepare>d__237))]
	private Task GamePrepare(bool isRaid = true) { }

	[AsyncStateMachine(typeof(<GameReconnect>d__220))]
	private Task GameReconnect(string profileId, bool isPet, Profile savageProfile, bool canEscape = true, bool inTransition = false) { }

	[CompilerGenerated]
	public override int get_CurrentRaidNum() { }

	public RaidSettings get_CurrentRaidSettings() { }

	[CompilerGenerated]
	public override int get_CurrentTotalRaidNum() { }

	[CompilerGenerated]
	public bool get_GameOverSaveStatusFailed() { }

	[CompilerGenerated]
	public RpcGameOverSaveStatusMessage get_GameOverSaveStatusMessage() { }

	[CompilerGenerated]
	public bool get_GameOverSaveStatusReceived() { }

	[CompilerGenerated]
	public HideoutController get_HideoutControllerAccess() { }

	public bool get_IsInMatchmakerGroup() { }

	private MatchmakerPlayersController get_Matchmaker() { }

	private MatchmakerOperation get_MatchmakerOperation() { }

	[CompilerGenerated]
	public NarrateController get_NarrateControllerAccess() { }

	private bool get_ShouldReloadCharacterSelection() { }

	[CompilerGenerated]
	public int get_TransitHopPlayersCount() { }

	public TransitionStatus get_TransitionStatus() { }

	private static string GetLoadMetricsLocationName(Location location) { }

	private void GetOrStartPrefetchedDailyQuestsTask() { }

	private Task GetOrStartPrefetchedTutorialInfoTask(bool skipTutorial) { }

	private string GetPendingCharacterProfileId() { }

	private Profile GetProfileForLocalGame() { }

	private Nullable GetStartupGameModeOverride() { }

	private void HandleError(string matchingName, Exception e) { }

	private void HandleExpansionsNotification(NotificationExpansions expansionsNotification) { }

	[AsyncStateMachine(typeof(<HandleExpansionsNotificationAsync>d__138))]
	private Task HandleExpansionsNotificationAsync(NotificationExpansions expansionsNotification) { }

	private bool HasPendingEmptyCharacterSelection() { }

	protected virtual void Init(IAssetsManager assetsManager, InputTree inputTree) { }

	private void InitBonusController() { }

	[AsyncStateMachine(typeof(<InitIconCreators>d__198))]
	private Task InitIconCreators() { }

	private void InitMenuSocialNetwork(ChatsDataLoader chatsLoader) { }

	[AsyncStateMachine(typeof(<InitPreloaderUI>d__133))]
	private Task InitPreloaderUI() { }

	[AsyncStateMachine(typeof(<InternalStartGame>d__111))]
	public Task InternalStartGame(string gameMap, bool isLocalGame, bool isBotEnabled) { }

	private void InvalidateMenuLoad() { }

	private bool IsCurrentCharacterSelection(CharacterSelectionProfileData profileData, EGameMode gameMode) { }

	private bool IsLeaving(out bool isPet, bool isMatching = false) { }

	private bool IsLocalTransitHop() { }

	private static bool IsProfileAlreadyInMatching(Exception exception) { }

	private bool IsStayedAlive(ExitStatus exitStatus) { }

	protected virtual void LateUpdate() { }

	private Task LegacyLogin() { }

	[AsyncStateMachine(typeof(<LoadAvailableLanguages>d__124))]
	private Task LoadAvailableLanguages() { }

	[AsyncStateMachine(typeof(<LoadCharacterSelectionBootstrap>d__149))]
	private Task LoadCharacterSelectionBootstrap() { }

	[AsyncStateMachine(typeof(<LoadCharacterSelectionData>d__150))]
	private Task LoadCharacterSelectionData() { }

	[AsyncStateMachine(typeof(<LoadCharacterSelectionExpansionsSettings>d__151))]
	private Task LoadCharacterSelectionExpansionsSettings() { }

	[AsyncStateMachine(typeof(<LoadLocations>d__210))]
	private Task LoadLocations() { }

	[AsyncStateMachine(typeof(<LoadLoginScenes>d__109))]
	protected virtual Task LoadLoginScenes() { }

	protected virtual Task LoadMainMenu() { }

	[AsyncStateMachine(typeof(<LoadMapAndData>d__236))]
	private Task LoadMapAndData(ScenePresetLoadConfig scenePreset, CancellationToken cancellationToken, bool isLocalGame, bool canEscape = true, bool resetRaidPoolsBeforeInit = false) { }

	[AsyncStateMachine(typeof(<LoadMenuSecondBatchColdAsync>d__206))]
	private Task LoadMenuSecondBatchColdAsync() { }

	[AsyncStateMachine(typeof(<LoadMenuUISceneAsync>d__173))]
	private Task LoadMenuUISceneAsync() { }

	[AsyncStateMachine(typeof(<LocalGameCreate>d__243))]
	private Task LocalGameCreate(GameWorld gameWorld, TimeAndWeatherSettings timeAndWeather, TimeHasComeScreenController timeHasComeScreenController, ClientMetricsEvents metricsEvents, ClientMetricsConfig metricsConfig) { }

	[AsyncStateMachine(typeof(<LocalGameMatching>d__233))]
	private Task LocalGameMatching(TimeAndWeatherSettings timeAndWeather, bool inTransition = false) { }

	private TimeSpan LocalGameSessionTime(int defaultMinutes) { }

	[AsyncStateMachine(typeof(<Logout>d__129))]
	private Task Logout() { }

	[AsyncStateMachine(typeof(<MainMenu>d__222))]
	private Task MainMenu() { }

	[AsyncStateMachine(typeof(<MainMenuLoad>d__132))]
	private Task MainMenuLoad() { }

	[AsyncStateMachine(typeof(<NetworkGameCreate>d__238))]
	private Task NetworkGameCreate(string profileId, Profile savageProfile, Location location, ClientGameWorld gameWorld, ClientMetricsEvents metricsEvents) { }

	private void NetworkGameCreate(ProfileStatus profileStatus, Profile savageProfile, ClientGameWorld gameWorld, ClientMetricsEvents metricsEvents, ClientMetricsConfig metricsConfig) { }

	[AsyncStateMachine(typeof(<NetworkGameCreateJob>d__239))]
	private Task NetworkGameCreateJob(string profileId, Profile savageProfile, ClientGameWorld gameWorld, ClientMetricsEvents metricsEvents) { }

	[AsyncStateMachine(typeof(<NetworkGameMatching>d__234))]
	private Task NetworkGameMatching(string groupId, EMatchingType type) { }

	private void NotificationReceivedHandler(Notification notification) { }

	private void OnAbortFinished(IResult result, Action callback) { }

	private void OnApplicationLoaded(bool interactiveMainMenuForColdBoot = true) { }

	private void OnApplicationQuit() { }

	[AsyncStateMachine(typeof(<OnGameEnd>d__246))]
	private void OnGameEnd(string profileId, Profile savageProfile, Location location, Result result) { }

	[AsyncStateMachine(typeof(<OnLogoutDone>d__130))]
	private Task OnLogoutDone(Task unloadNarrateTask, Task unloadHideoutTask) { }

	private void OnOnCharacterSelect() { }

	[AsyncStateMachine(typeof(<OnReadyToStartMatchingAsync>d__226))]
	private Task OnReadyToStartMatchingAsync() { }

	[AsyncStateMachine(typeof(<OpenCharacterSelectionFromMenu>d__143))]
	public Task OpenCharacterSelectionFromMenu() { }

	private void OpenChatPanel(bool on) { }

	[AsyncStateMachine(typeof(<PrefetchMenuDataPrepareOperation>d__193))]
	private Task PrefetchMenuDataPrepareOperation(CancellationToken cancellation) { }

	[AsyncStateMachine(typeof(<PrepareData>d__200))]
	private Task PrepareData() { }

	[AsyncStateMachine(typeof(<PrepareDataJob>d__201))]
	private Task PrepareDataJob(CancellationToken menuLoadCancellationToken) { }

	[AsyncStateMachine(typeof(<PrepareGame>d__165))]
	private Task PrepareGame() { }

	[AsyncStateMachine(typeof(<PrepareGameJob>d__197))]
	private Task PrepareGameJob() { }

	[AsyncStateMachine(typeof(<RecoverTransitMatchingOrShowError>d__231))]
	private Task RecoverTransitMatchingOrShowError(string matchingName, Exception e) { }

	[AsyncStateMachine(typeof(<RecreateBackend>d__117))]
	public Task RecreateBackend(EGameMode gameMode, bool force = false, bool showLoadingScreen = true) { }

	[AsyncStateMachine(typeof(<RecreateBackendWithResult>d__118))]
	private Task RecreateBackendWithResult(EGameMode gameMode, bool force = false, bool showLoadingScreen = true) { }

	[AsyncStateMachine(typeof(<RecreateCurrentBackend>d__119))]
	public Task RecreateCurrentBackend() { }

	[AsyncStateMachine(typeof(<RecreateCurrentBackendWithResult>d__120))]
	private Task RecreateCurrentBackendWithResult() { }

	private Task ReloadAfterShopPurchase(bool fullReload) { }

	[AsyncStateMachine(typeof(<ReloadCharacterSelection>d__141))]
	private Task ReloadCharacterSelection(bool fullReload) { }

	[AsyncStateMachine(typeof(<ReloadCharacterSelectionSession>d__142))]
	private Task ReloadCharacterSelectionSession(CharacterSelectionScreenController controller) { }

	[CompilerGenerated]
	public void remove_AfterApplicationLoaded(Action value) { }

	[CompilerGenerated]
	public void remove_GameOverSaveStatusApplied(Action value) { }

	[AsyncStateMachine(typeof(<RequestBuildList>d__209))]
	private Task RequestBuildList() { }

	public void ResetGameOverSaveStatus() { }

	[AsyncStateMachine(typeof(<Run>d__215))]
	private Task Run(Profile profile, ProfileStatus profileStatus, bool isPet, Profile savageProfile) { }

	[AsyncStateMachine(typeof(<RunCharacterSelectionFlow>d__156))]
	private Task RunCharacterSelectionFlow(CharacterSelectionDataResponse data, bool startupFlow, SeasonalPerksData seasonalPerks, ExtensionsSettings expansionsSettings, Nullable returnGameMode = null, bool canGoBackToLanguage = false) { }

	[AsyncStateMachine(typeof(<RunDeferredRagfairWarmup>d__224))]
	private Task RunDeferredRagfairWarmup() { }

	[AsyncStateMachine(typeof(<RunInitialLobbyFlow>d__146))]
	private Task RunInitialLobbyFlow() { }

	[AsyncStateMachine(typeof(<RunPostRaidMenuWarmupAsync>d__184))]
	private Task RunPostRaidMenuWarmupAsync() { }

	[AsyncStateMachine(typeof(<RunPostRaidResourceCleanupAsync>d__185))]
	private Task RunPostRaidResourceCleanupAsync() { }

	internal void RunProfile() { }

	[AsyncStateMachine(typeof(<RunProfiledFirstBatchNetworkLoad>d__190))]
	private Task RunProfiledFirstBatchNetworkLoad() { }

	[AsyncStateMachine(typeof(<RunProfiledSecondBatchNetworkLoad>d__191))]
	private Task RunProfiledSecondBatchNetworkLoad() { }

	[AsyncStateMachine(typeof(<RunValidateAnticheat>d__223))]
	private Task RunValidateAnticheat() { }

	public void SendClientLoadTimeMetric(int onlineAffiliation, int metricsType, int metricsValue, string locationName, bool isPMC) { }

	[CompilerGenerated]
	private void set_CurrentRaidNum(int value) { }

	[CompilerGenerated]
	private void set_CurrentTotalRaidNum(int value) { }

	[CompilerGenerated]
	private void set_GameOverSaveStatusFailed(bool value) { }

	[CompilerGenerated]
	public void set_GameOverSaveStatusMessage(RpcGameOverSaveStatusMessage value) { }

	[CompilerGenerated]
	public void set_GameOverSaveStatusReceived(bool value) { }

	[CompilerGenerated]
	private void set_HideoutControllerAccess(HideoutController value) { }

	[CompilerGenerated]
	private void set_NarrateControllerAccess(NarrateController value) { }

	[CompilerGenerated]
	public void set_TransitHopPlayersCount(int value) { }

	public void set_TransitionStatus(TransitionStatus value) { }

	private void SetPendingCharacterSelection(CharacterSelectionProfileData profileData) { }

	private void SetSessionId(ProfileStatus profileStatus) { }

	private static bool ShouldKeepLoadedScene(Scene scene) { }

	private bool ShouldSkipSessionResult(Location location, ExitStatus exitStatus) { }

	[AsyncStateMachine(typeof(<ShowCharacterSelectionScreen>d__155))]
	private Task ShowCharacterSelectionScreen(CharacterSelectionDataResponse data, bool startupFlow, string profileId = null, Nullable currentGameMode = null, SeasonalPerksData seasonalPerks = null, ExtensionsSettings expansionsSettings = null, bool canGoBack = false) { }

	private void ShowCriticalBackendErrorDialog(BackendWithCodeException exception, string customTitle = null) { }

	private void ShowExpansionsConfirmationPopup(string message, string caption, bool fullReload) { }

	public void ShowFinalStatistics() { }

	[AsyncStateMachine(typeof(<ShowLanguageSelection>d__154))]
	private Task ShowLanguageSelection() { }

	[AsyncStateMachine(typeof(<ShowLanguageSelectionIfNeeded>d__153))]
	private Task ShowLanguageSelectionIfNeeded(CharacterSelectionDataResponse profiles) { }

	[AsyncStateMachine(typeof(<ShowLegacyLoginDialog>d__126))]
	private Task ShowLegacyLoginDialog() { }

	[AsyncStateMachine(typeof(<ShowLegacyLoginScreen>d__131))]
	private void ShowLegacyLoginScreen() { }

	public void ShowMenuScreen() { }

	[AsyncStateMachine(typeof(<ShowProfileLoadingScreen>d__127))]
	private Task ShowProfileLoadingScreen() { }

	[AsyncStateMachine(typeof(<ShowSessionResult>d__247))]
	private Task ShowSessionResult(string profileId, Profile savageProfile, Location location, ExitStatus exitStatus, TimeSpan exitTime, ClientMetrics clientMetrics) { }

	private TimeHasComeScreenController ShowTimeHasComeScreen(bool isPet, CancellationTokenSource cancellationToken, bool isReconnecting = false) { }

	[AsyncStateMachine(typeof(<ShowTransitSaveWaitScreen>d__256))]
	private Task ShowTransitSaveWaitScreen() { }

	private Task StartMenuFirstBatchNetworkLoad(bool skipProfile) { }

	private Task StartMenuSecondBatchNetworkLoad() { }

	[AsyncStateMachine(typeof(<StartOnlineTransitMatching>d__255))]
	private Task StartOnlineTransitMatching() { }

	[AsyncStateMachine(typeof(<StartTask>d__104))]
	protected virtual Task StartTask() { }

	[AsyncStateMachine(typeof(<StartTutorial>d__225))]
	private Task StartTutorial(bool blockScreen = false, bool tutorialProfile = true) { }

	private static bool TryCreateInRaidCharacterSelection(CharacterSelectionDataResponse data, out CharacterSelectionResult result) { }

	public bool TryGetLocationById(string locationId, out Location location) { }

	[AsyncStateMachine(typeof(<TryReconnectIfTransitDestStarted>d__254))]
	private Task TryReconnectIfTransitDestStarted() { }

	[AsyncStateMachine(typeof(<TryRecoverAlreadyInMatching>d__230))]
	private Task TryRecoverAlreadyInMatching(Exception exception) { }

	private void TryUnloadGame() { }

	[AsyncStateMachine(typeof(<UnloadPostRaidScenesAsync>d__176))]
	private Task UnloadPostRaidScenesAsync() { }

	private void UnsubscribeMenuOperation() { }

	protected virtual void Update() { }

	[AsyncStateMachine(typeof(<ValidateAnticheat>d__112))]
	private Task ValidateAnticheat() { }

	[AsyncStateMachine(typeof(<ValidateEnvironmentUI>d__199))]
	private Task ValidateEnvironmentUI() { }

	[AsyncStateMachine(typeof(<WaitForProfileStatus>d__213))]
	private Task WaitForProfileStatus(EProfileStatus status, bool isPet, int interval = 2000, int maxAttempts = 360) { }

	[AsyncStateMachine(typeof(<WaitLeaving>d__212))]
	private Task WaitLeaving(bool isMatching = false) { }

}

