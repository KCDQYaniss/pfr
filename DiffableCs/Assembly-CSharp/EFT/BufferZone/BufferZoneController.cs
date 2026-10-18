namespace EFT.BufferZone;

public class BufferZoneController
{
	[CompilerGenerated]
	private struct <Init>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BufferZoneController <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static Action OnInitialized; //Field offset: 0x0
	private bool _inited; //Field offset: 0x10
	private bool _isOfflineMode; //Field offset: 0x11
	private BufferZoneSettings _settings; //Field offset: 0x18
	private BufferZoneContainer _container; //Field offset: 0x20
	private CancellationTokenSource _initializeCancellationTokenSource; //Field offset: 0x28
	private BufferZoneAlreadyHaveCustomerNotification _alreadyHaveCustomers; //Field offset: 0x30
	private BufferGateNotAvailableNotification _gateUnavailable; //Field offset: 0x38
	private BufferZoneAccessDeniedNotification _accessDenied; //Field offset: 0x40
	private BufferZoneUsageTimeEndedNotification _usageTimeEnded; //Field offset: 0x48
	private BufferZoneTimerReminderNotification _timerReminder; //Field offset: 0x50
	private BufferZoneKickAlarmNotification _kickReminder; //Field offset: 0x58

	public static event Action OnInitialized
	{
		[CompilerGenerated]
		 add { } //Length: 266
		[CompilerGenerated]
		 remove { } //Length: 266
	}

	public static BufferZoneController Instance
	{
		 get { } //Length: 238
	}

	public bool IsBufferZoneExists
	{
		 get { } //Length: 203
	}

	public bool IsInnerZoneAvailable
	{
		 get { } //Length: 245
	}

	public BufferZoneSettings Settings
	{
		 get { } //Length: 5
	}

	public BufferZoneController() { }

	[CompilerGenerated]
	public static void add_OnInitialized(Action value) { }

	public void DevResetPlayerUsageTime(Player player) { }

	public void DevSetPlayerAccessLevel(Player player, int levelAccess) { }

	public void Dispose() { }

	public static BufferZoneController get_Instance() { }

	public bool get_IsBufferZoneExists() { }

	public bool get_IsInnerZoneAvailable() { }

	public BufferZoneSettings get_Settings() { }

	public int GetPlayerBufferZoneUsageTimeLeft(int raidID) { }

	public void HandleReconnectedPlayer(bool isInBufferZone, Player player, int bufferZoneUsageTimeLeft, Task onCurrentHandsControllerSpawned) { }

	[AsyncStateMachine(typeof(<Init>d__17))]
	private Task Init(CancellationToken cancellationToken) { }

	public bool IsPlayerCanAccessBufferZone(int raidID, out BufferAccessStatusType receivedAccessStatus) { }

	public bool IsPlayerHaveAccessToInnerZone(int raidID) { }

	private void OnGameTypeSeted(EGameType gameType) { }

	private void OnPlayerAllowStatusChanged(int raidID, bool status) { }

	private void OnPlayerInZoneStatusChanged(int playerRaidID, bool inZone) { }

	private void OnPlayerKilled(Player killedPlayer, IPlayer killer, DamageInfo damageInfo, EBodyPart part) { }

	public void ReadStates(NetworkReader reader) { }

	public void RegisterContainer(BufferZoneContainer container) { }

	[CompilerGenerated]
	public static void remove_OnInitialized(Action value) { }

	public void SetInnerZoneAvailabilityStatus(bool isZoneAvaliable, EBufferZoneData changesDataType) { }

	public void SetPlayerAccessStatus(int raidID, bool status) { }

	public void SetPlayerInZoneStatus(int raidID, bool inZone) { }

	public void ShowAccessDeniedNotification() { }

	public void ShowAlreadyHaveCustomersNotification() { }

	public void ShowGateKickAlarmNotification() { }

	public void ShowGateNotAvailableNotification() { }

	public void ShowTimerRemindNotification() { }

	public void ShowUsageTimeEndedNotification() { }

	public void WriteStates(NetworkWriter writer) { }

}

