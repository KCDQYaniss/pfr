namespace EFT;

public class MatchmakerOperation : Operation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__43_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <Ready>b__43_0(RaidPlayer p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public CancellationToken cancellationToken; //Field offset: 0x10
		public ItemUiContext itemUiContext; //Field offset: 0x18
		public MatchmakerOperation <>4__this; //Field offset: 0x20

		public <>c__DisplayClass42_0() { }

		internal bool <InviteInRaidShow>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public MatchmakerOperation <>4__this; //Field offset: 0x10
		public Item specialSlotItem; //Field offset: 0x18

		public <>c__DisplayClass55_0() { }

		internal bool <TrySelectAccessItem>b__0(Item inventoryItem) { }

	}

	[CompilerGenerated]
	private struct <InviteInRaidHandlerInternal>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InviteInRaidShow>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerOperation <>4__this; //Field offset: 0x28
		private <>c__DisplayClass42_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Ready>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerOperation <>4__this; //Field offset: 0x20
		public bool invokeMatching; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowMatchmakerLocationSelection>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerOperation <>4__this; //Field offset: 0x20
		private SelectionLocationScreenController <selectLocationScreenController>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowMatchmakerSideSelectionInternal>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForMatchmakerInitialization>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerOperation <>4__this; //Field offset: 0x20
		public int timeoutMs; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private float <startTime>5__3; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x3C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string MAP_POINT_PATH = "MapPointConfigs/"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnReadyToStartMatching; //Field offset: 0x38
	private RaidSettings _raidSettings; //Field offset: 0x40
	private RaidSettings _offlineRaidSettings; //Field offset: 0x48
	private IEftSession _session; //Field offset: 0x50
	private Action _reconnectAction; //Field offset: 0x58
	private bool _readyPressed; //Field offset: 0x60
	private bool _allowTransitReady; //Field offset: 0x61
	private readonly AFKMonitor _afkMonitor; //Field offset: 0x68
	private MapPoints _mapPoints; //Field offset: 0x70
	private readonly CompositeDisposable _compositeDisposable; //Field offset: 0x78
	private CancellationTokenSource _readyCts; //Field offset: 0x80
	private readonly OfflineHealthController _healthController; //Field offset: 0x88
	[CompilerGenerated]
	private string <GroupId>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private EMatchingType <MatchingType>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private MatchmakerPlayersController <MatchmakerPlayersController>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private OfflineInventoryController <InventoryController>k__BackingField; //Field offset: 0xA8

	public event Action OnReadyToStartMatching
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private string GroupId
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

	public private EMatchingType MatchingType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private MatchmakerPlayersController MatchmakerPlayersController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public MatchmakerOperation(IEftSession session, RaidSettings raidSettings, OfflineInventoryController inventoryController, OfflineHealthController healthController) { }

	[CompilerGenerated]
	private void <ShowMatchmakerAcceptScreen>b__45_0() { }

	[CompilerGenerated]
	private void <ShowMatchmakerInsuranceScreen>b__44_0() { }

	[CompilerGenerated]
	private void <ShowMatchmakerLocationSelection>b__61_1() { }

	[CompilerGenerated]
	private void <ShowMatchmakerLocationSelection>b__61_2() { }

	[CompilerGenerated]
	private void <ShowMatchmakerLocationSelection>g__UpdateSideSettings|61_0() { }

	[CompilerGenerated]
	private void <ShowMatchmakerMapPointsScreen>g__ShowNextScreen|57_0() { }

	[CompilerGenerated]
	private void <ShowMatchmakerOfflineRaidScreen>b__59_0() { }

	[CompilerGenerated]
	private void <ShowMatchmakerOfflineRaidScreen>b__59_1() { }

	[CompilerGenerated]
	private void <ShowMatchmakerSideSelectionInternal>b__35_0() { }

	[CompilerGenerated]
	public void add_OnReadyToStartMatching(Action value) { }

	private static void AddAccessRequirement(Dictionary accessKeyCount, string keyTemplateId, int requiredCount) { }

	private bool CanShowInsuranceScreen() { }

	private bool CheckScavsForGroup() { }

	private bool CoopModeCheck() { }

	private bool CoopModeCheckForGroup() { }

	[CompilerGenerated]
	public string get_GroupId() { }

	[CompilerGenerated]
	public OfflineInventoryController get_InventoryController() { }

	[CompilerGenerated]
	public EMatchingType get_MatchingType() { }

	[CompilerGenerated]
	public MatchmakerPlayersController get_MatchmakerPlayersController() { }

	public void InviteInRaidHandler() { }

	[AsyncStateMachine(typeof(<InviteInRaidHandlerInternal>d__37))]
	private Task InviteInRaidHandlerInternal() { }

	[AsyncStateMachine(typeof(<InviteInRaidShow>d__42))]
	private void InviteInRaidShow() { }

	private bool ItemsRestrictionCheck() { }

	private bool LocationKeyCheck() { }

	private bool NeedUnloadQuestItems() { }

	private void OnGroupMatchStartNotification() { }

	private void OnReadyPressed() { }

	private void OnSocialInitialized() { }

	[AsyncStateMachine(typeof(<Ready>d__43))]
	private Task Ready(bool invokeMatching = true) { }

	private void RefreshMapPoints() { }

	[CompilerGenerated]
	public void remove_OnReadyToStartMatching(Action value) { }

	private void ResetReadyState() { }

	private bool SelectedLocationGroupSizeCheck() { }

	[CompilerGenerated]
	private void set_GroupId(string value) { }

	[CompilerGenerated]
	private void set_InventoryController(OfflineInventoryController value) { }

	[CompilerGenerated]
	private void set_MatchingType(EMatchingType value) { }

	[CompilerGenerated]
	private void set_MatchmakerPlayersController(MatchmakerPlayersController value) { }

	public void SetNotificationsEnable(bool enable) { }

	private void ShowAccessScreen(IReadOnlyDictionary accessKeyCount) { }

	private void ShowMatchmakerAcceptScreen() { }

	private void ShowMatchmakerInsuranceScreen() { }

	[AsyncStateMachine(typeof(<ShowMatchmakerLocationSelection>d__61))]
	private Task ShowMatchmakerLocationSelection() { }

	private void ShowMatchmakerMapPointsScreen() { }

	private void ShowMatchmakerOfflineRaidScreen() { }

	public void ShowMatchmakerSideSelection() { }

	[AsyncStateMachine(typeof(<ShowMatchmakerSideSelectionInternal>d__35))]
	private Task ShowMatchmakerSideSelectionInternal() { }

	public Task StartTransitMatchingPrepareAsync() { }

	public void StopAfkMonitor() { }

	private bool TryGetAccessToLocation(IReadOnlyDictionary accessKeyCount, Nullable specialSlot, out string keyId) { }

	private Item TrySelectAccessItem(IEnumerable inventoryItems, IReadOnlyDictionary accessKeyCount, Nullable specialSlot) { }

	public void Unsubscribe() { }

	[AsyncStateMachine(typeof(<WaitForMatchmakerInitialization>d__38))]
	private Task WaitForMatchmakerInitialization(int timeoutMs = 0) { }

}

