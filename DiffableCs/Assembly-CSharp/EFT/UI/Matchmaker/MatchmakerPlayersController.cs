namespace EFT.UI.Matchmaker;

public sealed class MatchmakerPlayersController : BaseMatchmakerController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public OtherPlayerProfileScreenController screenController; //Field offset: 0x10
		public MatchmakerPlayersController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal void <OpenPlayerProfile>g__OnOtherPlayerProfileMoveForward|1(bool moveForward) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public MatchmakerPlayersController <>4__this; //Field offset: 0x10
		public bool abortAvailable; //Field offset: 0x18

		public <>c__DisplayClass36_0() { }

		internal void <SetMatchingAbortAvailability>b__0() { }

	}

	[CompilerGenerated]
	private struct <DisposeAsync>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerPlayersController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnableMatchingAbortAbilityDelayed>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int duration; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public MatchmakerPlayersController <>4__this; //Field offset: 0x30
		private DateTime <endTime>5__2; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetMatchingAbortAvailabilityDelayed>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerPlayersController <>4__this; //Field offset: 0x20
		public EMatchingStage targetStage; //Field offset: 0x28
		public bool abortAvailable; //Field offset: 0x2C
		public Nullable blockAbortAbilityDurationSeconds; //Field offset: 0x30
		public Nullable showAbortConfirmationPopup; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x3A

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IEftSession _eftSession; //Field offset: 0x148
	private Task _matchingAbortAbilityAwaiterTask; //Field offset: 0x150
	private CancellationTokenSource _matchingAbortAbilityAwaiterTaskCtc; //Field offset: 0x158
	private int _estimateTimeForGroupPlayer; //Field offset: 0x160
	[CompilerGenerated]
	private Action OnReadyToStartRaid; //Field offset: 0x168
	[CompilerGenerated]
	private readonly BindableEvent <OnAbortAvailabilityChanged>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private readonly BindableState <IsProcessingReadyButtonPress>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private Action OnInventoryErrorDuringMatching; //Field offset: 0x180

	public event Action OnInventoryErrorDuringMatching
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnReadyToStartRaid
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public virtual bool CoopAvailableForGroup
	{
		 get { } //Length: 141
	}

	public BindableState IsProcessingReadyButtonPress
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool MatchingAbortAvailability
	{
		 get { } //Length: 69
	}

	public BindableEvent OnAbortAvailabilityChanged
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual bool SupportsLookingForGroup
	{
		 get { } //Length: 3
	}

	public MatchmakerPlayersController(IEftSession session, RaidSettings raidSettings, SocialNetwork socialNetwork, bool notificationsEnabled) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[CompilerGenerated]
	private void <OpenPlayerProfile>b__31_0(Task result) { }

	[CompilerGenerated]
	public void add_OnInventoryErrorDuringMatching(Action value) { }

	[CompilerGenerated]
	public void add_OnReadyToStartRaid(Action value) { }

	private bool CheckMyAccessToCoop() { }

	protected virtual PlayerInfo CreateRaidPlayerInfo(Profile mainProfile, Profile profileOfPet) { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__45))]
	protected virtual Task DisposeAsync() { }

	[AsyncStateMachine(typeof(<EnableMatchingAbortAbilityDelayed>d__39))]
	private Task EnableMatchingAbortAbilityDelayed(int duration, CancellationToken token) { }

	public virtual bool get_CoopAvailableForGroup() { }

	[CompilerGenerated]
	public BindableState get_IsProcessingReadyButtonPress() { }

	public bool get_MatchingAbortAvailability() { }

	[CompilerGenerated]
	public BindableEvent get_OnAbortAvailabilityChanged() { }

	public virtual bool get_SupportsLookingForGroup() { }

	public virtual RaidGroupContextInteractions GetContextInteractions(GroupPlayer player, bool canShowProfile, bool inLobby = false, bool allowFriendPin = false) { }

	public bool GetCoopBlockReason(out ECoopBlock reason) { }

	public void InvokeInventoryErrorDuringMatching() { }

	public virtual void MatchingAbort() { }

	protected virtual void NotificationReceivedHandler(Notification notification) { }

	public virtual void OpenPlayerProfile(string accountId) { }

	private void ReceiveMatchingStartNotification(NotificationStartGame notificationStartGame) { }

	private void ReceiveRaidSettings(NotificationMatchRaidSettings notificationMatchRaidSettings) { }

	private void ReceiveUserMatchedNotification(NotificationUserMatched notification, EMatchingStage stage) { }

	[CompilerGenerated]
	public void remove_OnInventoryErrorDuringMatching(Action value) { }

	[CompilerGenerated]
	public void remove_OnReadyToStartRaid(Action value) { }

	private void ReturnToMatchingScreen() { }

	public void SetEstimateTimeForGroupPlayer() { }

	public void SetIsMatchingAbortRequested(bool requested) { }

	public void SetMatchingAbortAvailability(bool abortAvailable, Nullable blockAbortAbilityDurationSeconds = null, Nullable showAbortConfirmationPopup = null) { }

	[AsyncStateMachine(typeof(<SetMatchingAbortAvailabilityDelayed>d__37))]
	private Task SetMatchingAbortAvailabilityDelayed(EMatchingStage targetStage, bool abortAvailable, Nullable blockAbortAbilityDurationSeconds = null, Nullable showAbortConfirmationPopup = null) { }

	public void SetProcessingReadyButtonPress(bool value) { }

	protected virtual DialogWindowContext ShowInviteInGroupWindow(GroupInvite groupInvite) { }

	protected virtual void ShowInviteInRaidWindow() { }

	public virtual void StartSearchingForGame() { }

	public void UpdateMatchingStatus(EMatchingStage stage, Nullable progress = null) { }

}

