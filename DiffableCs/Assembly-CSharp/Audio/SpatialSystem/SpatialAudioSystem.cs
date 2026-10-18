namespace Audio.SpatialSystem;

public sealed class SpatialAudioSystem : MonoBehaviourSingleton, IDisposable
{
	[CompilerGenerated]
	private sealed class <CalculateProgressCoroutine>d__61 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Task loadTask; //Field offset: 0x20
		public IProgress progress; //Field offset: 0x28
		public SpatialAudioSystem <>4__this; //Field offset: 0x30

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
		public <CalculateProgressCoroutine>d__61(int <>1__state) { }

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
	private sealed class <ClearPlayerOcclusionWithDelay>d__80 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public IPlayer player; //Field offset: 0x20
		public SpatialAudioSystem <>4__this; //Field offset: 0x28
		private int <playerID>5__2; //Field offset: 0x30
		private SoundOcclusionProcessor <processor>5__3; //Field offset: 0x38

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
		public <ClearPlayerOcclusionWithDelay>d__80(int <>1__state) { }

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
	private struct <Initialize>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpatialAudioSystem <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public IProgress progress; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const uint AVERAGE_PROPAGATION_DEPTH = 4; //Field offset: 0x0
	private const byte MAX_UPDATED_PROCESSORS_PER_FRAME = 1; //Field offset: 0x0
	public SpatialAudioPoolsConfig poolsConfig; //Field offset: 0x20
	public AudioOcclusionSettings OcclusionSettings; //Field offset: 0x28
	[SerializeField]
	private SpatialAudioLocationInfo _locationInfo; //Field offset: 0x30
	private readonly List _activeSoundContainers; //Field offset: 0x38
	private readonly Dictionary _allRegisteredSoundContainers; //Field offset: 0x40
	private readonly List _activeProcessors; //Field offset: 0x48
	private readonly Dictionary _allRegisteredProcessorsByContainerID; //Field offset: 0x50
	private readonly List _outOfRangeProcessors; //Field offset: 0x58
	private SoundOcclusionProcessor _scheduledProcessor; //Field offset: 0x60
	private readonly Dictionary _registeredPlayers; //Field offset: 0x68
	private readonly Dictionary _registeredPlayerContainers; //Field offset: 0x70
	private readonly Dictionary _registeredPlayerProcessors; //Field offset: 0x78
	private readonly Dictionary _registeredGameObjectsProcessors; //Field offset: 0x80
	private readonly Dictionary _registeredGameObjectContainers; //Field offset: 0x88
	private readonly Dictionary _goInstanceIDByContainerID; //Field offset: 0x90
	private readonly Dictionary _deadPlayersCoroutines; //Field offset: 0x98
	private readonly HashSet _pausedPlayerIds; //Field offset: 0xA0
	private readonly Dictionary _pausedProcessorsByContainerID; //Field offset: 0xA8
	private readonly Dictionary _pausedContainers; //Field offset: 0xB0
	private SpatialAudioSystemPoolService _poolService; //Field offset: 0xB8
	private Transform _listenerTransform; //Field offset: 0xC0
	private AudioRoomStorage _audioRoomStorage; //Field offset: 0xC8
	private ISpatialAudioOccluder _fastOccluder; //Field offset: 0xD0
	private int _currentFrameProcessorIndex; //Field offset: 0xD8
	private int _nextProcessorIndexToUpdate; //Field offset: 0xDC
	private AudioSourceContainerData _containerData; //Field offset: 0xE0
	private bool _disposed; //Field offset: 0xE8
	private SpatialAudioDataLoader _dataLoader; //Field offset: 0xF0
	private SpatialAudioOccluder _multiSourceOccluder; //Field offset: 0xF8
	private InteractiveObjectOccluder _interactiveObjectOccluder; //Field offset: 0x100
	private readonly AudioSourcePriorityCalculator priorityCalculator; //Field offset: 0x108
	private ObservedPlayerAudioSourceLimiter _observedPlayerAudioSourceLimiter; //Field offset: 0x110
	private Coroutine _progressCoroutine; //Field offset: 0x118
	private Action _unsubscribeOnDestroy; //Field offset: 0x120
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; //Field offset: 0x128

	private bool CanUpdate
	{
		private get { } //Length: 512
	}

	public private bool Initialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsTemporaryListenerOverrideActive
	{
		 get { } //Length: 28
	}

	public int ListenerCurrentOutdoorRoomID
	{
		 get { } //Length: 32
	}

	public ISpatialAudioRoom ListenerCurrentRoom
	{
		 get { } //Length: 22
	}

	private Transform ListenerTransform
	{
		private get { } //Length: 511
	}

	public SpatialAudioLocationInfo LocationInfo
	{
		 get { } //Length: 76
	}

	public uint PropagationDepth
	{
		 get { } //Length: 256
	}

	public SpatialAudioSystem() { }

	private void ActualizeContainerRoom(AudioSourceContainer sourceContainer) { }

	public void AddPlayerCurrentRoom(SpatialAudioRoom room, IPlayer player) { }

	private void AfterGameStarted() { }

	private void ApplyPausedOcclusion(int playerId, AudioSourceContainer container) { }

	private void ApplySettingsFromBackend() { }

	[IteratorStateMachine(typeof(<CalculateProgressCoroutine>d__61))]
	private IEnumerator CalculateProgressCoroutine(Task loadTask, IProgress progress) { }

	private void CleanOutOfRangeProcessors() { }

	private static void ClearContainerOcclusionState(AudioSourceContainer container) { }

	private void ClearGoComponents(int containerID) { }

	[IteratorStateMachine(typeof(<ClearPlayerOcclusionWithDelay>d__80))]
	private IEnumerator ClearPlayerOcclusionWithDelay(IPlayer player) { }

	public void ClearTemporaryListenerRoom() { }

	private void CreateDataContainers() { }

	public static SpatialAudioSystem CreateSpatialAudioSystem(Transform parentTransform = null) { }

	public override void Dispose() { }

	private void DisposeProcessors() { }

	private bool get_CanUpdate() { }

	[CompilerGenerated]
	public bool get_Initialized() { }

	public bool get_IsTemporaryListenerOverrideActive() { }

	public int get_ListenerCurrentOutdoorRoomID() { }

	public ISpatialAudioRoom get_ListenerCurrentRoom() { }

	private Transform get_ListenerTransform() { }

	public SpatialAudioLocationInfo get_LocationInfo() { }

	public uint get_PropagationDepth() { }

	public float GetEnvironmentFactor(ISpatialAudioRoom sourceRoom, AudioGroupOcclusionSettings settings) { }

	public float GetIsolationFactor(ISpatialAudioRoom sourceRoom) { }

	private int GetLastProcessorIndex() { }

	private float GetLoadProgress() { }

	private int GetNextProcessorToUpdateIndex() { }

	public ISpatialAudioRoom GetOtherPlayerCurrentRoom(int playerId) { }

	private Transform GetPlayerTransform(IPlayer player) { }

	private string GetTargetQuality() { }

	private void InitFastAsyncOccluder() { }

	[AsyncStateMachine(typeof(<Initialize>d__52))]
	public Task Initialize(CancellationToken token, IProgress progress = null) { }

	public bool IsListenerAndSourceInSameRoom(ISpatialAudioRoom sourceRoom, EAudioRoomTypeMask roomMask) { }

	public bool IsOutdoor(Vector3 position) { }

	private bool IsPlayerOcclusionPaused(int containerID) { }

	public bool IsSourceAndListenerInCommonOutdoor(ISpatialAudioRoom sourceRoom) { }

	public bool IsSourceAndListenerInDiffEnvironment(ISpatialAudioRoom sourceRoom) { }

	public bool IsSourceAndListenerOutdoor(ISpatialAudioRoom sourceRoom) { }

	public bool IsSourceInListenerRoom(AudioSourceContainer sourceContainer) { }

	private void LateUpdate() { }

	public virtual void OnDestroy() { }

	private void OnPlayerDeadOrUnspawn(IPlayer player) { }

	private void OnPortalStatusChanged(AudioPortalStateChangedEvent stateChangedEvent) { }

	public void PauseContainerUpdate(int containerID, bool flushProcessorBeforePause = true, bool unregisterFromDebug = true) { }

	public void PausePlayerOcclusion(int playerId, bool paused) { }

	public void ProcessInteractiveObjectOcclusion(string targetID, BetterSource source, Vector3 position, EOcclusionTest test) { }

	public int ProcessSourceOcclusion(BetterSource source, EOcclusionTest test, Vector3 positionShift = null) { }

	public int ProcessSourceOcclusion(GameObject go, BetterSource source, EOcclusionTest occlusionTest = 2, float emptyContainerLifeTimeMS = 30000, Vector3 positionOffset = null, bool staticPosition = false) { }

	public int ProcessSourceOcclusion(IPlayer player, BetterSource source, bool allowedLimiter = false, EOcclusionTest occlusionTest = 5) { }

	public void ProcessWeaponSourceOcclusion(IPlayer player, SuperBetterAudioQueue weaponQueue, bool allowedLimiter = false) { }

	private void RaiseOtherPlayerSpatialRoomChanged(int playerId, EPlayerRoomInteractionState interactionState) { }

	private void ReactivateOutOfRangeProcessors() { }

	public void RemovePlayerCurrentRoom(SpatialAudioRoom room, IPlayer player) { }

	public void ResumeContainerUpdate(int containerID) { }

	public void ReturnCalculator(TCalculator calculator) { }

	private int RunContinuousOcclusionTest(BetterSource source, EOcclusionTest test, Vector3 positionShift = null) { }

	private int RunFastOcclusionTest(BetterSource source, EOcclusionTest test = 1, Vector3 positionShift = null) { }

	private int RunOneShotPropagationOcclusionTest(BetterSource source, EOcclusionTest test = 1, Vector3 positionShift = null) { }

	private void ScheduleNextProcessorForManualUpdate() { }

	[CompilerGenerated]
	private void set_Initialized(bool value) { }

	private static void SetGunshotsLowPassFilterFrequency(bool newSystemEnabled = true) { }

	public void SetTemporaryListenerRoom(ISpatialAudioRoom room) { }

	private void StartProgressCalculation(Task loadTask, IProgress progress) { }

	private void StopDeadPlayersCoroutines() { }

	private void StopProgressCoroutine() { }

	private Transform TryGetListenerTransform() { }

	public bool TryGetMatchingRoomPair(ISpatialAudioRoom emitterRoom, out RoomPair roomPair) { }

	public bool TryGetMatchingRoomPair(ISpatialAudioRoom emitterRoom, out RoomPair roomPair, out bool isReversed) { }

	public bool TryGetPlayerAudioContainer(int playerID, out AudioSourceContainer container) { }

	private void TryStopDeadPlayerCoroutine(int playerID) { }

	public void UnregisterContainer(int containerID) { }

	private void UnregisterPlayerContainers() { }

	private void UnregisterSourceContainer(AudioSourceContainer sourceContainer) { }

	private void Update() { }

	private void UpdateContainer(AudioSourceContainer container, BetterSource newSource, Vector3 posOffset) { }

	private void UpdateNextProcessorIndex() { }

	private void UpdatePlayerContainerOcclusion(SpatialAudioRoom newRoom, int playerId) { }

	private void UpdateRegisteredAudioContainers() { }

	private void UpdateRegisteredSourceValidity() { }

	private void ValidateProcessors() { }

	private void WarmUpCalculator() { }

	private void WarmUpCalculators() { }

	public TCalculator WithdrawCalculator() { }

}

