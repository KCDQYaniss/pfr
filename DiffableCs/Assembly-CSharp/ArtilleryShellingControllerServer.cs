//Type is in global namespace

public class ArtilleryShellingControllerServer : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__58_0; //Field offset: 0x8
		public static Func <>9__58_1; //Field offset: 0x10
		public static Func <>9__67_0; //Field offset: 0x18
		public static Func <>9__90_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal float <GetRandomShellingZones>b__90_0(ArtilleryShellingZone x) { }

		internal bool <Init>b__58_0(ArtilleryShellingZone x) { }

		internal bool <Init>b__58_1(ArtilleryShellingZone x) { }

		internal bool <StartShellingPosition>b__67_0(ArtilleryShellingZone x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public string zoneId; //Field offset: 0x10

		public <>c__DisplayClass68_0() { }

		internal bool <StartImmediateShellingZone>b__0(ArtilleryShellingZone x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public ZoneShellingProcess process; //Field offset: 0x10

		public <>c__DisplayClass86_0() { }

		internal bool <Shot>b__0(ArtilleryBrigade x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass99_0
	{
		public ArtilleryProjectileServer serverProjectile; //Field offset: 0x10

		public <>c__DisplayClass99_0() { }

		internal bool <PushExplosionEvents>b__0(ArtilleryShellingZone x) { }

		internal bool <PushExplosionEvents>b__1(KeyValuePair x) { }

		internal bool <PushExplosionEvents>b__2(ArtilleryShellingZone x) { }

		internal bool <PushExplosionEvents>b__3(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private struct <Init>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArtilleryShellingControllerServer <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitAirdrop>d__103 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int time; //Field offset: 0x20
		public ArtilleryShellingControllerServer <>4__this; //Field offset: 0x28
		public Vector3 position; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <ShellingZones>d__91 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ArtilleryShellingZone <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0xA0
		public ArtilleryShellingControllerServer <>4__this; //Field offset: 0xA8
		private Enumerator <>7__wrap1; //Field offset: 0xB0

		private override ArtilleryShellingZone System.Collections.Generic.IEnumerator<CommonAssets.Scripts.ArtilleryShelling.ArtilleryShellingZone>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 86
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 169
		}

		[DebuggerHidden]
		public <ShellingZones>d__91(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<CommonAssets.Scripts.ArtilleryShelling.ArtilleryShellingZone>.GetEnumerator() { }

		[DebuggerHidden]
		private override ArtilleryShellingZone System.Collections.Generic.IEnumerator<CommonAssets.Scripts.ArtilleryShelling.ArtilleryShellingZone>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <StartEventShelling>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArtilleryShellingControllerServer <>4__this; //Field offset: 0x20
		public ArtilleryShellingZone zone; //Field offset: 0x28
		public float initShellingTime; //Field offset: 0xB0
		private ZoneEventShellingProcess <zoneProcess>5__2; //Field offset: 0xB8
		private YieldAwaiter <>u__1; //Field offset: 0xC0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartPlanedShelling>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArtilleryShellingControllerServer <>4__this; //Field offset: 0x20
		public float secondsDelay; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly IEnumerable _yourItemTypeSlots; //Field offset: 0x0
	private const float TEST_POINT_DISTANCE = 1000; //Field offset: 0x0
	private const float TEST_GEOMETRY_HEIGHT = 300; //Field offset: 0x0
	private const int START_POOL_CAPACITY = 10; //Field offset: 0x0
	private ArtilleryShellingGlobalSettings _artilleryShellingGlobalsSettings; //Field offset: 0x10
	private ArtilleryShellingMapConfiguration _currentMapConfiguration; //Field offset: 0x18
	private List _allBrigades; //Field offset: 0x58
	private ArtilleryBrigade _currentBrigade; //Field offset: 0x60
	private Dictionary _zonesInCurrentShelling; //Field offset: 0x70
	private Dictionary _newZonesInCurrentShelling; //Field offset: 0x78
	private Dictionary _zonesInEventShelling; //Field offset: 0x80
	private List _selectedShellingZones; //Field offset: 0x88
	private List _zonesBuffer; //Field offset: 0x90
	private List _shellingZonesToAdd; //Field offset: 0x98
	private List _shellingZOnesToRemove; //Field offset: 0xA0
	private List _zonesToPlannedShelling; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <ShellingOn>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private bool <TargetShellingOn>k__BackingField; //Field offset: 0xB1
	[CompilerGenerated]
	private bool <PauseOn>k__BackingField; //Field offset: 0xB2
	protected bool _offlineMode; //Field offset: 0xB3
	private GameWorld _gameWorld; //Field offset: 0xB8
	private ArtilleryServerProjectilesPool _projectilesPool; //Field offset: 0xC0
	public DictionaryListHydra ActiveProjectiles; //Field offset: 0xC8
	private float _notifyShellingTimerElapsed; //Field offset: 0xD0
	private int _initAirdropTime; //Field offset: 0xD4
	private Vector3 _airDropPosition; //Field offset: 0xD8
	private float _checkPlacementInShellingZoneTime; //Field offset: 0xE4
	private float _checkPlacementInZoneElapsed; //Field offset: 0xE8
	private bool _needCheckPlayers; //Field offset: 0xEC
	private List _playersIdWitAlarmDevice; //Field offset: 0xF0
	private Queue _notifyZoneShellingMessagesQueue; //Field offset: 0xF8
	private int _finishedShellings; //Field offset: 0x100
	private float _waitStartShellingTimeElapsed; //Field offset: 0x104
	private float _waitStartShellingTimeTarget; //Field offset: 0x108
	private float _waitStartEventShellingTimeElapsed; //Field offset: 0x10C
	private float _waitStartEventShellingTimeTarget; //Field offset: 0x110
	private CancellationTokenSource _initializeCancellationTokenSource; //Field offset: 0x118
	private CancellationToken _initAirdropCancellationTokenSource; //Field offset: 0x120
	private List offlineSyncPackets; //Field offset: 0x128
	private ArtilleryProjectileSyncPacket offlineSyncPacket; //Field offset: 0x130
	private Action _unsubscribeOnDestroy; //Field offset: 0x148
	private MongoID _detectorId; //Field offset: 0x150
	private bool _isShellingFinished; //Field offset: 0x168
	private readonly HashSet _plannedPlayersAlertStateToReset; //Field offset: 0x170
	private readonly HashSet _eventPlayersAlertStateToReset; //Field offset: 0x178

	public ArtilleryShellingMapConfiguration CurrentMapConfiguration
	{
		 get { } //Length: 35
	}

	public static ArtilleryShellingControllerServer Instance
	{
		 get { } //Length: 241
	}

	public private bool PauseOn
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool ShellingOn
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool TargetShellingOn
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private static ArtilleryShellingControllerServer() { }

	public ArtilleryShellingControllerServer() { }

	private void AddNotifyShellingZOneToQueue(string zoneID) { }

	private void ArtilleryProjectileExplosionEvent(ArtilleryProjectileServer serverProjectile) { }

	private void CheckPlayersAlertState(List zonesAndProcesses) { }

	private void CheckPlayersInActiveShellingZone() { }

	public override void Dispose() { }

	private void DynamicAddZonesToShelling(List zonesIdList) { }

	private void DynamicRemoveZonesFromShelling(List zonesIdList) { }

	private void EventShellingProcess() { }

	private Vector3 ExtractPosition(Matrix4x4 matrix) { }

	private void FindShellingPointsByMapGeometryForZone(ref ArtilleryShellingZone zone) { }

	private void FindShellingPointsByMapGeometryForZones(ref List zones) { }

	public ArtilleryShellingMapConfiguration get_CurrentMapConfiguration() { }

	public static ArtilleryShellingControllerServer get_Instance() { }

	[CompilerGenerated]
	public bool get_PauseOn() { }

	[CompilerGenerated]
	public bool get_ShellingOn() { }

	[CompilerGenerated]
	public bool get_TargetShellingOn() { }

	private float GetMaxZoneSide(ArtilleryShellingZone zone) { }

	private ArtilleryBrigade GetNearestBrigade(ArtilleryShellingZone shellingZone) { }

	private List GetRandomShellingPoints(ArtilleryShellingZone zone) { }

	private List GetRandomShellingZones(int zonesToGet, List source) { }

	private void GetRandomShellingZones(int zonesToGet, ref List buffer) { }

	private float GetSafeMaxZoneRadius(float maxLenghtZoneSide) { }

	private bool GetShootFinalPointByGeometry(Vector3 shellingZonePoint, out Vector3 geometryPoint) { }

	public void HandleTrigger(string triggerID) { }

	private bool HasDetector(Player player) { }

	private bool InBounds(Vector3 p, List bounds, Vector3 center) { }

	[AsyncStateMachine(typeof(<Init>d__58))]
	private Task Init(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<InitAirdrop>d__103))]
	public Task InitAirdrop(int time, Vector3 position) { }

	private void InitProjectilesPool(int capacity) { }

	private void NotifyShellingZoneProcess() { }

	private void OfflineExplosionEffectHandle(ArtilleryProjectileServer serverProjectile) { }

	private void OfflineSyncShelling() { }

	private void OnAllProjectilesExploded() { }

	private void OnCheckUnderArtillery() { }

	private void OnFlareSuccessEvent(FlareSuccessEvent flareSuccessEvent) { }

	public void OnUpdate() { }

	private void PlanedShellingProcess() { }

	public void PositionInShellingZoneCheck(Vector3 position, out bool inShellingPos, out string zoneID) { }

	private void PushExplosionEvents(ArtilleryProjectileServer serverProjectile) { }

	public void RegisterArtilleryProjectile(ArtilleryProjectileServer serverProjectile) { }

	private void ResetEventPlayersAlertStateOnShellingStop() { }

	private void ResetPlannedPlayersAlertStateOnShellingStop() { }

	private void ResetPlayerAlertState(List zonesAndProcesses, int playerRaidId) { }

	private void SendPlayersAlertState(int playerRaidId, string zoneId, Vector3 nearestPoint) { }

	[CompilerGenerated]
	private void set_PauseOn(bool value) { }

	[CompilerGenerated]
	private void set_ShellingOn(bool value) { }

	[CompilerGenerated]
	private void set_TargetShellingOn(bool value) { }

	public void SetPauseState(bool pauseOn) { }

	[IteratorStateMachine(typeof(<ShellingZones>d__91))]
	private IEnumerable ShellingZones() { }

	private void Shot(ArtilleryShellingZone zone, ZoneShellingProcess process) { }

	[AsyncStateMachine(typeof(<StartEventShelling>d__70))]
	public Task StartEventShelling(ArtilleryShellingZone zone, float initShellingTime) { }

	public void StartImmediateShellingZone(string zoneId) { }

	[AsyncStateMachine(typeof(<StartPlanedShelling>d__69))]
	private Task StartPlanedShelling(float secondsDelay) { }

	public void StartShellingPosition(Vector3 position) { }

	public void StopShelling() { }

	private void Subscribe() { }

	private void SubscribeEarly() { }

	private bool TryGetPlayerPosition(IPlayer player, out Vector3 position) { }

	private void UnregisterArtilleryProjectile(ArtilleryProjectileServer serverProjectile) { }

	private void Unsubscribe() { }

	private void WriteArtilleryExplosionProjectilePacket(ArtilleryProjectileServer projectileServer) { }

}

