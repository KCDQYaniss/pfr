namespace EFT;

public sealed class MainMenuShowOperation : Operation, IProfileChangeHandler
{
	[CompilerGenerated]
	private struct <<FinishScavSession>b__89_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<FinishScavSession>b__89_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__85_0; //Field offset: 0x8
		public static Func <>9__113_0; //Field offset: 0x10
		public static Func <>9__124_0; //Field offset: 0x18
		public static Action <>9__133_0; //Field offset: 0x20
		public static Action <>9__133_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <HandleCustomizationUpdateRequired>b__85_0(AvailableCustomization customization) { }

		internal void <ShowMenuScreen>b__133_0() { }

		internal void <ShowMenuScreen>b__133_1() { }

		internal bool <ShowTraderScreensGroup>b__124_0(Trader trader) { }

		internal bool <ShowTransferItemsScreen>b__113_0(DialogueChatMessage message) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass109_0
	{
		public LobbyInventoryScreenController lobbyInventoryScreenController; //Field offset: 0x10
		public MainMenuShowOperation <>4__this; //Field offset: 0x18

		public <>c__DisplayClass109_0() { }

		internal void <InventoryScreenControllerFactory>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass112_0
	{
		public ChatScreen chatPanel; //Field offset: 0x10
		public MainMenuShowOperation <>4__this; //Field offset: 0x18

		public <>c__DisplayClass112_0() { }

		internal void <ShowChatPanel>b__0() { }

		internal void <ShowChatPanel>b__1(IEnumerable messages, Nullable expirationTime) { }

		internal void <ShowChatPanel>b__2(string offerId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass121_0
	{
		public MainMenuShowOperation <>4__this; //Field offset: 0x10
		public MongoID traderId; //Field offset: 0x18

		public <>c__DisplayClass121_0() { }

		internal void <ShowTraderDialogScreen>b__0() { }

		internal bool <ShowTraderDialogScreen>b__2(Trader trader) { }

		internal void <ShowTraderDialogScreen>g__HandleActionFinished|1(DialogAction dialogAction) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass123_0
	{
		public MainMenuShowOperation <>4__this; //Field offset: 0x10
		public TradersScreenController tradeScreenShowArguments; //Field offset: 0x18

		public <>c__DisplayClass123_0() { }

		internal void <ShowTradersScreen>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass124_0
	{
		public TraderScreenController traderScreenController; //Field offset: 0x10
		public MainMenuShowOperation <>4__this; //Field offset: 0x18

		public <>c__DisplayClass124_0() { }

		internal void <ShowTraderScreensGroup>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass125_0
	{
		public RagfairScreenController tradeScreenShowArguments; //Field offset: 0x10
		public MainMenuShowOperation <>4__this; //Field offset: 0x18

		public <>c__DisplayClass125_0() { }

		internal void <ShowRagfairScreen>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass131_0
	{
		public FinalStatsArgs args; //Field offset: 0x10
		public MainMenuShowOperation <>4__this; //Field offset: 0x18

		public <>c__DisplayClass131_0() { }

		internal Task <TryShowFinalStatisticScreen>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public string locationReward; //Field offset: 0x10

		public <>c__DisplayClass74_0() { }

		internal bool <Init>b__1(KeyValuePair pair) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public DialogInvitationMessagesStorage invitationMessagesStorage; //Field offset: 0x10
		public MainMenuShowOperation <>4__this; //Field offset: 0x18

		public <>c__DisplayClass77_0() { }

		internal void <UpdateDialogueInvitationMessages>b__0(Conditional conditional) { }

		internal void <UpdateDialogueInvitationMessages>g__UpdateDialogueInvitationMessageData|2(Quest quest) { }

	}

	[CompilerGenerated]
	private struct <AfterErrorHandler>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckVersion>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Execute>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEftSession session; //Field offset: 0x20
		public EnvironmentUI environmentUI; //Field offset: 0x28
		public MenuUI menuUI; //Field offset: 0x30
		public CommonUI commonUI; //Field offset: 0x38
		public PreloaderUI preloaderUI; //Field offset: 0x40
		public RaidSettings raidSettings; //Field offset: 0x48
		public HideoutController hideoutController; //Field offset: 0x50
		public NarrateController narrateController; //Field offset: 0x58
		public Action onExitPressed; //Field offset: 0x60
		public Action onLogoutPressed; //Field offset: 0x68
		public bool tutorial; //Field offset: 0x70
		public Task prefetchedDailyQuestsTask; //Field offset: 0x78
		private MainMenuShowOperation <operation>5__2; //Field offset: 0x80
		private TaskAwaiter <>u__1; //Field offset: 0x88

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FinishScavSession>d__89 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleCustomizationUpdateRequired>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private CustomizationSolver <customizationSolver>5__2; //Field offset: 0x28
		private List <oldCustomizations>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadNarrateScene>d__120 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MongoID traderId; //Field offset: 0x20
		public MainMenuShowOperation <>4__this; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Logout>d__138 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MoveBrokenItemsToSortingTable>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private Grid <sortingTableGrid>5__2; //Field offset: 0x28
		private Enumerator <>7__wrap2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnScavTransferComplete>d__88 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30
		private TaskAwaiter <>u__3; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowMenuScreen>d__133 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private bool <showResult>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38
		private IEnumerator <>7__wrap2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartNarrate>d__135 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		public ETraderType dialogSource; //Field offset: 0x28
		public Nullable dialogId; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryOpenHideout>d__104 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		public HideoutEntryPoint hideoutEntryPoint; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryOpenMainMenu>d__105 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryShowMenuScreenOnStart>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private SeasonsChangeRankScreenController <changeRankScreenController>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <UpdateHealthController>d__71 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MainMenuShowOperation <>4__this; //Field offset: 0x20

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
		public <UpdateHealthController>d__71(int <>1__state) { }

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
	private struct <UpdateSeasonsLeaguesInfo>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuShowOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForScreen>d__132 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FinalStatisticController screenController; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string CRITICAL_ERROR_TITLE = "Critical error"; //Field offset: 0x0
	private const string CRITICAL_INVENTORY_ERROR_MESSAGE = "Inventory/CriticalErrorMessage"; //Field offset: 0x0
	private const float FORCE_SHUTDOWN_DELAY = 3; //Field offset: 0x0
	private const float CHECK_VERSION_DELAY = 30; //Field offset: 0x0
	private static readonly Color _errorColor; //Field offset: 0x0
	private static readonly HashSet _notificationErrorCodes; //Field offset: 0x10
	private readonly Task _prefetchedDailyQuestsTask; //Field offset: 0x38
	private readonly IEftSession _session; //Field offset: 0x40
	private readonly Profile _profile; //Field offset: 0x48
	private readonly CommonUI _commonUI; //Field offset: 0x50
	private readonly PreloaderUI _preloaderUI; //Field offset: 0x58
	private readonly MenuUI _menuUI; //Field offset: 0x60
	private readonly EnvironmentUI _environmentUi; //Field offset: 0x68
	private readonly HideoutController _hideoutController; //Field offset: 0x70
	private readonly NarrateController _narrateController; //Field offset: 0x78
	private readonly CompositeDisposable _compositeDisposable; //Field offset: 0x80
	private readonly Action _onLogoutPressed; //Field offset: 0x88
	private readonly Action _onExitPressed; //Field offset: 0x90
	private BonusController _bonusController; //Field offset: 0x98
	private RagfairSearch _ragfairSearch; //Field offset: 0xA0
	private DateTime _lastVersionCheckTime; //Field offset: 0xA8
	private OfflineStatisticManager _healthStatisticsManager; //Field offset: 0xB0
	private double _healthUpdateTime; //Field offset: 0xB8
	private QuestControllerClientBackend _questController; //Field offset: 0xC0
	private PrestigeController _prestigeController; //Field offset: 0xC8
	private SeasonalRewardControllerClientBackend _seasonalRewardController; //Field offset: 0xD0
	private NewsHub _newsHub; //Field offset: 0xD8
	private ExpansionsPlayerInfo _expansionsPlayerInfo; //Field offset: 0xE0
	private readonly string _matchingVersion; //Field offset: 0xE8
	private readonly bool _tutorial; //Field offset: 0xF0
	private bool _isInited; //Field offset: 0xF1
	[CompilerGenerated]
	private Action ProfileReloadEndAction; //Field offset: 0xF8
	[CompilerGenerated]
	private Action OnCharacterSelect; //Field offset: 0x100
	[CompilerGenerated]
	private OfflineHealthController <HealthController>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private OfflineInventoryController <InventoryController>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private MatchmakerOperation <Matchmaker>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private RaidSettings <_raidSettings>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private AchievementsController <AchievementController>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private ClientBackendDialogController <DialogController>k__BackingField; //Field offset: 0x130

	public event Action OnCharacterSelect
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action ProfileReloadEndAction
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	private RaidSettings _raidSettings
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private AchievementsController AchievementController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ClientBackendDialogController DialogController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public string GroupId
	{
		 get { } //Length: 33
	}

	public private OfflineHealthController HealthController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private OfflineInventoryController InventoryController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public EMatchingType MatchingType
	{
		 get { } //Length: 32
	}

	public private MatchmakerOperation Matchmaker
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public QuestController QuestController
	{
		 get { } //Length: 8
	}

	public bool SupportsProfileReload
	{
		 get { } //Length: 82
	}

	private static MainMenuShowOperation() { }

	private MainMenuShowOperation(IEftSession session, EnvironmentUI environmentUI, MenuUI menuUI, CommonUI commonUI, PreloaderUI preloaderUI, RaidSettings raidSettings, HideoutController hideoutController, NarrateController narrateController, Action onExitPressed, Action onLogoutPressed, bool tutorial = false, Task prefetchedDailyQuestsTask = null) { }

	[AsyncStateMachine(typeof(<<FinishScavSession>b__89_0>d))]
	[CompilerGenerated]
	private void <FinishScavSession>b__89_0() { }

	[AsyncStateMachine(typeof(<<FinishScavSession>b__89_1>d))]
	[CompilerGenerated]
	private void <FinishScavSession>b__89_1(Result _) { }

	[CompilerGenerated]
	private void <Init>b__74_0(IEnumerable locations) { }

	[CompilerGenerated]
	private void <InventoryErrorHandler>b__95_0() { }

	[CompilerGenerated]
	private void <InventoryScreenControllerFactory>b__109_0() { }

	[CompilerGenerated]
	private void <ShowHandbookScreen>b__115_0() { }

	[CompilerGenerated]
	private void <ShowNewsHubScreen>b__101_0() { }

	[CompilerGenerated]
	private void <ShowScreen>b__99_0() { }

	[CompilerGenerated]
	private void <ShowTransferItemsScreen>b__113_1() { }

	[CompilerGenerated]
	private void <ShowWeaponBuildScreen>b__116_0() { }

	[CompilerGenerated]
	private void <TransferScavItems>b__87_0() { }

	[CompilerGenerated]
	internal static DialogInvitationMessageData <UpdateDialogueInvitationMessages>g__CreateDialogueInvitationMessageData|77_1(Quest quest) { }

	[CompilerGenerated]
	public void add_OnCharacterSelect(Action value) { }

	[CompilerGenerated]
	public void add_ProfileReloadEndAction(Action value) { }

	[AsyncStateMachine(typeof(<AfterErrorHandler>d__97))]
	private Task AfterErrorHandler() { }

	private void BonusChangedHandler(bool isActive, EBonusType bonusType) { }

	private void CancellableFilterAddedHandler(CancellableFilter filter) { }

	private void CancellableFilterRemovedHandler(CancellableFilter filter) { }

	private bool CanSaveAsBuild(ItemPreset preset) { }

	[AsyncStateMachine(typeof(<CheckVersion>d__70))]
	private void CheckVersion() { }

	private HideoutData CreateHideoutData(Profile profile, bool isGuest) { }

	private void CriticalInventoryErrorHandler() { }

	[AsyncStateMachine(typeof(<Execute>d__6))]
	public static Task Execute(IEftSession session, EnvironmentUI environmentUI, MenuUI menuUI, CommonUI commonUI, PreloaderUI preloaderUI, RaidSettings raidSettings, HideoutController hideoutController, NarrateController narrateController, Action onExitPressed, Action onLogoutPressed, bool tutorial = false, Task prefetchedDailyQuestsTask = null) { }

	private Task FinishNarrate() { }

	[AsyncStateMachine(typeof(<FinishScavSession>d__89))]
	private Task FinishScavSession() { }

	[CompilerGenerated]
	private RaidSettings get__raidSettings() { }

	[CompilerGenerated]
	public AchievementsController get_AchievementController() { }

	[CompilerGenerated]
	public ClientBackendDialogController get_DialogController() { }

	public string get_GroupId() { }

	[CompilerGenerated]
	public OfflineHealthController get_HealthController() { }

	[CompilerGenerated]
	public OfflineInventoryController get_InventoryController() { }

	public EMatchingType get_MatchingType() { }

	[CompilerGenerated]
	public MatchmakerOperation get_Matchmaker() { }

	public QuestController get_QuestController() { }

	public bool get_SupportsProfileReload() { }

	[AsyncStateMachine(typeof(<HandleCustomizationUpdateRequired>d__85))]
	public Task HandleCustomizationUpdateRequired() { }

	private void HandleWebPromoCodeNotification(NotificationBackendMessagePopup backendMessagePopupNotification) { }

	[AsyncStateMachine(typeof(<Init>d__74))]
	private Task Init() { }

	private void InventoryErrorHandler(string title, string message) { }

	private void InventoryErrorHandler(int errorCode, string error) { }

	private InventoryScreenController InventoryScreenControllerFactory(EInventoryTab tab) { }

	private bool IsScavInventoryScreenActive() { }

	[AsyncStateMachine(typeof(<LoadNarrateScene>d__120))]
	public Task LoadNarrateScene(MongoID traderId) { }

	[AsyncStateMachine(typeof(<Logout>d__138))]
	private Task Logout() { }

	[AsyncStateMachine(typeof(<MoveBrokenItemsToSortingTable>d__78))]
	private Task MoveBrokenItemsToSortingTable() { }

	private void NotificationReceivedHandler(Notification notification) { }

	public void OnBeingMatchedHandler() { }

	private void OnDialogStart(DialogStartData dialogStart) { }

	public override void OnProfileChangeApplied(ENotificationRequirements requirement) { }

	[AsyncStateMachine(typeof(<OnScavTransferComplete>d__88))]
	private Task OnScavTransferComplete() { }

	private void OpenHideoutAtAreaSync(EAreaType area) { }

	private void OpenHideoutAtDialogueSync(EDialogEntryPoint entryPoint) { }

	private void OpenHideoutAtMainPointSync() { }

	private void RagfairSearch(RagfairSearch search) { }

	public Task ReloadProfile() { }

	[CompilerGenerated]
	public void remove_OnCharacterSelect(Action value) { }

	[CompilerGenerated]
	public void remove_ProfileReloadEndAction(Action value) { }

	private void ScreenChangeHandler(EEftScreenType eftScreenType) { }

	private static void SendErrorNotification(string message) { }

	[CompilerGenerated]
	private void set__raidSettings(RaidSettings value) { }

	[CompilerGenerated]
	private void set_AchievementController(AchievementsController value) { }

	[CompilerGenerated]
	private void set_DialogController(ClientBackendDialogController value) { }

	[CompilerGenerated]
	private void set_HealthController(OfflineHealthController value) { }

	[CompilerGenerated]
	private void set_InventoryController(OfflineInventoryController value) { }

	[CompilerGenerated]
	private void set_Matchmaker(MatchmakerOperation value) { }

	private void ShowCharacterSelectionScreen() { }

	private void ShowChatPanel() { }

	private void ShowExpansionsScreen() { }

	private void ShowFinalStatisticsScreen() { }

	private void ShowHandbookScreen() { }

	[AsyncStateMachine(typeof(<ShowMenuScreen>d__133))]
	private Task ShowMenuScreen() { }

	public void ShowMenuScreenSync() { }

	private void ShowNewsHubScreen() { }

	private void ShowPlayerQuestsScreen() { }

	private void ShowPlayerScreen() { }

	private void ShowRagfairScreen() { }

	public void ShowScreen(EMenuType screen, bool turnOn) { }

	private void ShowSeasonsHubScreen() { }

	private void ShowSettingsScreen() { }

	public void ShowTraderDialogScreen(MongoID traderId, Nullable entryDialogId = null, ITraderAnimationController animationController = null) { }

	private void ShowTraderScreensGroup(Trader selectedTrader = null) { }

	private void ShowTradersScreen() { }

	private void ShowTransferItemsScreen(IEnumerable messages, Nullable expirationTime) { }

	private void ShowWeaponBuildScreen(Weapon weapon) { }

	private void SkillLevelUpHandler(BaseSkill skill) { }

	[AsyncStateMachine(typeof(<StartNarrate>d__135))]
	private Task StartNarrate(ETraderType dialogSource, Nullable dialogId) { }

	public void StopHealthUpdate() { }

	public void StoreProfile() { }

	private void SyncBonusControllerSingleton() { }

	private void ToggleScreen(IEnumerable eftScreenTypes, Action showAction) { }

	private void ToggleScreen(EEftScreenType eftScreenType, Action showAction) { }

	private void TransferScavItems(IEftSession session, Profile mainProfile, Profile scavProfile, OfflineInventoryController mainController) { }

	[AsyncStateMachine(typeof(<TryOpenHideout>d__104))]
	private Task TryOpenHideout(HideoutEntryPoint hideoutEntryPoint) { }

	[AsyncStateMachine(typeof(<TryOpenMainMenu>d__105))]
	private Task TryOpenMainMenu() { }

	private bool TryShowFinalStatisticScreen(out Func show, out EndingElement ending) { }

	[AsyncStateMachine(typeof(<TryShowMenuScreenOnStart>d__75))]
	private Task TryShowMenuScreenOnStart() { }

	public void Unsubscribe() { }

	private void UpdateDialogueInvitationMessages() { }

	[IteratorStateMachine(typeof(<UpdateHealthController>d__71))]
	private IEnumerator UpdateHealthController() { }

	[AsyncStateMachine(typeof(<UpdateSeasonsLeaguesInfo>d__76))]
	private Task UpdateSeasonsLeaguesInfo() { }

	[AsyncStateMachine(typeof(<WaitForScreen>d__132))]
	private Task WaitForScreen(FinalStatisticController screenController) { }

	private void WarningHandler(IInventoryWarning inventoryWarning) { }

}

