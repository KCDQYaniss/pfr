//Type is in global namespace

public abstract class BetterSource : MonoBehaviour, ITimeQueueItem, ISpatialized, IReverberated
{
	internal enum EPlayBackState
	{
		Playing = 0,
		Stopped = 1,
		Scheduled = 2,
	}

	[SerializeField]
	private EPlayBackState _playbackState; //Field offset: 0x20
	protected double ScheduledPlayTime; //Field offset: 0x28
	protected AudioSource Source1; //Field offset: 0x30
	private Transform _transform; //Field offset: 0x38
	protected bool IncludedInOcclusionProcess; //Field offset: 0x40
	protected BaseSpatialAudioSource Spatializer; //Field offset: 0x48
	private readonly List _filterRequestProviders; //Field offset: 0x50
	protected float _preEffectsVolume; //Field offset: 0x58
	protected bool Initialized; //Field offset: 0x5C
	private readonly ITransformTracker _transformTracker; //Field offset: 0x60
	private IAudioEQFilter[] _audioFilters; //Field offset: 0x68
	private List _updatedComps; //Field offset: 0x70
	private bool _needUpdate; //Field offset: 0x78
	private IHRTFCalculator _hrtfCalculator; //Field offset: 0x80
	private readonly AudioFader _audioFader; //Field offset: 0x88
	private bool _isFading; //Field offset: 0x90
	protected bool _stopScheduled; //Field offset: 0x91
	private float _scheduledFadeTime; //Field offset: 0x94
	private Action _fadeOnDone; //Field offset: 0x98
	private double _scheduledFadeStartDsp; //Field offset: 0xA0
	private double _scheduledFadeEndDsp; //Field offset: 0xA8
	protected double _playStartTime; //Field offset: 0xB0
	protected double _currentPlayBackDuration; //Field offset: 0xB8
	protected bool _isOneShot; //Field offset: 0xC0
	[CompilerGenerated]
	private double <EndPlaybackTime>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private bool <ForceStereo>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private PooledBetterSourceHandle <PoolHandle>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private IBetterSourceUpdater <Updater>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private IBetterSourceCulling <Culling>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private AudioGroupPreset <Preset>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private float <OcclusionVolumeFactor>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private float <OcclusionRolloffScale>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private float <FadeFactor>k__BackingField; //Field offset: 0x104
	[CompilerGenerated]
	private bool <IsCulled>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private bool <UserEnableEQ>k__BackingField; //Field offset: 0x109
	[CompilerGenerated]
	private bool <UserEnableManualComps>k__BackingField; //Field offset: 0x10A
	private EAudioCullingMode _cullingMode; //Field offset: 0x10C
	[CompilerGenerated]
	private float <MaxDistance>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private bool <UpdateVolume>k__BackingField; //Field offset: 0x114
	[CompilerGenerated]
	private Action StateChanged; //Field offset: 0x118
	[CompilerGenerated]
	private Action ReleaseRequested; //Field offset: 0x120
	[CompilerGenerated]
	private float <BaseVolume>k__BackingField; //Field offset: 0x128

	public event Action ReleaseRequested
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private float BaseVolume
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	protected bool CanPlay
	{
		 get { } //Length: 349
	}

	public IBetterSourceCulling Culling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public EAudioCullingMode CullingMode
	{
		 get { } //Length: 7
		 set { } //Length: 390
	}

	public override float DirectivityIntensity
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public override float EarlyReflectionsSendDB
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public override bool EnableDirectSound
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public override bool EnableReverb
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public override bool EnableSpatialization
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public double EndPlaybackTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public private float FadeFactor
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private bool ForceStereo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override float HrtfIntensity
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public private bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsCulled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Vector3 LocalPosition
	{
		 get { } //Length: 138
		 set { } //Length: 112
	}

	public abstract bool Loop
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float MaxDistance
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public AudioMixerGroup MixerGroup
	{
		 get { } //Length: 90
	}

	public bool NeedUpdate
	{
		 get { } //Length: 5
	}

	protected private float OcclusionRolloffScale
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float OcclusionVolumeFactor
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public EPlayBackState PlayBackState
	{
		 get { } //Length: 4
		 set { } //Length: 42
	}

	public internal PooledBetterSourceHandle PoolHandle
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public Vector3 Position
	{
		 get { } //Length: 138
		 set { } //Length: 112
	}

	public private AudioGroupPreset Preset
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int Priority
	{
		 get { } //Length: 90
	}

	public override float ReverbReach
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public override float ReverbSendDB
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public AudioGroupOcclusionSettings SpatialSettings
	{
		 get { } //Length: 30
	}

	public IBetterSourceUpdater Updater
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool UpdateVolume
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private bool UserEnableEQ
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool UserEnableManualComps
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected BetterSource() { }

	[CompilerGenerated]
	public void add_ReleaseRequested(Action value) { }

	[CompilerGenerated]
	public void add_StateChanged(Action value) { }

	public override void ApplyAcousticSettings(AcousticSettings settings) { }

	protected override void ApplyEQ(bool state) { }

	public void ApplyOcclusionRequest(in FilterBandRequest request, bool applyImmediately = false) { }

	public override void ApplySpatializerSettings(SpatializerSettings settings) { }

	public void ApplySpatialRequest(in FilterBandRequest request, bool applyImmediately = false) { }

	protected override void ApplyUpdatableComps(bool state) { }

	public void Awake() { }

	public abstract void Balance(float p) { }

	protected double CalculateConcreteSourceEndPlaybackTime(double startTime, AudioClip clip, float pitch) { }

	protected abstract float CalculateFinalVolume(int id) { }

	protected override double CalculatePlaybackDuration(AudioClip clip1, float pitch1, AudioClip clip2, float pitch2) { }

	public void CancelFade(bool reset = false) { }

	protected override bool CheckBinauralAllowed(bool immediate = false) { }

	[Conditional("UNITY_EDITOR")]
	protected void CheckIfClipLoaded(AudioClip clip) { }

	private void CheckPlaybackState() { }

	public override void Clear(float spatial = 1, float pitch = 1, float panStereo = 0) { }

	protected abstract void ClearClips() { }

	public void ClearOcclusionRequest(bool applyImmediately = false) { }

	public void ClearSpatialRequest() { }

	internal override void CompleteActivation() { }

	internal override void CompleteDeactivation() { }

	public void EnabledEQ(bool targetState) { }

	public override void EnabledHighPassFilter(bool enabledFilter) { }

	public override void EnabledLowPassFilter(bool enabledFilter) { }

	public void EnabledManualUpdateComponents(bool targetState) { }

	public void EnabledUpdate(bool targetState) { }

	public override void EnableStereo(bool stereo = false) { }

	[CompilerGenerated]
	public float get_BaseVolume() { }

	protected bool get_CanPlay() { }

	[CompilerGenerated]
	public IBetterSourceCulling get_Culling() { }

	public EAudioCullingMode get_CullingMode() { }

	public override float get_DirectivityIntensity() { }

	public override float get_EarlyReflectionsSendDB() { }

	public override bool get_EnableDirectSound() { }

	public override bool get_EnableReverb() { }

	public override bool get_EnableSpatialization() { }

	[CompilerGenerated]
	public double get_EndPlaybackTime() { }

	[CompilerGenerated]
	public float get_FadeFactor() { }

	[CompilerGenerated]
	public bool get_ForceStereo() { }

	public override float get_HrtfIntensity() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	[CompilerGenerated]
	public bool get_IsCulled() { }

	public Vector3 get_LocalPosition() { }

	public abstract bool get_Loop() { }

	[CompilerGenerated]
	public float get_MaxDistance() { }

	public AudioMixerGroup get_MixerGroup() { }

	public bool get_NeedUpdate() { }

	[CompilerGenerated]
	protected float get_OcclusionRolloffScale() { }

	[CompilerGenerated]
	public float get_OcclusionVolumeFactor() { }

	public EPlayBackState get_PlayBackState() { }

	[CompilerGenerated]
	public PooledBetterSourceHandle get_PoolHandle() { }

	public Vector3 get_Position() { }

	[CompilerGenerated]
	public AudioGroupPreset get_Preset() { }

	public int get_Priority() { }

	public override float get_ReverbReach() { }

	public override float get_ReverbSendDB() { }

	public AudioGroupOcclusionSettings get_SpatialSettings() { }

	[CompilerGenerated]
	public IBetterSourceUpdater get_Updater() { }

	[CompilerGenerated]
	public bool get_UpdateVolume() { }

	[CompilerGenerated]
	public bool get_UserEnableEQ() { }

	[CompilerGenerated]
	public bool get_UserEnableManualComps() { }

	protected override double GetActualStartTime() { }

	public abstract AudioClip GetClip(int id) { }

	public override float GetPitch(int clipIndex) { }

	public abstract float GetVolume(int id) { }

	public void IncludeInOcclusionProcess(bool included) { }

	public void Init() { }

	public void ManualFadeUpdate() { }

	public override void ManualUpdate() { }

	public abstract void Mute(bool muted) { }

	protected override void OnAwake() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	protected override void OnInit() { }

	protected override void OnStop() { }

	public void Play(AudioClip clip1, AudioClip clip2, float balance, float volume = 1, bool forceStereo = false, bool oneShot = true) { }

	public override void PlayScheduled(double time, AudioClip clip1, AudioClip clip2, float balance, bool spatialize = true) { }

	protected abstract void PrepareClips(AudioClip clip1, AudioClip clip2) { }

	protected abstract void PreparePlayback(AudioClip clip1, AudioClip clip2, float balance, float volume) { }

	protected abstract void PrepareScheduledPlayback(AudioClip clip1, AudioClip clip2, float balance) { }

	protected void RecalculatePlaybackTimesFromPitch() { }

	protected override void RefreshSpatialization(bool enabledSpat) { }

	private void RegisterInUpdateSystem(EAudioCullingMode mode) { }

	public override void Release() { }

	[CompilerGenerated]
	public void remove_ReleaseRequested(Action value) { }

	[CompilerGenerated]
	public void remove_StateChanged(Action value) { }

	public void ResetCulling() { }

	protected override void ResetFilters() { }

	public void ResetOcclusion() { }

	public void ResetScheduledFadeAndEnd() { }

	public void ResetSpatializerAndDisableAcoustics() { }

	public void ResetVolume() { }

	public void ScheduleFadeAndEnd(double fadeStartDspTime, float fadeDurationSec) { }

	[CompilerGenerated]
	private void set_BaseVolume(float value) { }

	[CompilerGenerated]
	public void set_Culling(IBetterSourceCulling value) { }

	public void set_CullingMode(EAudioCullingMode value) { }

	public override void set_DirectivityIntensity(float value) { }

	public override void set_EarlyReflectionsSendDB(float value) { }

	public void set_EnableDirectSound(bool value) { }

	public override void set_EnableReverb(bool value) { }

	public override void set_EnableSpatialization(bool value) { }

	[CompilerGenerated]
	protected void set_EndPlaybackTime(double value) { }

	[CompilerGenerated]
	private void set_FadeFactor(float value) { }

	[CompilerGenerated]
	private void set_ForceStereo(bool value) { }

	public override void set_HrtfIntensity(float value) { }

	[CompilerGenerated]
	private void set_IsActive(bool value) { }

	[CompilerGenerated]
	private void set_IsCulled(bool value) { }

	public void set_LocalPosition(Vector3 value) { }

	public abstract void set_Loop(bool value) { }

	[CompilerGenerated]
	protected void set_MaxDistance(float value) { }

	[CompilerGenerated]
	private void set_OcclusionRolloffScale(float value) { }

	[CompilerGenerated]
	protected void set_OcclusionVolumeFactor(float value) { }

	public void set_PlayBackState(EPlayBackState value) { }

	[CompilerGenerated]
	internal void set_PoolHandle(PooledBetterSourceHandle value) { }

	public void set_Position(Vector3 value) { }

	[CompilerGenerated]
	private void set_Preset(AudioGroupPreset value) { }

	public override void set_ReverbReach(float value) { }

	public override void set_ReverbSendDB(float value) { }

	[CompilerGenerated]
	public void set_Updater(IBetterSourceUpdater value) { }

	[CompilerGenerated]
	public void set_UpdateVolume(bool value) { }

	[CompilerGenerated]
	private void set_UserEnableEQ(bool value) { }

	[CompilerGenerated]
	private void set_UserEnableManualComps(bool value) { }

	public override void SetActive(bool active, bool forceApplyToAllComponents = false) { }

	public override void SetBaseVolume(float volume) { }

	public abstract void SetClip(int id, AudioClip clip) { }

	public override void SetCulledState(bool isCulled) { }

	public override void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	public abstract void SetDopplerLevel(float dopplerLevel = 0) { }

	public override void SetHighPassFilterParameters(float cutoffFreq = 100, float targetQ = 1, bool applyImmediately = false) { }

	public override void SetLowPassFilterParameters(float cutoffFreq = 1600, float targetQ = 1, bool applyImmediately = false) { }

	public abstract void SetMixerGroup(AudioMixerGroup mixerGroup) { }

	public void SetOcclusionRolloffScale(float value) { }

	public override void SetOcclusionVolumeFactor(float value) { }

	public abstract void SetPanStereo(float pan = 0) { }

	public void SetParent(Transform parent, bool worldPositionStay = true) { }

	public abstract void SetPitch(int clipIndex, float p) { }

	public abstract void SetPitch(float p) { }

	public void SetPreset(AudioGroupPreset preset) { }

	public override void SetPriority(int priority) { }

	public abstract void SetRolloff(float distance) { }

	public abstract void SetScheduledEndTime(double time) { }

	protected abstract void SetSourceActive(bool active) { }

	public abstract void SetSpatialBlend(float spatialBlend = 1) { }

	public abstract void SetSpread(float spread) { }

	public abstract void SetTime(float time) { }

	protected abstract void StartPlayback(AudioClip clip1, AudioClip clip2, float balance, float volume) { }

	protected abstract void StartScheduledPlayback(double time, AudioClip clip1, AudioClip clip2) { }

	public void StartTrackingPosition(Transform tracker, Vector3 positionOffset = null) { }

	public void Stop(float fadeSec = 0) { }

	private void StopFade() { }

	protected abstract void StopPlayback() { }

	public void StopTrackingPosition() { }

	protected abstract void SyncPlayback() { }

	protected void SyncSource(AudioSource source, double startTime, int pitchIndex) { }

	protected abstract void TrySetDefaultScheduledEndTime(double startTime, AudioClip clip1, AudioClip clip2, float pitch1, float pitch2) { }

	private void TryStartScheduledFade() { }

	public override void UpdateParameters() { }

	public abstract void UpdateSourceVolume(float speed = 1) { }

	public override void UpdateSpatialParameters() { }

	private void UpdateTrackedPosition() { }

	public bool VolumeFadeIn(float time, Action onDone = null, EAudioFadeType fadeType = 0) { }

	public bool VolumeFadeOut(float time, Action onDone = null, EAudioFadeType fadeType = 0) { }

}

