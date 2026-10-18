//Type is in global namespace

public sealed class BetterAudio : MonoBehaviourSingleton
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass189_0
	{
		public BetterAudio <>4__this; //Field offset: 0x10
		public string mixerKey; //Field offset: 0x18

		public <>c__DisplayClass189_0() { }

		internal float <FadeMixerVolume>b__0() { }

		internal void <FadeMixerVolume>b__1(float x) { }

	}

	[CompilerGenerated]
	private struct <LoadObjectAsync>d__124`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public string path; //Field offset: 0x0
		public CancellationTokenSource tokenSource; //Field offset: 0x0
		private AudioLogger <logger>5__2; //Field offset: 0x0
		private ResourceRequest <loadOperation>5__3; //Field offset: 0x0
		private YieldAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Preload>d__122 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BetterAudio <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PreloadCoroutine>d__123 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BetterAudio <>4__this; //Field offset: 0x20
		private AudioLogger <logger>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum AudioSourceGroupType
	{
		None = -1,
		Gunshots = 0,
		Weaponry = 1,
		Impacts = 2,
		Character = 3,
		Environment = 4,
		Collisions = 5,
		Speech = 6,
		Distant = 7,
		NonspatialBypass = 8,
		Nonspatial = 9,
		Voip = 10,
		Grenades = 11,
		Windows = 12,
		VehicleInSpeech = 13,
		Lamp = 14,
		InteractiveObjects = 15,
		OutEnvironment = 16,
		PropagatedExclusive = 17,
		LightOcclusion = 18,
		NonSpatialReverbBypass = 19,
		ItemDrop = 20,
		NonSpatialReverb = 21,
		GrenadeEmission = 22,
	}

	public static bool IsInHideout; //Field offset: 0x0
	public const float FROM_OUT_TO_IN_TRANSITION_TIME = 0.1; //Field offset: 0x0
	public const float FROM_IN_TO_OUT_TRANSITION_TIME = 0.5; //Field offset: 0x0
	public const float SOUND_SPEED = 340; //Field offset: 0x0
	public const float MIN_RELEASE_TIME = 1; //Field offset: 0x0
	public const float MIN_FADE_TIME = 1; //Field offset: 0x0
	private const string MIXER_TWEEN_ID_PREFIX = "MixerFade_"; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsQuitting>k__BackingField; //Field offset: 0x1
	private static readonly Dictionary _groupPresets; //Field offset: 0x8
	public WeaponSounds MiscCollisionSounds; //Field offset: 0x20
	public ItemDropSounds ItemDropSounds; //Field offset: 0x28
	private FloatBuff _protagonistBuff; //Field offset: 0x30
	[CompilerGenerated]
	private Action ProtagonistHearingChanged; //Field offset: 0x38
	private Skill _hearingSkill; //Field offset: 0x40
	private float _gunsVolume; //Field offset: 0x48
	private GameObject _audioSourcePrefab; //Field offset: 0x50
	private GameObject _audioSourceBypassPrefab; //Field offset: 0x58
	private GameObject _audioSourceSpatialBuiltinEQPrefab; //Field offset: 0x60
	private GameObject _audioSourceSpatialBuiltinEQReverbPrefab; //Field offset: 0x68
	private GameObject _audioSourceSuperPrefab; //Field offset: 0x70
	private GameObject _audioSourceSuperSpatialBuiltinEQPrefab; //Field offset: 0x78
	private GameObject _audioSourceSuperSpatialBuiltinEQReverbPrefab; //Field offset: 0x80
	private GameObject _audioSourceSuperCustomSpatialBuiltinEQReverbPrefab; //Field offset: 0x88
	private GameObject _audioSourceNonSpatialReverbPrefab; //Field offset: 0x90
	private readonly TimeQueue _audioSourceQueue; //Field offset: 0x98
	public ISourceGroup[] SourceGroups; //Field offset: 0xA0
	public AudioMixer Master; //Field offset: 0xA8
	public AudioMixerSnapshot[] Snapshots; //Field offset: 0xB0
	public AudioMixerGroup MasterMixerGroup; //Field offset: 0xB8
	public AudioMixerGroup GunshotOccludedMixerGroup; //Field offset: 0xC0
	public AudioMixerGroup SimpleOccludedMixerGroup; //Field offset: 0xC8
	public AudioMixerGroup MutedGroup; //Field offset: 0xD0
	public AudioMixerGroup UpperOccluded; //Field offset: 0xD8
	public AudioMixerGroup LowerOccluded; //Field offset: 0xE0
	public AudioMixerGroup GunshotMixerGroup; //Field offset: 0xE8
	public AudioMixerGroup GunsInstrumentalMixer; //Field offset: 0xF0
	public AudioMixerGroup ImpactsMixerGroup; //Field offset: 0xF8
	public AudioMixerGroup VeryStandartMixerGroup; //Field offset: 0x100
	public AudioMixerGroup SelfSpeechReverb; //Field offset: 0x108
	public AudioMixerGroup OutEnvironment; //Field offset: 0x110
	public AudioMixerGroup VoipMixer; //Field offset: 0x118
	public AudioMixerGroup NonSpatialBypassMixer; //Field offset: 0x120
	public AudioMixerGroup VehicleInSpeechMixer; //Field offset: 0x128
	public AudioMixerGroup AmbientInMixer; //Field offset: 0x130
	public AudioMixerGroup AmbientInRoomToneMixer; //Field offset: 0x138
	public AudioMixerGroup AmbientOutMixer; //Field offset: 0x140
	public AudioMixerGroup CommonAmbientInEffectsMixer; //Field offset: 0x148
	public AudioMixerGroup CommonAmbientOutEffectsMixer; //Field offset: 0x150
	public AudioMixerGroup CommonAmbientEffectsMixer; //Field offset: 0x158
	public AudioMixerGroup ClientPlayerMixerGroup; //Field offset: 0x160
	public AudioMixerGroup ClientPlayerMovementMixer; //Field offset: 0x168
	public AudioMixerGroup ClientPlayerSpeechMixer; //Field offset: 0x170
	public AudioMixerGroup ObservedPlayerMovementMixer; //Field offset: 0x178
	public AudioMixerGroup ObservedPlayerSpeechMixer; //Field offset: 0x180
	public AudioMixerGroup EnvNatureSoundsGroup; //Field offset: 0x188
	public AudioMixerGroup EnvTechnicalSoundsGroup; //Field offset: 0x190
	public AudioMixerGroup VehicleInMixer; //Field offset: 0x198
	public AudioMixerGroup VehicleOutMixer; //Field offset: 0x1A0
	public AudioMixerGroup WorldMixer; //Field offset: 0x1A8
	public AudioMixerGroup AmbientFirefightMixer; //Field offset: 0x1B0
	public AudioMixerGroup GunshotsVehicleInMixer; //Field offset: 0x1B8
	private float _tinnitusLn; //Field offset: 0x1C0
	private float _endTime; //Field offset: 0x1C4
	private float _nextPitchUpdate; //Field offset: 0x1C8
	public int OcclusionMask; //Field offset: 0x1CC
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x1D0
	private readonly List _audioQueues; //Field offset: 0x1D8
	private readonly PoolWithoutAlloc _superQueuesPool; //Field offset: 0x1E0
	private Action _skillLevelSubscription; //Field offset: 0x1E8
	private RaycastHit _lastHit; //Field offset: 0x1F0
	private ActiveHeadphonesController _headphonesController; //Field offset: 0x220
	private GagSoundLimiter _gagSoundLimiter; //Field offset: 0x228
	private MetaXRPluginErrorChecker _errorChecker; //Field offset: 0x230
	private Action _unsubOnDestroy; //Field offset: 0x238
	private readonly AudioPoolBudgetScheduler _poolScheduler; //Field offset: 0x240
	private PoolSettings _poolSettings; //Field offset: 0x248
	private bool _isInitialized; //Field offset: 0x250
	private BetterSourceCulling _betterSourceCulling; //Field offset: 0x258
	private MixerExposedParameters _masterMixerSettings; //Field offset: 0x260
	[CompilerGenerated]
	private AudioMixerDataContainer <AudioMixerData>k__BackingField; //Field offset: 0x268
	[CompilerGenerated]
	private Player <ListenerPlayer>k__BackingField; //Field offset: 0x270
	[CompilerGenerated]
	private Transform <ListenerTransform>k__BackingField; //Field offset: 0x278
	[CompilerGenerated]
	private IBetterSourceUpdater <UpdateSystem>k__BackingField; //Field offset: 0x280
	[CompilerGenerated]
	private IAudioGroupResourceMonitor <ResourceMonitor>k__BackingField; //Field offset: 0x288
	private TinnitusEffectController _tinnitusEffectController; //Field offset: 0x290

	public event Action ProtagonistHearingChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private AudioMixerDataContainer AudioMixerData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HeadphonesApplyContext CurrentHeadphonesApplyContext
	{
		 get { } //Length: 36
	}

	public HeadphonesTemplate CurrentHeadphonesTemplate
	{
		 get { } //Length: 102
	}

	public private static bool IsQuitting
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		private set { } //Length: 89
	}

	public private Player ListenerPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Transform ListenerTransform
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float ProtagonistHearing
	{
		 get { } //Length: 28
	}

	public private IAudioGroupResourceMonitor ResourceMonitor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float StopFadeSeconds
	{
		 get { } //Length: 31
	}

	public private IBetterSourceUpdater UpdateSystem
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static BetterAudio() { }

	public BetterAudio() { }

	[CompilerGenerated]
	private AudioMixerSnapshot <PreloadCoroutine>b__123_0(string x) { }

	[CompilerGenerated]
	public void add_ProtagonistHearingChanged(Action value) { }

	public void AddToAudioSourceQueue(ITimeQueueItem queueItem, double endTime) { }

	private void AmbientSystemInitHandler(AmbientAudioSystemInitializedEvent initializedEvent) { }

	private void ApplyClipStartOffsetIfNeeded(BetterSource source, float startOffset) { }

	public void ApplyCurrentHeadphonesTemplate() { }

	public void ApplyHeadphonesTemplate(HeadphonesApplyContext context, bool doFade = true) { }

	public void ApplyHeadphonesTemplate(HeadphonesTemplate template) { }

	public void ApplyHideoutAudioFilter(float targetVolume, float targetFreq, float duration, bool compete = true) { }

	public void ApplySpatialSettingsFromBackend(ClientAudioOcclusionSettings audioOcclusionSettings) { }

	public void Clear() { }

	public void ClearRuntimeData() { }

	public T CreateBetterSource(AudioSource parentSource, AudioSourceGroupType groupType, bool active = true, bool update = false, EAudioCullingMode cullingMode = 0) { }

	public T CreateBetterSourceWithParentSettings(AudioSource parentSource, AudioSourceGroupType groupType, bool active = true, bool update = false, EAudioCullingMode cullingMode = 0) { }

	private void CreateSoundManagers() { }

	public void EnabledHeadphones(bool enabled, bool doFade = true) { }

	public void EnqueueStop(PooledBetterSourceHandle agent, uint generation) { }

	public void FadeInVolumeBeforeRaid(float seconds) { }

	public void FadeMixerVolume(string mixerKey, float endValDb, float seconds, bool force = false) { }

	public void FadeOutVolumeAfterRaid(float seconds = 0) { }

	private void FindAudioMixers() { }

	public AudioMixerGroup FindMixerGroup(string groupName) { }

	public void ForceSetCommonVolume(float valDb) { }

	[CompilerGenerated]
	public AudioMixerDataContainer get_AudioMixerData() { }

	public HeadphonesApplyContext get_CurrentHeadphonesApplyContext() { }

	public HeadphonesTemplate get_CurrentHeadphonesTemplate() { }

	[CompilerGenerated]
	public static bool get_IsQuitting() { }

	[CompilerGenerated]
	public Player get_ListenerPlayer() { }

	[CompilerGenerated]
	public Transform get_ListenerTransform() { }

	public float get_ProtagonistHearing() { }

	[CompilerGenerated]
	public IAudioGroupResourceMonitor get_ResourceMonitor() { }

	public float get_StopFadeSeconds() { }

	[CompilerGenerated]
	public IBetterSourceUpdater get_UpdateSystem() { }

	public float GetPoolUsagePercent(AudioSourceGroupType groupType) { }

	public BetterSource GetSource(SoundBank bank, bool activateSource = true, bool needUpdate = true, bool useHotPool = true, EAudioCullingMode cullingMode = 0) { }

	[CanBeNull]
	public BetterSource GetSource(AudioSourceGroupType sourceType, bool activateSource = true, bool needUpdate = true, bool useHotPool = true, EAudioCullingMode cullingMode = 0) { }

	private void InitBetterSourceCulling() { }

	private void InitHeadphonesSystem() { }

	private void InitializeSourceGroupsByType() { }

	private ISourceGroup InstSourceGroup(AudioMixerGroup mixerGroup, GameObject sourcePrefab, AudioGroupPreset preset, bool spatialize = true) { }

	public void InvokeProtagonistAction() { }

	public bool IsSourcesInDifferentVolume(Vector3 firstSourcePos, Vector3 secondSourcePos) { }

	private void LateUpdate() { }

	public BetterSource LimitedPlay(Vector3 position, AudioClip clip, AudioSourceGroupType groupType, int rolloff, float distance, string key, Vector2 gagRadius, float chokeTime, in PlayOptions options) { }

	public BetterSource LimitedPlay(Vector3 position, SoundBank bank, Vector2 gagRadius, float chokeTime, string key, in PlayOptions options) { }

	private static AudioGroupPreset LoadGroupPreset(string groupName) { }

	[AsyncStateMachine(typeof(<LoadObjectAsync>d__124`1))]
	private Task LoadObjectAsync(string path, CancellationTokenSource tokenSource) { }

	public void LoadSoundBundles() { }

	public void OnApplicationQuit() { }

	public virtual void OnDestroy() { }

	public SpatialAudioBuilder Play(SoundBank soundBank) { }

	public SpatialAudioBuilder Play(AudioClip clip, int rolloff) { }

	public SpatialAudioBuilder Play(IAudioClipContainer clipContainer) { }

	public BetterSource PlayAtPoint(Vector3 position, AudioClip clip, AudioSourceGroupType sourceGroup, int rolloff, in PlayOptions options, float precomputedSqrDistanceToListener = -1) { }

	public BetterSource PlayAtPoint(Vector3 position, SoundBank bank, in PlayOptions options) { }

	public BetterSource PlayAtPointDelayed(Vector3 position, SoundBank bank, float delay, in PlayOptions options) { }

	public BetterSource PlayAtPointDelayed(Vector3 position, AudioClip clip, AudioSourceGroupType sourceGroupType, int rolloff, float delay, in PlayOptions options) { }

	public BetterSource PlayAtPointForGameObject(GameObject sourceObject, Vector3 position, AudioClip clip, AudioSourceGroupType sourceGroup, int rolloff, in PlayOptions options) { }

	public BetterSource PlayAtPointForPlayer(IPlayer player, Vector3 position, AudioClip clip, AudioSourceGroupType sourceGroup, int rolloff, in PlayOptions options) { }

	public BetterSource PlayAtPointForPlayer(IPlayer player, Vector3 position, SoundBank bank, in PlayOptions options) { }

	private void PlayAtPointHelper(BetterSource source, AudioClip clipA, AudioClip clipB, float volume, bool oneShot, float balance, in PlayOptions opts) { }

	private BetterSource PlayAtPointScheduledHelper(Vector3 position, float rolloff, float sqrDistanceToListener, AudioClip clipA, AudioClip clipB, float pitch, float delay, float balance, AudioSourceGroupType targetGroupType, in PlayOptions opts) { }

	public BetterSource PlayAtPointWithPhysicalDelay(Vector3 position, SoundBank bank, in PlayOptions options) { }

	public void PlayDropItem(ESurfaceSound surfaceSound, string itemSoundID, Vector3 position, float impactValue) { }

	public void PlayDropItem(SoundBank bank, Vector3 position, float impactValue = 1) { }

	public BetterSource PlayNonspatial(AudioClip clip, AudioSourceGroupType sourceGroup, float panStereo = 0, float volume = 1, AudioMixerGroup forcedGroup = null, bool reverbEnabled = true, bool loop = false) { }

	public NonspatialAudioBuilder PlayNonspatial(AudioClip clip) { }

	public void PrecacheGag(string chokeKey) { }

	[AsyncStateMachine(typeof(<Preload>d__122))]
	public void Preload() { }

	[AsyncStateMachine(typeof(<PreloadCoroutine>d__123))]
	public Task PreloadCoroutine() { }

	public void RegisterVolume(BetterPropagationVolume volume) { }

	[CompilerGenerated]
	public void remove_ProtagonistHearingChanged(Action value) { }

	public void RemoveFromAudioSourceQueue(ITimeQueueItem queueItem) { }

	public void RemoveVolume(BetterPropagationVolume volume) { }

	public void ResetHideoutAudioFilter(float transitionDuration = 1) { }

	public void ResetMasterValues() { }

	public void ResetReverbChecker() { }

	public void ResetWorldMixerValues() { }

	[CompilerGenerated]
	private void set_AudioMixerData(AudioMixerDataContainer value) { }

	[CompilerGenerated]
	private static void set_IsQuitting(bool value) { }

	[CompilerGenerated]
	private void set_ListenerPlayer(Player value) { }

	[CompilerGenerated]
	private void set_ListenerTransform(Transform value) { }

	[CompilerGenerated]
	private void set_ResourceMonitor(IAudioGroupResourceMonitor value) { }

	[CompilerGenerated]
	private void set_UpdateSystem(IBetterSourceUpdater value) { }

	private void SetDefaultSourceParameters(BetterSource source, Vector3 position, float rolloff, AudioMixerGroup targetMixerGroup, int priority, float pitch = 1, bool loop = false) { }

	private void SetEnvironmentReverbHighpass(EnvironmentType environment) { }

	public void SetHideoutLowPassFilter(float freq, float transitionDuration = 1, bool forced = false) { }

	public void SetHideoutVolumeState(bool active, float transitionDuration = 1) { }

	public void SetMonitoringInterval(float interval) { }

	public void SetProtagonist(Player player) { }

	public void SetResourceThreshold(AudioSourceGroupType groupType, float lowThreshold, float highThreshold, float criticalThreshold) { }

	public void StartResourceMonitoring(float interval = 0.5) { }

	public void StartTinnitusEffect(float time, AudioClip clip = null) { }

	public void StopResourceMonitoring() { }

	public void ToggleNarrate(bool inScene, float seconds = 1) { }

	public void TogglePauseTinnitusEffect(bool pause) { }

	public void TransitToEnvironment(EnvironmentType environment, float transitionTime) { }

	public void TransitToEnvironment(EnvironmentType environment) { }

	private void TryAddToAudioQueue(BetterSource source) { }

	public bool TryGetGroupPreset(AudioSourceGroupType groupType, out AudioGroupPreset preset) { }

	private BetterSource TryPlayAtPointBankCore(Vector3 position, SoundBank bank, float sqrDistanceToListener, in PlayOptions options, float scheduleDelay, float precomputedLinearDistance, bool useSqrForPriorityWhenScheduled) { }

	public void UnsubscribeProtagonist() { }

	public void Update() { }

}

