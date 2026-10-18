namespace Audio.AmbientSubsystem;

[RequireComponent(typeof(AudioSource))]
public abstract class BaseAmbientSoundPlayer : MonoBehaviour, ISoundPlayer
{
	[Range(0, 1)]
	[SerializeField]
	[Space]
	private float _volume; //Field offset: 0x20
	[Range(0, 1)]
	[SerializeField]
	private float _deltaVolume; //Field offset: 0x24
	[SerializeField]
	private Vector2 _randomPitchRange; //Field offset: 0x28
	[SerializeField]
	private float _fadeInDurationSec; //Field offset: 0x30
	[SerializeField]
	private float _fadeOutDurationSec; //Field offset: 0x34
	[SerializeField]
	[Space]
	private AudioMixerGroup _mixerGroup; //Field offset: 0x38
	[SerializeField]
	private bool ForceSetMixerGroup; //Field offset: 0x40
	[SerializeField]
	[Space]
	private bool _playOnAwake; //Field offset: 0x41
	[Header("Spatial Settings")]
	[Range(0, 1)]
	[SerializeField]
	[Space]
	private float _spread; //Field offset: 0x44
	[Range(0, 1)]
	[SerializeField]
	private float _spatialBlend; //Field offset: 0x48
	[SerializeField]
	private float _minDistance; //Field offset: 0x4C
	[SerializeField]
	private float _maxDistance; //Field offset: 0x50
	[SerializeField]
	private AnimationCurve _rolloffCurve; //Field offset: 0x58
	[SerializeField]
	private Vector2 _startPlayingDelay; //Field offset: 0x60
	[SerializeField]
	private AnimationCurve _spreadCurve; //Field offset: 0x68
	[SerializeField]
	private bool _useCustomSpreadCurve; //Field offset: 0x70
	private bool _initialized; //Field offset: 0x71
	private AudioSource _source; //Field offset: 0x78
	private Transform _cachedTransform; //Field offset: 0x80
	private float _startDelayTimer; //Field offset: 0x88
	private bool _sourceEnabled; //Field offset: 0x8C
	private float _lastAppliedVolume; //Field offset: 0x90
	private AmbientVolumeMixer _fader; //Field offset: 0x98
	[CompilerGenerated]
	private Action Stopped; //Field offset: 0xA0
	[CompilerGenerated]
	private Action Played; //Field offset: 0xA8
	[CompilerGenerated]
	private Action StartPlay; //Field offset: 0xB0
	private Action _unsubOnSystemInit; //Field offset: 0xB8
	[CompilerGenerated]
	private EAudioPlayerState <State>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private bool <IsAudible>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private float <CurrentMaxDistance>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private double <VirtualStartTime>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <IsStartDelayPassed>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private int <Priority>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	private bool <RequiresVirtualSchedule>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private AudioClip <EmptyClip>k__BackingField; //Field offset: 0xE8

	public override event Action Played
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override event Action StartPlay
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override event Action Stopped
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	protected override float BasePitch
	{
		 get { } //Length: 18
	}

	protected override float BaseVolume
	{
		 get { } //Length: 160
	}

	public private float CurrentMaxDistance
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float EffectiveVolume
	{
		 get { } //Length: 31
	}

	protected private AudioClip EmptyClip
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool IsAudible
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool IsEffectivelySilent
	{
		private get { } //Length: 84
	}

	public override bool IsPlaying
	{
		 get { } //Length: 11
	}

	protected private bool IsStartDelayPassed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool NeedCullingRegistration
	{
		private get { } //Length: 80
	}

	public override Vector3 Position
	{
		 get { } //Length: 141
		 set { } //Length: 115
	}

	public int Priority
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool RequiresVirtualSchedule
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	protected AudioSource Source
	{
		 get { } //Length: 375
	}

	public private EAudioPlayerState State
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected private double VirtualStartTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	protected BaseAmbientSoundPlayer() { }

	[CompilerGenerated]
	public override void add_Played(Action value) { }

	[CompilerGenerated]
	public override void add_StartPlay(Action value) { }

	[CompilerGenerated]
	public override void add_Stopped(Action value) { }

	protected void ApplyVolume(float volume) { }

	private void Awake() { }

	protected override bool CanPlay() { }

	public override void FadeIn(float fadeInSec) { }

	public override void FadeOut(float fadeOutSec) { }

	protected override float get_BasePitch() { }

	protected override float get_BaseVolume() { }

	[CompilerGenerated]
	public float get_CurrentMaxDistance() { }

	public float get_EffectiveVolume() { }

	[CompilerGenerated]
	protected AudioClip get_EmptyClip() { }

	[CompilerGenerated]
	public bool get_IsAudible() { }

	private bool get_IsEffectivelySilent() { }

	public override bool get_IsPlaying() { }

	[CompilerGenerated]
	protected bool get_IsStartDelayPassed() { }

	private bool get_NeedCullingRegistration() { }

	public override Vector3 get_Position() { }

	[CompilerGenerated]
	public int get_Priority() { }

	[CompilerGenerated]
	public bool get_RequiresVirtualSchedule() { }

	protected AudioSource get_Source() { }

	[CompilerGenerated]
	public EAudioPlayerState get_State() { }

	[CompilerGenerated]
	protected double get_VirtualStartTime() { }

	protected abstract AudioClip GetClip() { }

	protected override void Init() { }

	protected void InvokePlayedEvent() { }

	public void ManualTick(float dt) { }

	protected override void OnDestroy() { }

	protected override void OnStop() { }

	private void OnSystemInitialized(AmbientAudioSystemInitializedEvent evt) { }

	public override void Play() { }

	private void RegisterInAudioCulling() { }

	private void RegisterInTickManager() { }

	[CompilerGenerated]
	public override void remove_Played(Action value) { }

	[CompilerGenerated]
	public override void remove_StartPlay(Action value) { }

	[CompilerGenerated]
	public override void remove_Stopped(Action value) { }

	private void RemoveFromAudioCulling() { }

	private void RemoveFromTickManager() { }

	protected override void RestorePlayback() { }

	public void ScaleMaxDistance(float value) { }

	[CompilerGenerated]
	private void set_CurrentMaxDistance(float value) { }

	[CompilerGenerated]
	private void set_EmptyClip(AudioClip value) { }

	[CompilerGenerated]
	private void set_IsAudible(bool value) { }

	[CompilerGenerated]
	private void set_IsStartDelayPassed(bool value) { }

	public override void set_Position(Vector3 value) { }

	[CompilerGenerated]
	public void set_Priority(int value) { }

	[CompilerGenerated]
	public void set_RequiresVirtualSchedule(bool value) { }

	[CompilerGenerated]
	private void set_State(EAudioPlayerState value) { }

	[CompilerGenerated]
	private void set_VirtualStartTime(double value) { }

	public void SetAudible(bool audible) { }

	public void SetMixerGroup(AudioMixerGroup group) { }

	public override void SetMute(bool muted, bool useFading = true) { }

	protected override void SetSpread(float value) { }

	private void Start() { }

	public override void Stop(bool immediate = false) { }

	private void SyncSourceState(bool forceRestore = false) { }

	protected void TryPassStartPlayingDelay() { }

	protected void UpdateFadeOutTime(float value) { }

	protected override void UpdateParameters(float dt) { }

	public override void UpdateSpatialBlend(float value) { }

	public override void UpdateSpread(float value) { }

	protected override void UpdateTimers(float dt) { }

	public override void UpdateVirtualTimers() { }

}

