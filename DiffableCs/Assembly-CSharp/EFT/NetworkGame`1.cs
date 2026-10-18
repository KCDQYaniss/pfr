namespace EFT;

internal abstract class NetworkGame`1 : AbstractGame, INetworkGame, IFrameIndexer, IClientHearingTable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__80_0; //Field offset: 0x0
		public static Action <>9__136_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MongoID <EFT.INetworkGame.Run>b__80_0(string x) { }

		internal void <GameRestarting>b__136_0(SmallPhysicsObject x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass100_0
	{
		public NetworkGame <>4__this; //Field offset: 0x0
		public Callback callback; //Field offset: 0x0
		public int id; //Field offset: 0x0

		public <>c__DisplayClass100_0() { }

		internal void <EFT.INetworkGame.PlayerSpawn>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass115_0
	{
		public ExfiltrationPoint point; //Field offset: 0x0
		public NetworkGame <>4__this; //Field offset: 0x0

		public <>c__DisplayClass115_0() { }

		internal void <GameStartingAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass115_1
	{
		public SecretExfiltrationPoint point; //Field offset: 0x0
		public NetworkGame <>4__this; //Field offset: 0x0

		public <>c__DisplayClass115_1() { }

		internal void <GameStartingAsync>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass139_0
	{
		public Vector3 minePosition; //Field offset: 0x0

		public <>c__DisplayClass139_0() { }

		internal bool <ParseMineExplosionData>b__0(MineDirectional mine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass164_0
	{
		public NetworkGame <>4__this; //Field offset: 0x0
		public bool complete; //Field offset: 0x0

		public <>c__DisplayClass164_0() { }

		internal void <FadeOutCoroutine>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass166_0
	{
		public bool complete; //Field offset: 0x0
		public ErrorWindowContext context; //Field offset: 0x0

		public <>c__DisplayClass166_0() { }

		internal void <ErrorShowCoroutine>g__CloseHandler|1() { }

		internal void <ErrorShowCoroutine>g__Continue|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public PlayerLoopSystem[] originalSubsystems; //Field offset: 0x0
		public PlayerLoopSystem parent; //Field offset: 0x0
		public PlayerLoopSystem currentLoop; //Field offset: 0x0

		public <>c__DisplayClass80_0() { }

		internal void <EFT.INetworkGame.Run>b__2() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static UpdateFunction <0>__CustomUpdate; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <EFT-INetworkGame-GameSpawned>d__108 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public NetworkGame <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EFT-INetworkGame-Run>d__80 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		private SoundSettingsController <soundController>5__4; //Field offset: 0x0
		private GlobalConfiguration <globalSettings>5__3; //Field offset: 0x0
		private bool <shouldForceMode>5__2; //Field offset: 0x0
		public IDictionary interactables; //Field offset: 0x0
		public bool snowWetRendererDisabled; //Field offset: 0x0
		public SeasonsSettings seasonsSettings; //Field offset: 0x0
		public ESeason season; //Field offset: 0x0
		public WeatherNode[] weathers; //Field offset: 0x0
		public Config speedLimits; //Field offset: 0x0
		public bool speedLimitsEnabled; //Field offset: 0x0
		public ResourceKey[] prefabs; //Field offset: 0x0
		public string[] customizations; //Field offset: 0x0
		public VoipSettings voipSettings; //Field offset: 0x0
		public float fixedDeltaTime; //Field offset: 0x0
		public GameDateTime gameDateTime; //Field offset: 0x0
		public bool canRespawn; //Field offset: 0x0
		public INetworkGameSession session; //Field offset: 0x0
		public NetworkGame <>4__this; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private OperationAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <ErrorShowCoroutine>d__166 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public string error; //Field offset: 0x0
		private <>c__DisplayClass166_0 <>8__1; //Field offset: 0x0
		private Token <>7__wrap1; //Field offset: 0x0

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
		public <ErrorShowCoroutine>d__166(int <>1__state) { }

		private void <>m__Finally1() { }

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
	private sealed class <FadeOutCoroutine>d__164 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public NetworkGame <>4__this; //Field offset: 0x0
		private <>c__DisplayClass164_0 <>8__1; //Field offset: 0x0
		private Token <>7__wrap1; //Field offset: 0x0
		private float <time>5__3; //Field offset: 0x0

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
		public <FadeOutCoroutine>d__164(int <>1__state) { }

		private void <>m__Finally1() { }

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
	private struct <GameStartingAsync>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public NetworkGame <>4__this; //Field offset: 0x0
		public float pastTime; //Field offset: 0x0
		public int sessionSeconds; //Field offset: 0x0
		private YieldAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessPlayerSpawnProfileChunk>d__122 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public NetworkGame <>4__this; //Field offset: 0x0
		public NetworkMessage networkMessage; //Field offset: 0x0
		private ChunkedProfileSpawnParameters <pending>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessVolumetricInitialStateChunk>d__125 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public NetworkMessage networkMessage; //Field offset: 0x0
		public NetworkGame <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <RestartGameCoroutine>d__132 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public NetworkGame <>4__this; //Field offset: 0x0

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
		public <RestartGameCoroutine>d__132(int <>1__state) { }

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
	private sealed class <StopCoroutine>d__148 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public NetworkGame <>4__this; //Field offset: 0x0
		private bool <isCutscenePlay>5__2; //Field offset: 0x0
		private Token <>7__wrap2; //Field offset: 0x0
		private float <stopTime>5__4; //Field offset: 0x0
		private ClientMetrics <clientMetrics>5__5; //Field offset: 0x0
		private Result <result>5__6; //Field offset: 0x0
		private IDisposable <>7__wrap6; //Field offset: 0x0
		private Token <>7__wrap7; //Field offset: 0x0
		private ExitStatus <exitStatus>5__9; //Field offset: 0x0
		private Task <sessionEndTask>5__10; //Field offset: 0x0

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
		public <StopCoroutine>d__148(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private void <>m__Finally4() { }

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

	private class CustomUpdateTextureStreamingManager
	{

		public CustomUpdateTextureStreamingManager() { }

	}

	private float _lastSpawnTime; //Field offset: 0x0
	protected ClientMetricsCollector _metricsCollector; //Field offset: 0x0
	protected ClientMetricsEvents _metricsEvents; //Field offset: 0x0
	protected AirdropDataReceiver _airdropDataReceiver; //Field offset: 0x0
	protected InRaidSpectatorController _inRaidSpectatorController; //Field offset: 0x0
	protected INetworkGameSession _session; //Field offset: 0x0
	[CanBeNull]
	protected ReleaseProfilerSpikeAnalyser _releaseProfilerSpikeAnalyser; //Field offset: 0x0
	[CanBeNull]
	protected ObservedPlayerMessageReceiver _observedPlayerMessageReceiver; //Field offset: 0x0
	private readonly IBitReaderStream _dataReader; //Field offset: 0x0
	private VehicleMessageReceiver _vehicleMessageReceiver; //Field offset: 0x0
	[CompilerGenerated]
	private GameDateTime <GameDateTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ulong <LocalIndex>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private float <LocalTime>k__BackingField; //Field offset: 0x0
	private DisconnectionReason _disconnectionReason; //Field offset: 0x0
	protected readonly CancellationTokenSource _stopTokenSource; //Field offset: 0x0
	private Nullable _result; //Field offset: 0x0
	private uint _maxDiffDateTime; //Field offset: 0x0
	private DateTime _lastFixedUpdate; //Field offset: 0x0
	private DateTime _lastUpdate; //Field offset: 0x0
	private DateTime _lastLateUpdate; //Field offset: 0x0
	private string _lifecycleLogFormat; //Field offset: 0x0
	private ChunkedProfileSpawnParameters _pendingChunkedProfileSpawn; //Field offset: 0x0
	protected IClientSession _backEndSession; //Field offset: 0x0
	private byte[] _playerSpawnProfileChunkBuffer; //Field offset: 0x0
	protected GameUI _gameUI; //Field offset: 0x0
	protected BufferZoneDataReciever _bufferZoneDataReciever; //Field offset: 0x0
	protected VoipSettings _voipSettings; //Field offset: 0x0
	private float _sqrVoipDistance; //Field offset: 0x0
	private Action _unsubscribeOnDestroy; //Field offset: 0x0
	protected readonly Dictionary _players; //Field offset: 0x0
	protected ObservedPlayerControllers _observedPlayerControllers; //Field offset: 0x0
	protected ClientWorld _clientWorld; //Field offset: 0x0
	protected ClientGameWorld _gameWorld; //Field offset: 0x0
	protected Action _runCallback; //Field offset: 0x0
	protected Callback _callback; //Field offset: 0x0
	protected Action _restoreSubSystemsAction; //Field offset: 0x0
	private Coroutine _stopCoroutine; //Field offset: 0x0
	protected Location _location; //Field offset: 0x0
	protected InsuranceCompany _insurance; //Field offset: 0x0
	protected bool _canRespawn; //Field offset: 0x0
	protected ClientPlayer _clientPlayer; //Field offset: 0x0
	protected TPlayerOwner _playerOwner; //Field offset: 0x0
	protected ESideType _menuSideType; //Field offset: 0x0
	protected ERaidMode _raidMode; //Field offset: 0x0
	protected ProfileStatus _profileStatus; //Field offset: 0x0
	protected Profile _playerProfile; //Field offset: 0x0
	protected Profile _savageProfile; //Field offset: 0x0
	protected IInputTree _inputTree; //Field offset: 0x0
	private byte[] _volumetricInitialStateZipBuffer; //Field offset: 0x0

	public override IClientSession BackEndSession
	{
		 get { } //Length: 8
	}

	public string ClientProfileId
	{
		 get { } //Length: 288
	}

	public private override GameDateTime GameDateTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected virtual GameUI GameUi
	{
		 get { } //Length: 8
	}

	public virtual int LastServerFrameId
	{
		 get { } //Length: 29
	}

	public virtual float LastServerTimeStamp
	{
		 get { } //Length: 31
	}

	public override ulong LocalIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public virtual int LocalRaidId
	{
		 get { } //Length: 241
	}

	public private override float LocalTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public virtual string LocationId
	{
		 get { } //Length: 30
	}

	public virtual string LocationObjectId
	{
		 get { } //Length: 30
	}

	protected virtual string ProfileId
	{
		 get { } //Length: 42
	}

	protected virtual int RaidID
	{
		 get { } //Length: 32
	}

	protected Profile SelectedProfile
	{
		 get { } //Length: 25
	}

	public override Transform Transform
	{
		 get { } //Length: 89
	}

	protected NetworkGame`1() { }

	[CompilerGenerated]
	private void <EFT.INetworkGame.Run>b__80_1(InitLevelProgress p) { }

	[CompilerGenerated]
	private void <Go>b__129_0() { }

	[CompilerGenerated]
	private void <Go>b__129_1() { }

	[CompilerGenerated]
	private void <Go>b__129_2() { }

	[CompilerGenerated]
	private void <Go>g__DiedHandler|129_3(EDamageType damageType) { }

	[CompilerGenerated]
	private bool <OnStatusChanged>b__106_0(Player x) { }

	[CompilerGenerated]
	private VolumeInitialStateMessage <ProcessVolumetricInitialStateChunk>b__125_0() { }

	public override void Abort(string error) { }

	public override void AirdropFlareSuccessEvent(bool canSpawnAirdrop) { }

	protected override Task ApplyCoopSetting() { }

	public override void BeginChunkedPlayerSpawnProfile(ClientPlayer player, byte[] messageTail, ChunkedProfileSpawnParameters parameters) { }

	public void BotDespawn(BotOwner bot) { }

	protected override void CallbackOnClientDeserializeInitialState(Player player) { }

	protected abstract void CloseScreensForced() { }

	protected override ClientMetrics CollectMetrics() { }

	public override void ConfirmQuestTemplates(string profileId, string error) { }

	protected override void CreateCamera() { }

	private static void CustomUpdate() { }

	protected void DestroyResources() { }

	public virtual void Dispose() { }

	private override bool Dissonance.Networking.Client.IClientHearingTable.IsHeard() { }

	private override void Dissonance.Networking.Client.IClientHearingTable.ReportAbuse() { }

	[AsyncStateMachine(typeof(<EFT-INetworkGame-GameSpawned>d__108))]
	private override Task EFT.INetworkGame.GameSpawned() { }

	private override void EFT.INetworkGame.PlayerSpawn(NetworkReader reader, Callback callback) { }

	private override void EFT.INetworkGame.ReceiveWorldSyncAbles(NetworkMessage message) { }

	[AsyncStateMachine(typeof(<EFT-INetworkGame-Run>d__80))]
	private override Task EFT.INetworkGame.Run(INetworkGameSession session, bool canRespawn, GameDateTime gameDateTime, IDictionary interactables, ResourceKey[] prefabs, string[] customizations, WeatherNode[] weathers, ESeason season, bool snowWetRendererDisabled, SeasonsSettings seasonsSettings, float fixedDeltaTime, bool speedLimitsEnabled, Config speedLimits, VoipSettings voipSettings) { }

	private override Task EFT.INetworkGame.WorldSpawn(NetworkMessage message) { }

	private override void EFT.INetworkGame.WorldSpawnLoot(NetworkMessage message) { }

	[IteratorStateMachine(typeof(<ErrorShowCoroutine>d__166))]
	private IEnumerator ErrorShowCoroutine(string error) { }

	[IteratorStateMachine(typeof(<FadeOutCoroutine>d__164))]
	protected override IEnumerator FadeOutCoroutine() { }

	private void FailChunkedPlayerSpawnProfile(string error) { }

	protected virtual void FixedUpdate() { }

	public override void GameMatching(float playersReady, float playersToWait, float secondsLeftToStart, float maxWaitSeconds) { }

	public override void GameOverSaveStatus(RpcGameOverSaveStatusMessage message) { }

	public override void GameRestarted() { }

	public override void GameRestarting() { }

	public override void GameStarted(float pastTime, int sessionSeconds) { }

	public override void GameStarting(int seconds) { }

	[AsyncStateMachine(typeof(<GameStartingAsync>d__115))]
	private Task GameStartingAsync(float pastTime, int sessionSeconds) { }

	public override void GameStartingWithTeleport(Vector3 position, int exfiltrationId, string entryPoint) { }

	public override void GameStopped(ExitStatus exitStatus, TimeSpan playTime) { }

	public override void GameStopping() { }

	public override IClientSession get_BackEndSession() { }

	public string get_ClientProfileId() { }

	[CompilerGenerated]
	public override GameDateTime get_GameDateTime() { }

	protected virtual GameUI get_GameUi() { }

	public virtual int get_LastServerFrameId() { }

	public virtual float get_LastServerTimeStamp() { }

	[CompilerGenerated]
	public override ulong get_LocalIndex() { }

	public virtual int get_LocalRaidId() { }

	[CompilerGenerated]
	public override float get_LocalTime() { }

	public virtual string get_LocationId() { }

	public virtual string get_LocationObjectId() { }

	protected virtual string get_ProfileId() { }

	protected virtual int get_RaidID() { }

	protected Profile get_SelectedProfile() { }

	public override Transform get_Transform() { }

	protected ClientPlayer GetClientPlayer(int id, Vector3 position, int sendRate) { }

	public override void GetNewQuestTemplates(byte[] data) { }

	protected override ObservedPlayerControllerFactory GetPlayersControllerFactory() { }

	public override void GetRadioTransmitterData(string profileID) { }

	public override void GetTraderServicesData(string profileID, string traderId) { }

	protected override void Go() { }

	private void HideGameUIPanels() { }

	private bool IsClientOnlyCutscenesPlay() { }

	protected virtual void LateUpdate() { }

	protected override void ModifyMetabolism(Player player) { }

	protected abstract void NetworkLeaveGame() { }

	public override void ObserverDespawn(NetworkReader reader, Callback callback) { }

	public override void OnDisconnectStatusAccepted(DisconnectionReason disconnectionReason) { }

	private void OnFixedUpdate() { }

	private void OnLateUpdate() { }

	private void OnStatusChanged(ExfiltrationPoint point, EExfiltrationStatus prevStatus) { }

	private void OnUpdate() { }

	public override void ParseAirdropContainerData(byte[] data) { }

	public override void ParseBufferZoneData(byte[] data) { }

	public override void ParseCreateCorpseData(byte[] data) { }

	public override void ParseMineExplosionData(byte[] data) { }

	protected abstract TPlayerOwner PlayerOwnerFactory() { }

	[AsyncStateMachine(typeof(<ProcessPlayerSpawnProfileChunk>d__122))]
	private Task ProcessPlayerSpawnProfileChunk(NetworkMessage networkMessage) { }

	[AsyncStateMachine(typeof(<ProcessVolumetricInitialStateChunk>d__125))]
	private Task ProcessVolumetricInitialStateChunk(NetworkMessage networkMessage) { }

	private void ReceiveChannelDataData(NetworkMessage networkMessage) { }

	public override void ReceiveClientRadioTransmitterData(RadioTransmitterData data) { }

	public override void ReceiveCompletedAchievementsData(CompletedAchievementConditionsData data) { }

	public override void ReceiveLeftHandData(LeftHandData data) { }

	public override void ReceiveLighthouseTraderZoneData(LighthouseTraderZoneData data) { }

	public override void ReceiveObserverRadioTransmitterData(RadioTransmitterData data) { }

	public override void ReceivePlayerSpawnProfileChunk(NetworkMessage networkMessage) { }

	private void ReceivePlayerSynchronization(NetworkMessage networkMessage) { }

	public override void ReceiveRaidDialogEntryOccupancySync(string pointId, int occupantRaidID) { }

	public override void ReceiveTraderServicesData(byte[] packet) { }

	public override void ReceiveVolumetricSystemInitialState(NetworkMessage networkMessage) { }

	private void ReceiveWorldSynchronization(NetworkMessage networkMessage) { }

	public override void RecieveSyncWeaponData(ItemDescriptor weaponDescriptor) { }

	[IteratorStateMachine(typeof(<RestartGameCoroutine>d__132))]
	private IEnumerator RestartGameCoroutine() { }

	protected void RestoreSubSystem() { }

	public override void SendCommonEventData(ArraySegment segment) { }

	private void SendDelegate(NetworkChannel channel, NetworkMessageType messageType, in ArraySegment segment) { }

	[CompilerGenerated]
	private void set_GameDateTime(GameDateTime value) { }

	[CompilerGenerated]
	public override void set_LocalIndex(ulong value) { }

	[CompilerGenerated]
	private void set_LocalTime(float value) { }

	protected abstract void ShowFinalCountdownScreen(int seconds) { }

	public override void SoftStopNotification(TimeSpan sessionTime) { }

	public override void Spawn() { }

	public void StartGameTimerEventHandler(StartGameTimerEvent eventData) { }

	public override void Stop() { }

	protected override void Stop(Nullable result) { }

	[IteratorStateMachine(typeof(<StopCoroutine>d__148))]
	private IEnumerator StopCoroutine() { }

	private bool TryFindMyPlayer(out ClientPlayer player) { }

	private void Update() { }

	public override void VoipAbuseNotification() { }

}

