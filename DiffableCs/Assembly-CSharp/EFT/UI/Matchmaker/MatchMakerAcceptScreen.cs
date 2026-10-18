namespace EFT.UI.Matchmaker;

public sealed class MatchMakerAcceptScreen : MatchmakerEftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__41_0; //Field offset: 0x8
		public static Func <>9__41_1; //Field offset: 0x10
		public static Func <>9__42_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <SetReadyStatus>b__42_0(RaidPlayer p) { }

		internal int <UpdateLocationByLevel>b__41_0(RaidPlayer p) { }

		internal int <UpdateLocationByLevel>b__41_1(RaidPlayer p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public MatchMakerAcceptScreen <>4__this; //Field offset: 0x10
		public MatchmakerAcceptScreenController screenController; //Field offset: 0x18
		public Func <>9__0; //Field offset: 0x20

		public <>c__DisplayClass53_0() { }

		internal bool <RepeatGetStatus>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public TweenerCore tween; //Field offset: 0x10

		public <>c__DisplayClass54_0() { }

		internal void <LockUpdateButton>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public MatchmakerAcceptScreenController screenController; //Field offset: 0x10

		public <>c__DisplayClass59_0() { }

		internal bool <WaitForTimeout>b__0() { }

	}

	[CompilerGenerated]
	private struct <GameStart>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchMakerAcceptScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LockUpdateButton>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchMakerAcceptScreen <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnQuestUnloadClicked>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchMakerAcceptScreen <>4__this; //Field offset: 0x20
		private CanvasGroup <cg>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RepeatGetStatus>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchMakerAcceptScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass53_0 <>8__1; //Field offset: 0x28
		private Task <delayTask>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetReadyStatus>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchMakerAcceptScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StopMatching>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchMakerAcceptScreen <>4__this; //Field offset: 0x20
		public Action callback; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForTimeout>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchMakerAcceptScreen <>4__this; //Field offset: 0x20
		private Task <exitTask>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class MatchmakerAcceptScreenController : EftMatchmakerScreenController
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			public IBaseScreenController previousScreen; //Field offset: 0x10

			public <>c__DisplayClass20_0() { }

			internal void <NavigateToRoot>b__0() { }

		}

		[CompilerGenerated]
		private Action OnReadyToStartRaid; //Field offset: 0x78
		public readonly IEftSession Session; //Field offset: 0x80
		public readonly RaidSettings RaidSettings; //Field offset: 0x88
		public readonly RaidSettings OfflineRaidSettings; //Field offset: 0x90

		public event Action OnReadyToStartRaid
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironmentCamera
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public MatchmakerAcceptScreenController(IEftSession session, ref RaidSettings raidSettings, ref RaidSettings offlineRaidSettings, MatchmakerPlayersController matchmakerPlayersController) { }

		[CompilerGenerated]
		public void add_OnReadyToStartRaid(Action value) { }

		protected virtual void CloseAction(bool moveForward) { }

		public virtual bool get_KeyScreen() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_ShowEnvironmentCamera() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		public void NavigateToRoot() { }

		[CompilerGenerated]
		public void remove_OnReadyToStartRaid(Action value) { }

		public void ShowNextScreen() { }

	}

	private const string STARTED_LOOKING_FOR_GROUP_NOTIFICATION = "Looking for group..."; //Field offset: 0x0
	private const string STOPPED_LOOKING_FOR_GROUP_NOTIFICATION = "Stop looking for group"; //Field offset: 0x0
	[SerializeField]
	private PlayersRaidReadyPanel _playersRaidReadyPanel; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _acceptButton; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xC0
	[SerializeField]
	private TextMeshProUGUI _locationName; //Field offset: 0xC8
	[SerializeField]
	private TextMeshProUGUI _groupMembersCountLabel; //Field offset: 0xD0
	[SerializeField]
	private GameObject _coopHighLoadPanel; //Field offset: 0xD8
	[SerializeField]
	private Button _updateListButton; //Field offset: 0xE0
	[SerializeField]
	private Button _coopSettingsButton; //Field offset: 0xE8
	[SerializeField]
	private MatchMakerPlayerPreview _playerModelView; //Field offset: 0xF0
	[SerializeField]
	private MatchMakerGroupPreview _groupPreview; //Field offset: 0xF8
	[SerializeField]
	private LocationConditionsPanel _conditions; //Field offset: 0x100
	[SerializeField]
	private SimpleContextMenu _contextMenu; //Field offset: 0x108
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x110
	[SerializeField]
	private CoopSettingsWindow _coopSettingsWindow; //Field offset: 0x118
	[SerializeField]
	private DefaultUiButtonNewStyle _questItemsButton; //Field offset: 0x120
	private IEftSession _backEndSession; //Field offset: 0x128
	private Profile _selectedProfile; //Field offset: 0x130
	private ERaidMode _raidMode; //Field offset: 0x138
	private bool _statusUpdateInterruption; //Field offset: 0x13C
	private bool _getStatusInterrupt; //Field offset: 0x13D
	private RaidSettings _raidSettings; //Field offset: 0x140
	private RaidSettings _offlineRaidSettings; //Field offset: 0x148
	private string _currentProfileAid; //Field offset: 0x150
	private DialogWindowContext _context; //Field offset: 0x158
	private LocationBlockedForPlayersTooltip _locationBlockedForPlayersTooltip; //Field offset: 0x160
	private List _lockedForPlayersList; //Field offset: 0x168

	private static int GroupStatusButtonUpdateInterval
	{
		private get { } //Length: 214
	}

	private static int GroupStatusInterval
	{
		private get { } //Length: 214
	}

	public MatchMakerAcceptScreen() { }

	[CompilerGenerated]
	private void <Awake>b__33_0() { }

	[CompilerGenerated]
	private void <Awake>b__33_1() { }

	[CompilerGenerated]
	private void <Awake>b__33_2() { }

	[CompilerGenerated]
	private void <Awake>b__33_3() { }

	[CompilerGenerated]
	private void <Awake>b__33_4() { }

	[CompilerGenerated]
	private void <Awake>b__33_5() { }

	[CompilerGenerated]
	private RaidGroupContextInteractions <MatchingTypeUpdate>b__50_0(RaidPlayer player, bool canShowProfile, bool inLobby) { }

	[CompilerGenerated]
	private RaidGroupContextInteractions <MatchingTypeUpdate>b__50_1(RaidPlayer player, bool canShowProfile, bool inLobby) { }

	[CompilerGenerated]
	private void <Show>b__36_0() { }

	[CompilerGenerated]
	private void <Show>b__36_1() { }

	[CompilerGenerated]
	private void <Show>b__36_2() { }

	[CompilerGenerated]
	private void <Show>b__36_3() { }

	[CompilerGenerated]
	private void <Show>b__36_4() { }

	private List AvailableForPlayers(Location location) { }

	private void Awake() { }

	public virtual void Close() { }

	private void DisableInsuranceScreen() { }

	[AsyncStateMachine(typeof(<GameStart>d__58))]
	private Task GameStart() { }

	private static int get_GroupStatusButtonUpdateInterval() { }

	private static int get_GroupStatusInterval() { }

	protected virtual void InviteAcceptedHandler() { }

	private void LimitedServersAvailability(bool maxPveExceeded) { }

	[AsyncStateMachine(typeof(<LockUpdateButton>d__54))]
	private Task LockUpdateButton() { }

	private void LookingForGroupHandler(bool isLooking) { }

	private void MatchingAvailabilityChanged(EMatchingStatus matchingStatus) { }

	private void MatchingTypeUpdate(EMatchingType matchingType) { }

	protected virtual void MatchingTypeUpdateHandler(EMatchingType matchingType) { }

	private void NavigateToRoot() { }

	private bool NeedUnloadQuestItems() { }

	[AsyncStateMachine(typeof(<OnQuestUnloadClicked>d__39))]
	private Task OnQuestUnloadClicked() { }

	private void OpenCoopSettingsWindow() { }

	private void PreTransferLeadershipHandler() { }

	private void RaidReadyStatusChangedHandler(RaidPlayer player, bool status) { }

	[AsyncStateMachine(typeof(<RepeatGetStatus>d__53))]
	private Task RepeatGetStatus() { }

	[AsyncStateMachine(typeof(<SetReadyStatus>d__42))]
	private Task SetReadyStatus() { }

	private void Show(IEftSession session, RaidSettings raidSettings, RaidSettings offlineRaidSettings) { }

	public virtual void Show(MatchmakerAcceptScreenController controller) { }

	public void ShowContextMenu(RaidPlayer player, Vector2 position, bool allowFriendPin) { }

	[AsyncStateMachine(typeof(<StopMatching>d__61))]
	private Task StopMatching(Action callback = null) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UpdateCoopPanels() { }

	private void UpdateLocationByLevel() { }

	private void UpdateLookingForGroup(bool isLooking, bool notify) { }

	private Task UpdateStatus() { }

	private void UpdateTeamGroupBonusUI() { }

	[AsyncStateMachine(typeof(<WaitForTimeout>d__59))]
	private Task WaitForTimeout() { }

}

