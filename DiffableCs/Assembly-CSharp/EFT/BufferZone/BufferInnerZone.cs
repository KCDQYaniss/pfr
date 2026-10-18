namespace EFT.BufferZone;

public class BufferInnerZone : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Callback <>9__60_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SetEmptyHands>b__60_0(Result result) { }

	}

	[CompilerGenerated]
	private struct <AutomaticGatesClosing>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BufferInnerZone <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandlePlayerReconnected>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BufferInnerZone <>4__this; //Field offset: 0x20
		public IPlayer player; //Field offset: 0x28
		public int bufferZoneUsageTimeLeft; //Field offset: 0x30
		public bool isInBufferZone; //Field offset: 0x34
		public Task onCurrentHandsControllerSpawned; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySetLastEquippedWeapon>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IPlayer player; //Field offset: 0x20
		public BufferInnerZone <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int ONE_MINUTE = 60; //Field offset: 0x0
	private const int THREE_MINUTES = 180; //Field offset: 0x0
	private const int MIN_SECONDS_TO_SHOW_TIME_WARNING = 105; //Field offset: 0x0
	[SerializeField]
	private LampController availabilityShowingLamp; //Field offset: 0x20
	[SerializeField]
	private Collider _customerFilterCollider; //Field offset: 0x28
	[SerializeField]
	private PhysicsTriggerHandler enterZoneTriggerHandler; //Field offset: 0x30
	[SerializeField]
	private PhysicsTriggerHandler exitZoneTriggerHandler; //Field offset: 0x38
	[SerializeField]
	private List nearBufferZoneEntranceTriggerHandlers; //Field offset: 0x40
	private readonly BindableList _playersInZone; //Field offset: 0x48
	private readonly BindableList _playersDeadInZone; //Field offset: 0x50
	private Dictionary _remainingUsageTimeByPlayers; //Field offset: 0x58
	private float _usageStartTimeOfCurrentUser; //Field offset: 0x60
	private bool _enterZoneNotificationShowed; //Field offset: 0x64
	private bool _kickSoonNotificationShowed; //Field offset: 0x65
	private bool _threeMinutesEventThrowed; //Field offset: 0x66
	private bool _minSecondsToShowWarningPassed; //Field offset: 0x67
	private BufferOuterBattleZone _outerBattleZone; //Field offset: 0x68
	private BufferGateSwitcher _outerGateSwitcher; //Field offset: 0x70
	private BufferGateSwitcher _innerGateSwitcher; //Field offset: 0x78
	private BufferGates _bufferGates; //Field offset: 0x80
	private CancellationTokenSource _cancellationTokenSourceForAutomaticCloseGates; //Field offset: 0x88
	private Dictionary _playersWithAccess; //Field offset: 0x90
	private Dictionary _playersWithEmptyHandsCommands; //Field offset: 0x98
	[CompilerGenerated]
	private bool <IsZoneAvailableForInteractions>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private Action OnPlayerInZoneStatusChanged; //Field offset: 0xA8

	public event Action OnPlayerInZoneStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public float CurrentPlayerRemainingUsageTime
	{
		 get { } //Length: 75
	}

	public bool HasCustomer
	{
		 get { } //Length: 78
	}

	public private bool IsZoneAvailableForInteractions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public BufferZoneSettings Settings
	{
		 get { } //Length: 30
	}

	public BufferInnerZone() { }

	[CompilerGenerated]
	public void add_OnPlayerInZoneStatusChanged(Action value) { }

	public void AllowCustomerPassFilter(IPlayer iPlayer, bool allow = true) { }

	[AsyncStateMachine(typeof(<AutomaticGatesClosing>d__63))]
	private Task AutomaticGatesClosing(CancellationToken cancellationToken) { }

	private void Awake() { }

	public void ChangePlayerAccessStatus(int raidID, bool status) { }

	public void ChangeZoneInteractionAvailability(bool isAvailable, EBufferZoneData changesDataType) { }

	public float get_CurrentPlayerRemainingUsageTime() { }

	public bool get_HasCustomer() { }

	[CompilerGenerated]
	public bool get_IsZoneAvailableForInteractions() { }

	public BufferZoneSettings get_Settings() { }

	public float GetUserRemainingUsageTime(int playerRaidID) { }

	private void HandleEnterZone(Collider col) { }

	private void HandleExitZone(Collider col) { }

	public void HandlePlayerLeftZoneFromServer(int raidID) { }

	[AsyncStateMachine(typeof(<HandlePlayerReconnected>d__56))]
	public Task HandlePlayerReconnected(bool isInBufferZone, IPlayer player, int bufferZoneUsageTimeLeft, Task onCurrentHandsControllerSpawned) { }

	private bool IsPermittedItemInHands(Player player) { }

	public bool IsPlayerDyingInZone(IPlayer player) { }

	public bool IsPlayerHaveAccess(int raidID) { }

	public bool IsPlayerInZone(IPlayer player) { }

	private void OnDestroy() { }

	private void OnEnterNearEntranceTrigger(Collider col) { }

	private void OnGateStateChagned(WorldInteractiveObject gates, EDoorState stateBefore, EDoorState stateAfter) { }

	private void OnInteractWithSwitch(EInteractionType interactionType, bool isOuterGateSwitcher, IPlayer interactingPlayer) { }

	private void OnPlayerDeadOrUnspawn(IPlayer player) { }

	private void ProcessSoonKickTime() { }

	private void ReduceCurrentCustomerUsageTime() { }

	[CompilerGenerated]
	public void remove_OnPlayerInZoneStatusChanged(Action value) { }

	public void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_IsZoneAvailableForInteractions(bool value) { }

	private void SetEmptyHands(Player player) { }

	public void SetUpReferences(BufferZoneContainer bufferZoneContainer) { }

	private void SetUserRemainingUsageTime(int playerRaidID, float time) { }

	[AsyncStateMachine(typeof(<TrySetLastEquippedWeapon>d__59))]
	private Task TrySetLastEquippedWeapon(IPlayer player) { }

	public void UnallowAllCustomersToPassFilter() { }

	private void Update() { }

}

