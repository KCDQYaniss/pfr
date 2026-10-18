namespace EFT;

internal class NetworkGameSession : AbstractGameSession, ISession, INetworkGameSession, IAbstractSession, IBattlEyeClientRequestHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__62_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <LoadProfileResources>b__62_1(InitLevelProgress p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public byte[] prefabsData; //Field offset: 0x10
		public byte[] customizationsData; //Field offset: 0x18
		public float time; //Field offset: 0x20
		public NetworkGameSession <>4__this; //Field offset: 0x28
		public int id; //Field offset: 0x30

		public <>c__DisplayClass62_0() { }

		internal void <LoadProfileResources>b__0(float p) { }

		internal ResourceKey[] <LoadProfileResources>b__2() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__Unload; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <CompletePostRaidConnection>d__126 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NetworkGameSession <>4__this; //Field offset: 0x20

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
		public <CompletePostRaidConnection>d__126(int <>1__state) { }

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
	private struct <ExecuteWorldSpawn>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NetworkGameSession <>4__this; //Field offset: 0x20
		public NetworkMessage message; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadProfileResources>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public byte[] prefabsData; //Field offset: 0x20
		public byte[] customizationsData; //Field offset: 0x28
		public NetworkGameSession <>4__this; //Field offset: 0x30
		public int id; //Field offset: 0x38
		private <>c__DisplayClass62_0 <>8__1; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAcceptResponse>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AcceptResponse response; //Field offset: 0x20
		public NetworkGameSession <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class AnticheatLogger : AbstractLogger
	{

		internal AnticheatLogger() { }

	}

	private sealed class ResourcesLogger : AbstractLogger
	{

		internal ResourcesLogger() { }

	}

	private static float CONNECTION_LAG_STAY_TIME; //Field offset: 0x0
	private static float lastClientServerConnectionLagsTime; //Field offset: 0x4
	private static readonly RangeTrend RANGE_TREND; //Field offset: 0x8
	private static readonly AverageDouble AVERAGE_RANGE_TREND; //Field offset: 0x10
	private static double _rtt; //Field offset: 0x18
	[CompilerGenerated]
	private static int <LossPercent>k__BackingField; //Field offset: 0x20
	private AbstractLogger _logger; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnStatusChanged; //Field offset: 0x50
	private INetworkGame _game; //Field offset: 0x58
	private ResourcesLogger _resourcesLogger; //Field offset: 0x60
	private DateTime _syncDateTime; //Field offset: 0x68
	private readonly TimeSpan _syncTimeSpan; //Field offset: 0x70
	private readonly Dictionary _preloads; //Field offset: 0x78
	private readonly CompositeDisposable _unsubscriber; //Field offset: 0x80
	private ConnectionClient _connectionClient; //Field offset: 0x88
	private Action _onConnected; //Field offset: 0x90
	private int _beClientStopRequested; //Field offset: 0x98
	private bool _postRaid; //Field offset: 0x9C
	private bool _gameOverSaveStatusReceived; //Field offset: 0x9D
	private float _postRaidDisconnectAt; //Field offset: 0xA0
	private Coroutine _postRaidDisconnectCoroutine; //Field offset: 0xA8
	private bool _postRaidShutdownStarted; //Field offset: 0xB0
	private bool _postRaidShutdownCompleted; //Field offset: 0xB1
	[CompilerGenerated]
	private int <OpenEncryptionKeyLength>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	private bool <ObserveOnly>k__BackingField; //Field offset: 0xB8
	private readonly NetworkReader _networkReader; //Field offset: 0xC0
	[CompilerGenerated]
	private byte[] <OpenEncryptionKey>k__BackingField; //Field offset: 0xC8

	public event Action OnStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public static bool ClientServerConnectionLags
	{
		 get { } //Length: 165
		 set { } //Length: 158
	}

	public private static int LossPercent
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		private set { } //Length: 88
	}

	public private override bool ObserveOnly
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private byte[] OpenEncryptionKey
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int OpenEncryptionKeyLength
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private static double Rtt
	{
		 get { } //Length: 85
		private set { } //Length: 513
	}

	private static NetworkGameSession() { }

	public NetworkGameSession() { }

	[CompilerGenerated]
	private void <EFT.ConnectionClient.ISession.OnDisconnect>b__50_0() { }

	[CompilerGenerated]
	private void <ObserverDespawn>b__117_0(Result result) { }

	[CompilerGenerated]
	private void <PlayerSpawn>b__115_0(Result result) { }

	[CompilerGenerated]
	public void add_OnStatusChanged(Action value) { }

	private override void BattlEye.IBattlEyeClientRequestHandler.OnRequestRestart(ERestartReason reason) { }

	private override void BattlEye.IBattlEyeClientRequestHandler.OnSendPacket(byte[] bePacket, int packetOffset, int packetLength) { }

	private void CmdConfirmQuestTemplates(string playerProfileId, string error) { }

	private void CmdDisconnectAcceptedOnClient() { }

	private void CmdGameStarted() { }

	private void CmdGetRadiotransmitterData(string playerProfileID) { }

	private void CmdGetTraderServicesData(string playerProfileID, string traderId) { }

	private void CmdOnPlayerKeeperStatisticsChanged(string playerProfileID, string statisticsType, int valueToSet) { }

	private void CmdPlayerEffectsPause(string playerProfileID, bool isPaused) { }

	private void CmdReportVoipAbuse() { }

	private void CmdRespawn() { }

	private void CmdRestartGame() { }

	private void CmdRestartGameInitiate() { }

	private void CmdSpawn() { }

	private void CmdSpawnConfirm(int playerId) { }

	private void CmdStartGame() { }

	private void CmdStartGameAfterTeleport() { }

	private void CmdStopGame() { }

	private void CmdSyncGameTime() { }

	private void CmdWorldSpawnConfirm() { }

	[IteratorStateMachine(typeof(<CompletePostRaidConnection>d__126))]
	private IEnumerator CompletePostRaidConnection() { }

	private void CompletePostRaidNetworkShutdown() { }

	internal static NetworkGameSession Create(INetworkGame game, string profileId, string token, AbstractLogger logger, Action onConnected = null) { }

	private override void EFT.ConnectionClient.ISession.OnConnect(NetworkConnection connection) { }

	private override void EFT.ConnectionClient.ISession.OnDisconnect(NetworkConnection connection) { }

	private override void EFT.INetworkGameSession.CmdConfirmQuestTemplates(string playerProfileId, string error) { }

	private override void EFT.INetworkGameSession.CmdGetRadiotransmitterData(string playerProfileID) { }

	private override void EFT.INetworkGameSession.CmdGetTraderServicesData(string playerProfileID, string traderId) { }

	private override void EFT.INetworkGameSession.GameStarted() { }

	private override void EFT.INetworkGameSession.OnPlayerNpcStatisticsChanged(string playerProfileID, string statisticsType, int valueToSet) { }

	private override void EFT.INetworkGameSession.PlayerEffectsPause(string playerProfileID, bool isPaused) { }

	private override void EFT.INetworkGameSession.PrepareForPostRaid(float disconnectDelay) { }

	private override void EFT.INetworkGameSession.ReportVoipAbuse() { }

	private override void EFT.INetworkGameSession.Respawn() { }

	private override void EFT.INetworkGameSession.RestartGame() { }

	private override void EFT.INetworkGameSession.RestartGameInitiate() { }

	private override void EFT.INetworkGameSession.Spawn() { }

	private override void EFT.INetworkGameSession.StartGame() { }

	private override void EFT.INetworkGameSession.StartGameAfterTeleport() { }

	private override void EFT.INetworkGameSession.StopGame() { }

	[AsyncStateMachine(typeof(<ExecuteWorldSpawn>d__76))]
	private Task ExecuteWorldSpawn(NetworkMessage message) { }

	private void FixedUpdate() { }

	public static bool get_ClientServerConnectionLags() { }

	[CompilerGenerated]
	public static int get_LossPercent() { }

	[CompilerGenerated]
	public override bool get_ObserveOnly() { }

	[CompilerGenerated]
	public byte[] get_OpenEncryptionKey() { }

	[CompilerGenerated]
	public int get_OpenEncryptionKeyLength() { }

	public static double get_Rtt() { }

	[AsyncStateMachine(typeof(<LoadProfileResources>d__62))]
	private Task LoadProfileResources(int id, byte[] prefabsData, byte[] customizationsData) { }

	private void ObserverDespawn(NetworkMessage message) { }

	private void OnAcceptReject(NetworkMessage message) { }

	private void OnAcceptResponse(NetworkMessage message) { }

	[AsyncStateMachine(typeof(<OnAcceptResponse>d__56))]
	private Task OnAcceptResponse(AcceptResponse response) { }

	private void OnAnticheatPacket(NetworkMessage netMsg) { }

	protected virtual void OnDestroy() { }

	private void OnLoadProfileResources(NetworkMessage message) { }

	private void OnNeedToSendSpawnCmdToServerEvent(OnNeedToSendSpawnCmdToServerEvent invokedEvent) { }

	private void OnPlayerEffectsPauseEvent(ClientPlayerEffectsPauseEvent invokedEvent) { }

	private void OnTotalProgressReport(NetworkMessage message) { }

	private void PlayerSpawn(NetworkMessage message) { }

	private void PlayerSpawnProfileChunk(NetworkMessage message) { }

	private void ReceiveVolumetricSystemInitialState(NetworkMessage message) { }

	private void ReceiveWorldSyncAbles(NetworkMessage message) { }

	private void RegisterHandler() { }

	[CompilerGenerated]
	public void remove_OnStatusChanged(Action value) { }

	private void ReportProgress(int id, float progressValue) { }

	private void RpcAirdropContainerData(NetworkMessage networkMessage) { }

	private void RpcBufferZoneData(NetworkMessage networkMessage) { }

	private void RpcCreateCorpse(NetworkMessage networkMessage) { }

	private void RpcGameMatching(NetworkMessage networkMessage) { }

	private void RpcGameOverSaveStatus(NetworkMessage networkMessage) { }

	private void RpcGameRestarted(NetworkMessage networkMessage) { }

	private void RpcGameRestarting(NetworkMessage networkMessage) { }

	private void RpcGameSpawned(NetworkMessage networkMessage) { }

	private void RpcGameStarted(NetworkMessage networkMessage) { }

	private void RpcGameStarting(NetworkMessage networkMessage) { }

	private void RpcGameStartingWithTeleport(NetworkMessage networkMessage) { }

	private void RpcGameStopped(NetworkMessage networkMessage) { }

	private void RpcGameStopping(NetworkMessage networkMessage) { }

	private void RpcGetNewQuestTemplates(NetworkMessage networkMessage) { }

	private void RpcMineDirectionExplosion(NetworkMessage networkMessage) { }

	private void RpcRaidDialogEntryOccupancySync(NetworkMessage networkMessage) { }

	private void RpcRecieveSyncWeaponData(NetworkMessage networkMessage) { }

	private void RpcSendClientRadioTransmitterData(NetworkMessage networkMessage) { }

	private void RpcSendCompletedAchievementsData(NetworkMessage networkMessage) { }

	private void RpcSendLeftHandData(NetworkMessage networkMessage) { }

	private void RpcSendObserverRadioTransmitterData(NetworkMessage networkMessage) { }

	private void RpcSendTraderServicesData(NetworkMessage networkMessage) { }

	private void RpcSoftStopNotification(NetworkMessage networkMessage) { }

	private void RpcStartAuthority(NetworkMessage networkMessage) { }

	private void RpcStartDisconnectionProcedure(NetworkMessage networkMessage) { }

	private void RpcSuccessAirdropFlareEvent(NetworkMessage networkMessage) { }

	private void RpcSyncGameTime(NetworkMessage networkMessage) { }

	private void RpcSyncLighthouseTraderZoneData(NetworkMessage networkMessage) { }

	private void RpcVoipAbuseNotification(NetworkMessage networkMessage) { }

	internal void Run(NetworkConnectConfiguration configuration, string address, int port) { }

	private void SendAcceptRequest() { }

	public static void set_ClientServerConnectionLags(bool value) { }

	[CompilerGenerated]
	private static void set_LossPercent(int value) { }

	[CompilerGenerated]
	private void set_ObserveOnly(bool value) { }

	[CompilerGenerated]
	private void set_OpenEncryptionKey(byte[] value) { }

	[CompilerGenerated]
	private void set_OpenEncryptionKeyLength(int value) { }

	private static void set_Rtt(double value) { }

	private void ShutdownPostRaidNetwork() { }

	private void StartBEAnticheat(string serverIp) { }

	private void StopBEClientOnce() { }

	private void TryCompletePostRaidConnection() { }

	private void Update() { }

	private void WorldSpawn(NetworkMessage message) { }

}

