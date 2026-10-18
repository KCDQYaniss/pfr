namespace EFT.UI.Matchmaker;

public sealed class MatchmakerTimeHasCome : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public ESideType side; //Field offset: 0x10
		public MatchmakerTimeHasCome <>4__this; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal bool <Show>b__0(Profile value) { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public MatchmakerPlayersController matchmaker; //Field offset: 0x10
		public MatchmakerTimeHasCome <>4__this; //Field offset: 0x18

		public <>c__DisplayClass24_0() { }

		internal void <SubscribeToMatchmaker>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public MatchmakerTimeHasCome <>4__this; //Field offset: 0x10
		public PlayerVisualRepresentation playerVisual; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

		internal bool <ShowPlayerModel>b__0() { }

		internal void <ShowPlayerModel>b__1() { }

	}

	[CompilerGenerated]
	private struct <ShowPlayerModel>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerTimeHasCome <>4__this; //Field offset: 0x20
		public PlayerVisualRepresentation playerVisual; //Field offset: 0x28
		private <>c__DisplayClass27_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryAbortMatching>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerTimeHasCome <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class ReconnectTimeHasComeScreenController : TimeHasComeScreenController
	{

		public virtual bool IsReconnecting
		{
			 get { } //Length: 3
		}

		protected virtual string TaskBarButtonCustomTooltip
		{
			 get { } //Length: 3
		}

		public ReconnectTimeHasComeScreenController(IEftSession session, RaidSettings raidSettings, MatchmakerPlayersController matchmaker) { }

		public virtual bool get_IsReconnecting() { }

		protected virtual string get_TaskBarButtonCustomTooltip() { }

		public virtual void SwitchTaskBarButtonsAvailability(bool interactable) { }

	}

	internal class TimeHasComeScreenController : EftScreenController
	{
		[CompilerGenerated]
		private readonly Dictionary <TaskbarButtonsStateDuringMatching>k__BackingField; //Field offset: 0x58
		public readonly IEftSession Session; //Field offset: 0x60
		public readonly RaidSettings RaidSettings; //Field offset: 0x68
		private readonly MatchmakerPlayersController _matchmaker; //Field offset: 0x70

		public override bool IsPartyInfoPanelVisible
		{
			 get { } //Length: 3
		}

		public override bool IsReconnecting
		{
			 get { } //Length: 3
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		public bool LimitedServersAvailability
		{
			 get { } //Length: 101
		}

		public override MatchmakerPlayersController Matchmaker
		{
			 get { } //Length: 5
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual string TaskBarButtonCustomTooltip
		{
			 get { } //Length: 49
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		private Dictionary TaskbarButtonsStateDuringMatching
		{
			[CompilerGenerated]
			private get { } //Length: 5
		}

		protected TimeHasComeScreenController(IEftSession session, RaidSettings raidSettings) { }

		public TimeHasComeScreenController(IEftSession session, RaidSettings raidSettings, MatchmakerPlayersController matchmaker) { }

		public override bool get_IsPartyInfoPanelVisible() { }

		public override bool get_IsReconnecting() { }

		public virtual bool get_KeyScreen() { }

		public bool get_LimitedServersAvailability() { }

		public override MatchmakerPlayersController get_Matchmaker() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual string get_TaskBarButtonCustomTooltip() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		[CompilerGenerated]
		private Dictionary get_TaskbarButtonsStateDuringMatching() { }

		public override void SwitchTaskBarButtonsAvailability(bool interactable) { }

	}

	internal sealed class TransitTimeHasComeScreenController : TimeHasComeScreenController
	{
		private MatchmakerPlayersController _matchmaker; //Field offset: 0x78
		[CompilerGenerated]
		private readonly MatchingProgress <WaitingProgress>k__BackingField; //Field offset: 0x80

		public virtual bool IsPartyInfoPanelVisible
		{
			 get { } //Length: 3
		}

		public virtual MatchmakerPlayersController Matchmaker
		{
			 get { } //Length: 5
		}

		public bool WaitingForMatchmaker
		{
			 get { } //Length: 9
		}

		public MatchingProgress WaitingProgress
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public TransitTimeHasComeScreenController(IEftSession session, RaidSettings raidSettings) { }

		public void BindMatchmaker(MatchmakerPlayersController matchmaker) { }

		public virtual bool get_IsPartyInfoPanelVisible() { }

		public virtual MatchmakerPlayersController get_Matchmaker() { }

		public bool get_WaitingForMatchmaker() { }

		[CompilerGenerated]
		public MatchingProgress get_WaitingProgress() { }

	}

	internal class TutorialTimeHasComeScreenController : TimeHasComeScreenController
	{

		public virtual bool IsPartyInfoPanelVisible
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public TutorialTimeHasComeScreenController(IEftSession session, RaidSettings raidSettings, MatchmakerPlayersController matchmaker) { }

		public virtual bool get_IsPartyInfoPanelVisible() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

	}

	[SerializeField]
	private PlayerModelView _playerModelView; //Field offset: 0xA0
	[SerializeField]
	private XCoordRotation _rotator; //Field offset: 0xA8
	[SerializeField]
	private DragTrigger _dragTrigger; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _locationName; //Field offset: 0xB8
	[SerializeField]
	private MatchmakerBannersPanel _bannersPanel; //Field offset: 0xC0
	[SerializeField]
	private PartyInfoPanel _partyInfoPanel; //Field offset: 0xC8
	[SerializeField]
	private TextMeshProUGUI _subCaption; //Field offset: 0xD0
	[SerializeField]
	private TextMeshProUGUI _deployingText; //Field offset: 0xD8
	[SerializeField]
	private DefaultUIButton _cancelButton; //Field offset: 0xE0
	[SerializeField]
	private MatchingProgressView _matchingProgressView; //Field offset: 0xE8
	private bool _canEscape; //Field offset: 0xF0
	private readonly UIParent _playerModelSubscriber; //Field offset: 0xF8
	private readonly UIParent _matchmakerSubscriber; //Field offset: 0x100
	private RaidSettings _raidSettings; //Field offset: 0x108
	private MatchmakerPlayersController _matchmaker; //Field offset: 0x110
	private string _currentPlayerModelNickname; //Field offset: 0x118
	private Coroutine _abortAbilityTimerCoroutine; //Field offset: 0x120

	public MatchmakerTimeHasCome() { }

	[CompilerGenerated]
	private void <Awake>b__21_0() { }

	[CompilerGenerated]
	private bool <TryAbortMatching>b__32_0() { }

	private void Awake() { }

	public void BindTransitMatchmaker(MatchmakerPlayersController matchmaker) { }

	private void ChangeCancelButtonVisibility(bool available) { }

	private void ChangeStatus() { }

	private void DragHandler(PointerEventData pointerData) { }

	private void HandleOnPlayerClick(RaidPlayer raidPlayer) { }

	private void InventoryErrorDuringMatchingHandle() { }

	public virtual void Show(TimeHasComeScreenController controller) { }

	[AsyncStateMachine(typeof(<ShowPlayerModel>d__27))]
	private Task ShowPlayerModel(PlayerVisualRepresentation playerVisual = null) { }

	private void SubscribeToMatchmaker(MatchmakerPlayersController matchmaker) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	[AsyncStateMachine(typeof(<TryAbortMatching>d__32))]
	private Task TryAbortMatching() { }

	private void Update() { }

}

