namespace EFT.UI.Matchmaker;

public abstract class BaseMatchmakerController`1 : IMatchmakerController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__112_0; //Field offset: 0x0
		public static Func <>9__152_0; //Field offset: 0x0
		public static Callback <>9__192_0; //Field offset: 0x0
		public static Action <>9__228_0; //Field offset: 0x0
		public static Func <>9__249_1; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <get_CoopAvailableForGroup>b__152_0(RaidPlayer player) { }

		internal bool <get_TotalReadyGroupPlayers>b__112_0(RaidPlayer item) { }

		internal void <ReportNickname>b__192_0(IResult result) { }

		internal void <ShowInteractionWindow>b__228_0() { }

		internal RaidPlayer <UpdatePlayers>b__249_1(GroupPlayer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass175_0
	{
		public NotificationManager notificator; //Field offset: 0x0
		public BaseMatchmakerController <>4__this; //Field offset: 0x0

		public <>c__DisplayClass175_0() { }

		internal void <.ctor>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass187_0
	{
		public CancellationToken cancellationToken; //Field offset: 0x0
		public BaseMatchmakerController <>4__this; //Field offset: 0x0

		public <>c__DisplayClass187_0() { }

		internal bool <CheckActiveInvites>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass194_0
	{
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		public GroupInvite invite; //Field offset: 0x0

		public <>c__DisplayClass194_0() { }

		internal void <AcceptInvitation>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass195_0
	{
		public GroupInvite invite; //Field offset: 0x0

		public <>c__DisplayClass195_0() { }

		internal bool <CheckAndDeclineInvitation>b__0(GroupInvite x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass196_0
	{
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		public GroupInvite invite; //Field offset: 0x0

		public <>c__DisplayClass196_0() { }

		internal void <DeclineInvitation>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass197_0
	{
		public TaskCompletionSource source; //Field offset: 0x0

		public <>c__DisplayClass197_0() { }

		internal void <UpdateStatus>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass198_0
	{
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		public Action callback; //Field offset: 0x0

		public <>c__DisplayClass198_0() { }

		internal void <UpdateStatus>b__0(Result groupStatusResult) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass199_0
	{
		public string profileAid; //Field offset: 0x0

		public <>c__DisplayClass199_0() { }

		internal bool <IsInGroup>b__0(RaidPlayer player) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass200_0
	{
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		public string newLeaderAid; //Field offset: 0x0
		public Action callback; //Field offset: 0x0

		public <>c__DisplayClass200_0() { }

		internal void <TransferLeadership>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass201_0
	{
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		public Action callback; //Field offset: 0x0

		public <>c__DisplayClass201_0() { }

		internal void <DisbandGroup>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass203_0
	{
		public string accountId; //Field offset: 0x0
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		public RaidPlayer player; //Field offset: 0x0
		public bool inLobby; //Field offset: 0x0
		public Action callback; //Field offset: 0x0

		public <>c__DisplayClass203_0() { }

		internal bool <SendInvite>b__0(UpdatableChatMember item) { }

		internal bool <SendInvite>b__1(RaidPlayer p) { }

		internal void <SendInvite>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass204_0
	{
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		public RaidPlayer player; //Field offset: 0x0
		public Action callback; //Field offset: 0x0

		public <>c__DisplayClass204_0() { }

		internal void <SendInvite>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass206_0
	{
		public string playerAid; //Field offset: 0x0
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		public Action callback; //Field offset: 0x0

		public <>c__DisplayClass206_0() { }

		internal bool <CancelInvite>b__0(GroupInvite item) { }

		internal void <CancelInvite>b__1(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass209_0
	{
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		public string playerAid; //Field offset: 0x0
		public Action callback; //Field offset: 0x0

		public <>c__DisplayClass209_0() { }

		internal void <RemovePlayerFromGroup>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass210_0
	{
		public string playerAid; //Field offset: 0x0

		public <>c__DisplayClass210_0() { }

		internal bool <IsInvitedByMe>b__0(GroupInvite invite) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass213_0
	{
		public string profileAid; //Field offset: 0x0

		public <>c__DisplayClass213_0() { }

		internal bool <GetPlayerByAid>b__0(RaidPlayer groupPlayer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass214_0
	{
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		public Action callback; //Field offset: 0x0

		public <>c__DisplayClass214_0() { }

		internal void <SetCurrentPlayerReadyStatus>b__0(IResult result) { }

		internal void <SetCurrentPlayerReadyStatus>b__1(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass238_0
	{
		public NotificationInviteReceived notification; //Field offset: 0x0
		public GroupInvite invite; //Field offset: 0x0

		public <>c__DisplayClass238_0() { }

		internal bool <InviteReceived>b__0(GroupPlayer player) { }

		internal bool <InviteReceived>b__1(GroupInvite i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass239_0
	{
		public string ownerAid; //Field offset: 0x0

		public <>c__DisplayClass239_0() { }

		internal bool <RemoveInvite>b__0(GroupInvite item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass242_0
	{
		public string playerAid; //Field offset: 0x0

		public <>c__DisplayClass242_0() { }

		internal bool <ChangeLeader>b__0(RaidPlayer player) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass243_0
	{
		public string playerAid; //Field offset: 0x0

		public <>c__DisplayClass243_0() { }

		internal bool <RemovePlayerFromGroup>b__0(RaidPlayer player) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass246_0
	{
		public string playerAid; //Field offset: 0x0

		public <>c__DisplayClass246_0() { }

		internal bool <RemoveSentInvite>b__0(GroupInvite x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass248_0
	{
		public RaidPlayer player; //Field offset: 0x0

		public <>c__DisplayClass248_0() { }

		internal bool <AddPlayerToGroup>b__0(RaidPlayer p) { }

		internal bool <AddPlayerToGroup>b__1(RaidPlayer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass249_0
	{
		public GroupPlayer x; //Field offset: 0x0

		public <>c__DisplayClass249_0() { }

		internal bool <UpdatePlayers>b__2(RaidPlayer gp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass250_0
	{
		public string fromAid; //Field offset: 0x0

		public <>c__DisplayClass250_0() { }

		internal bool <CanAcceptInvite>b__0(GroupInvite x) { }

	}

	[CompilerGenerated]
	private struct <CheckActiveInvites>d__187 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		private <>c__DisplayClass187_0 <>8__1; //Field offset: 0x0
		private GroupInvite <invite>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DisposeAsync>d__257 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExitFromMatchMaker>d__219 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LeaveGroup>d__202 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartLookingForGroup>d__207 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StopLookingForGroup>d__208 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BaseMatchmakerController <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const int MAX_PMC_COUNT = 5; //Field offset: 0x0
	public const int MAX_SCAV_COUNT = 4; //Field offset: 0x0
	public static bool StartLookingForGroupByDefault; //Field offset: 0x0
	private static bool _lookingForGroupBlocked; //Field offset: 0x0
	protected readonly ItemUiContext _itemUiContext; //Field offset: 0x0
	protected readonly CompositeDisposable _compositeDisposable; //Field offset: 0x0
	private MatchmakerUpdatableGroup _group; //Field offset: 0x0
	private bool _isLookingForGroup; //Field offset: 0x0
	private bool _isProcessingInvite; //Field offset: 0x0
	private bool _isSendingInvite; //Field offset: 0x0
	private bool _isSearchingForGame; //Field offset: 0x0
	private bool _limitedServersAvailability; //Field offset: 0x0
	private EMatchingStatus _matchingStatus; //Field offset: 0x0
	protected DialogWindowContext _messageWindowContext; //Field offset: 0x0
	[CompilerGenerated]
	private readonly BindableList <SentInvites>k__BackingField; //Field offset: 0x0
	protected readonly IMatchmakerSession _backEndSession; //Field offset: 0x0
	[CompilerGenerated]
	private MatchingProgress <MatchingProgress>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly BindableState <GroupState>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly UpdatableBindableList <RaidReadyPlayers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly BindableList <GroupPlayers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <GroupStatusSucceed>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly BindableState <LeaderRaidReadyState>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <Disposed>k__BackingField; //Field offset: 0x0
	private SocialNetwork _socialNetwork; //Field offset: 0x0
	private readonly string _profileAid; //Field offset: 0x0
	private TRaidSettings _backupRaidSettings; //Field offset: 0x0
	[CompilerGenerated]
	private bool <EnforceLocationGroupLimit>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnGroupCreated; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnGroupRemoved; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnGroupStatusChanged; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnLimitedServersAvailability; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnActiveInviteCancelled; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnInviteAccepted; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnInviteReceived; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnInviteInRaidAccepted; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnInviteInRaidShow; //Field offset: 0x0
	protected readonly TRaidSettings _currentRaidSettings; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnMatchingTypeUpdate; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnLookingForGroupStatusChanged; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnPlayerContextRequest; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnRaidReadyStatusChanged; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnInviteInRaidReceived; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnPreTransferLeadership; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnMatchingAbortReceived; //Field offset: 0x0
	public readonly BindableState MaxGroupCount; //Field offset: 0x0
	public RaidPlayer CurrentPlayer; //Field offset: 0x0
	private readonly List _receivedInvites; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnMatchingAvailabilityChanged; //Field offset: 0x0
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; //Field offset: 0x0

	public event Action OnActiveInviteCancelled
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnGroupCreated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnGroupRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnGroupStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnInviteAccepted
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnInviteInRaidAccepted
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnInviteInRaidReceived
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnInviteInRaidShow
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnInviteReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnLimitedServersAvailability
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnLookingForGroupStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnMatchingAbortReceived
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnMatchingAvailabilityChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnMatchingTypeUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnPlayerContextRequest
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnPreTransferLeadership
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override event Action OnRaidReadyStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public GroupInvite ActiveInvite
	{
		 get { } //Length: 131
	}

	private bool CanHandleNextInvite
	{
		private get { } //Length: 66
	}

	public bool CanHandleRaidInvite
	{
		 get { } //Length: 83
	}

	public bool CanShowGroupPreview
	{
		 get { } //Length: 194
	}

	public override bool CoopAvailableForGroup
	{
		 get { } //Length: 519
	}

	public override string CurrentProfileAid
	{
		 get { } //Length: 8
	}

	public EMatchingType CurrentProfileMatchingStatus
	{
		 get { } //Length: 27
	}

	public private bool Disposed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override bool Enabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool EnforceLocationGroupLimit
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private override MatchmakerUpdatableGroup Group
	{
		 get { } //Length: 8
		private set { } //Length: 192
	}

	public override string GroupId
	{
		 get { } //Length: 86
	}

	public override bool GroupIsFull
	{
		 get { } //Length: 271
	}

	public override BindableList GroupPlayers
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override BindableState GroupState
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private bool GroupStatusSucceed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool Initialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool IsInviteBlockedByHideout
	{
		private get { } //Length: 64
	}

	public bool IsInvited
	{
		 get { } //Length: 72
	}

	public bool IsLeader
	{
		 get { } //Length: 57
	}

	public override bool IsLocalGame
	{
		 get { } //Length: 76
	}

	public private override bool IsLookingForGroup
	{
		 get { } //Length: 8
		private set { } //Length: 31
	}

	public bool IsMeInGroup
	{
		 get { } //Length: 99
	}

	public override bool IsOwner
	{
		 get { } //Length: 150
	}

	public override bool IsSearchingForGame
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public BindableState LeaderRaidReadyState
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override bool LeaderRaidReadyStatus
	{
		 get { } //Length: 148
	}

	public private bool LimitedServersAvailability
	{
		 get { } //Length: 8
		private set { } //Length: 39
	}

	public override bool LookingForGroupBlocked
	{
		 get { } //Length: 196
	}

	public private override MatchingProgress MatchingProgress
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public DateTime MatchingStartTime
	{
		 get { } //Length: 30
	}

	public private EMatchingStatus MatchingStatus
	{
		 get { } //Length: 7
		private set { } //Length: 39
	}

	public override int MaxGroupPlayersCount
	{
		 get { } //Length: 45
	}

	private int MaxLobbyGroupPlayerCount
	{
		private get { } //Length: 85
	}

	public override GroupPlayer MyPlayer
	{
		 get { } //Length: 8
	}

	public UpdatableBindableList RaidReadyPlayers
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override Location SelectedLocation
	{
		 get { } //Length: 76
	}

	public override BindableList SentInvites
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public abstract bool SupportsLookingForGroup
	{
		 get { } //Length: 0
	}

	public override int TotalReadyGroupPlayers
	{
		 get { } //Length: 519
	}

	protected BaseMatchmakerController`1(IMatchmakerSession session, TRaidSettings raidSettings, SocialNetwork socialNetwork, bool notificationsEnabled) { }

	[CompilerGenerated]
	private void <.ctor>b__175_0(int _, int __) { }

	[CompilerGenerated]
	private void <GetGroupStatus>b__181_0(Result groupStatusResult) { }

	[CompilerGenerated]
	private bool <StartLookingForGroup>b__207_0() { }

	[CompilerGenerated]
	private bool <StopLookingForGroup>b__208_0() { }

	[CompilerGenerated]
	private bool <UpdatePlayers>b__249_0(GroupPlayer x) { }

	private void AcceptInvitation(GroupInvite invite) { }

	[CompilerGenerated]
	public void add_OnActiveInviteCancelled(Action value) { }

	[CompilerGenerated]
	public void add_OnGroupCreated(Action value) { }

	[CompilerGenerated]
	public void add_OnGroupRemoved(Action value) { }

	[CompilerGenerated]
	public void add_OnGroupStatusChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnInviteAccepted(Action value) { }

	[CompilerGenerated]
	public void add_OnInviteInRaidAccepted(Action value) { }

	[CompilerGenerated]
	public void add_OnInviteInRaidReceived(Action value) { }

	[CompilerGenerated]
	public void add_OnInviteInRaidShow(Action value) { }

	[CompilerGenerated]
	public void add_OnInviteReceived(Action value) { }

	[CompilerGenerated]
	public void add_OnLimitedServersAvailability(Action value) { }

	[CompilerGenerated]
	public void add_OnLookingForGroupStatusChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnMatchingAbortReceived(Action value) { }

	[CompilerGenerated]
	public void add_OnMatchingAvailabilityChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnMatchingTypeUpdate(Action value) { }

	[CompilerGenerated]
	public override void add_OnPlayerContextRequest(Action value) { }

	[CompilerGenerated]
	public void add_OnPreTransferLeadership(Action value) { }

	[CompilerGenerated]
	public override void add_OnRaidReadyStatusChanged(Action value) { }

	private void AddPlayerToGroup(RaidPlayer player) { }

	private void AddSentInvite(GroupInvite invite) { }

	private void ApplicationQuittingHandler() { }

	protected void ApplyRaidSettings(TRaidSettings raidSettings) { }

	private bool CanAcceptInvite(string fromAid) { }

	public override void CancelInvite(string playerAid, Action callback) { }

	public override bool CanReportPlayer(string accountId, EReportType reportType) { }

	private void ChangeLeader(string playerAid) { }

	[AsyncStateMachine(typeof(<CheckActiveInvites>d__187))]
	private Task CheckActiveInvites() { }

	private void CheckAndDeclineInvitation(GroupInvite invite) { }

	private void CheckAvailability() { }

	private void ClearInvites() { }

	private void ClearSentInvites() { }

	public override void CreateGroupForSoloPlayer() { }

	private void CreateRaidGroup(Action callback = null) { }

	private void CreateRaidPlayer(Profile mainProfile, Profile profileOfPet) { }

	protected abstract PlayerInfo CreateRaidPlayerInfo(Profile mainProfile, Profile profileOfPet) { }

	private void DeclineInvitation(GroupInvite invite) { }

	public override void DisbandGroup(Action callback = null) { }

	private void DisplayGroupLimitExceededNotification() { }

	public void Dispose() { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__257))]
	protected override Task DisposeAsync() { }

	private bool ExceedsGroupLimit() { }

	[AsyncStateMachine(typeof(<ExitFromMatchMaker>d__219))]
	public Task ExitFromMatchMaker() { }

	public GroupInvite get_ActiveInvite() { }

	private bool get_CanHandleNextInvite() { }

	public bool get_CanHandleRaidInvite() { }

	public bool get_CanShowGroupPreview() { }

	public override bool get_CoopAvailableForGroup() { }

	public override string get_CurrentProfileAid() { }

	public EMatchingType get_CurrentProfileMatchingStatus() { }

	[CompilerGenerated]
	public bool get_Disposed() { }

	[CompilerGenerated]
	public override bool get_Enabled() { }

	[CompilerGenerated]
	public override bool get_EnforceLocationGroupLimit() { }

	public override MatchmakerUpdatableGroup get_Group() { }

	public override string get_GroupId() { }

	public override bool get_GroupIsFull() { }

	[CompilerGenerated]
	public override BindableList get_GroupPlayers() { }

	[CompilerGenerated]
	public override BindableState get_GroupState() { }

	[CompilerGenerated]
	public bool get_GroupStatusSucceed() { }

	[CompilerGenerated]
	public bool get_Initialized() { }

	private bool get_IsInviteBlockedByHideout() { }

	public bool get_IsInvited() { }

	public bool get_IsLeader() { }

	public override bool get_IsLocalGame() { }

	public override bool get_IsLookingForGroup() { }

	public bool get_IsMeInGroup() { }

	public override bool get_IsOwner() { }

	public override bool get_IsSearchingForGame() { }

	[CompilerGenerated]
	public BindableState get_LeaderRaidReadyState() { }

	public override bool get_LeaderRaidReadyStatus() { }

	public bool get_LimitedServersAvailability() { }

	public override bool get_LookingForGroupBlocked() { }

	[CompilerGenerated]
	public override MatchingProgress get_MatchingProgress() { }

	public DateTime get_MatchingStartTime() { }

	public EMatchingStatus get_MatchingStatus() { }

	public override int get_MaxGroupPlayersCount() { }

	private int get_MaxLobbyGroupPlayerCount() { }

	public override GroupPlayer get_MyPlayer() { }

	[CompilerGenerated]
	public UpdatableBindableList get_RaidReadyPlayers() { }

	public override Location get_SelectedLocation() { }

	[CompilerGenerated]
	public override BindableList get_SentInvites() { }

	public abstract bool get_SupportsLookingForGroup() { }

	public override int get_TotalReadyGroupPlayers() { }

	public abstract RaidGroupContextInteractions GetContextInteractions(GroupPlayer player, bool canShowProfile, bool inLobby = false, bool allowFriendPin = false) { }

	public void GetGroupStatus() { }

	public override EMatchingType GetMatchingType(string profileAid) { }

	private RaidPlayer GetPlayerByAid(string profileAid) { }

	public bool GetReadyStatus(string profileAid) { }

	private void GroupDisbanded() { }

	private void GroupLeaderChanged(NotificationLeaderChanged notification) { }

	public bool HasLockedScav(out string playerName, out double farScavTime) { }

	private void InviteCanceled(string playerAid) { }

	private void InviteCanceled(NotificationInviteCanceled notification) { }

	private void InviteExpired(NotificationInviteExpired notification) { }

	private void InviteReceived(NotificationInviteReceived notification) { }

	protected void InvokeOnInviteInRaidReceived() { }

	protected void InvokeOnInviteInRaidShow() { }

	private bool IsEmptyGroup() { }

	public override bool IsInGroup(string profileAid) { }

	public override bool IsInvitedByMe(string playerAid) { }

	private bool IsInviteGroupFull(GroupInvite invite) { }

	private void KickPlayerExceedingGroupLimit(string playerAid) { }

	[AsyncStateMachine(typeof(<LeaveGroup>d__202))]
	public override Task LeaveGroup() { }

	public override void MatchingAbort() { }

	protected override void NotificationReceivedHandler(Notification notification) { }

	public override void OpenPlayerProfile(string accountId) { }

	private void PlayerAcceptInvite(NotificationInviteAccept notification) { }

	private void PlayerDeclineInvite(NotificationInviteDecline notification) { }

	private void PlayerLeftGroup(NotificationGroupLeft notification) { }

	private void PlayerRaidNotReadyHandler(NotificationGroupMatchRaidNotReady notificationGroupMatchRaidNotReady) { }

	private void PlayerRaidReadyHandler(NotificationGroupMatchRaidReady notificationGroupMatchRaidReady) { }

	private void RaidReadyStatusHandler(RaidPlayer _, bool __) { }

	public void RefreshGroupStatus(bool force = false) { }

	[CompilerGenerated]
	public void remove_OnActiveInviteCancelled(Action value) { }

	[CompilerGenerated]
	public void remove_OnGroupCreated(Action value) { }

	[CompilerGenerated]
	public void remove_OnGroupRemoved(Action value) { }

	[CompilerGenerated]
	public void remove_OnGroupStatusChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnInviteAccepted(Action value) { }

	[CompilerGenerated]
	public void remove_OnInviteInRaidAccepted(Action value) { }

	[CompilerGenerated]
	public void remove_OnInviteInRaidReceived(Action value) { }

	[CompilerGenerated]
	public void remove_OnInviteInRaidShow(Action value) { }

	[CompilerGenerated]
	public void remove_OnInviteReceived(Action value) { }

	[CompilerGenerated]
	public void remove_OnLimitedServersAvailability(Action value) { }

	[CompilerGenerated]
	public void remove_OnLookingForGroupStatusChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnMatchingAbortReceived(Action value) { }

	[CompilerGenerated]
	public void remove_OnMatchingAvailabilityChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_OnMatchingTypeUpdate(Action value) { }

	[CompilerGenerated]
	public override void remove_OnPlayerContextRequest(Action value) { }

	[CompilerGenerated]
	public void remove_OnPreTransferLeadership(Action value) { }

	[CompilerGenerated]
	public override void remove_OnRaidReadyStatusChanged(Action value) { }

	private void RemoveGroup(bool revertSettings = true) { }

	private void RemoveInvite(string ownerAid) { }

	public override void RemovePlayerFromGroup(string playerAid, Action callback) { }

	private void RemovePlayerFromGroup(string playerAid) { }

	private void RemoveSentInvite(string playerAid) { }

	public override void ReportNickname(string accountID) { }

	public override void RequestContextMenuForPlayer(RaidPlayer player, Vector2 position, bool allowFriendPin = false) { }

	public void ResetMatchingTimeUI() { }

	public void ResetMaxGroupCount() { }

	private void RevertRaidSettings() { }

	private void SendInvite(RaidPlayer player, bool inLobby, Action callback) { }

	public override void SendInvite(string accountId, bool inLobby, Action callback) { }

	[CompilerGenerated]
	private void set_Disposed(bool value) { }

	[CompilerGenerated]
	public override void set_Enabled(bool value) { }

	[CompilerGenerated]
	public override void set_EnforceLocationGroupLimit(bool value) { }

	private void set_Group(MatchmakerUpdatableGroup value) { }

	[CompilerGenerated]
	private void set_GroupStatusSucceed(bool value) { }

	[CompilerGenerated]
	private void set_Initialized(bool value) { }

	private void set_IsLookingForGroup(bool value) { }

	public void set_IsSearchingForGame(bool value) { }

	private void set_LimitedServersAvailability(bool value) { }

	[CompilerGenerated]
	private void set_MatchingProgress(MatchingProgress value) { }

	private void set_MatchingStatus(EMatchingStatus value) { }

	public void SetCurrentPlayerReadyStatus(bool isReady, Action callback = null) { }

	private void SetReadyRaidStatusCallback(bool status, Action callback) { }

	protected void ShowInteractionWindow(ERaidPlayerButton button, Action acceptAction) { }

	protected abstract DialogWindowContext ShowInviteInGroupWindow(GroupInvite groupInvite) { }

	protected override void ShowInviteInRaidWindow() { }

	public void StartGame() { }

	[AsyncStateMachine(typeof(<StartLookingForGroup>d__207))]
	public override Task StartLookingForGroup() { }

	public override void StartSearchingForGame() { }

	[AsyncStateMachine(typeof(<StopLookingForGroup>d__208))]
	public override Task StopLookingForGroup() { }

	public override void TransferLeadership(string newLeaderAid, Action callback) { }

	public void UpdateMatchmakerSettings() { }

	public void UpdateMaxGroupCount() { }

	private void UpdatePlayers(GroupPlayer[] players) { }

	public Task UpdateStatus() { }

	private void UpdateStatus(Action callback) { }

}

