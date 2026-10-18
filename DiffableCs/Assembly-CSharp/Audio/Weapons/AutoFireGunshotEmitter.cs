namespace Audio.Weapons;

public sealed class AutoFireGunshotEmitter : IAudioGunshotEmitter, IDisposable
{
	private sealed class PendingFade
	{
		public BetterSource target; //Field offset: 0x10
		public BetterSource trigger; //Field offset: 0x18
		public float fadeDuration; //Field offset: 0x20
		public bool hasStarted; //Field offset: 0x24

		public PendingFade() { }

	}

	private readonly Transform _soundTransform; //Field offset: 0x10
	private readonly IAudioScheduleService _scheduler; //Field offset: 0x18
	private readonly IBetterSourceCustomPool _sourcePool; //Field offset: 0x20
	private readonly WeaponPlaybackSettings _settings; //Field offset: 0x28
	private AudioMixerGroup _currentMixerGroup; //Field offset: 0x30
	private float _currentFadeTime; //Field offset: 0x38
	private bool _occlusionEnabled; //Field offset: 0x3C
	private bool _reverbEnabled; //Field offset: 0x3D
	private double _nextIdealShotTime; //Field offset: 0x40
	private BetterSource _lastUsedSource; //Field offset: 0x48
	private readonly List _pendingFades; //Field offset: 0x50
	private readonly float _sequenceResetMultiplier; //Field offset: 0x58
	private bool _isDisposed; //Field offset: 0x5C
	private float _plannedFadeTime; //Field offset: 0x60
	[CompilerGenerated]
	private double <LastScheduledDspTime>k__BackingField; //Field offset: 0x68

	public override bool HasPendingFades
	{
		 get { } //Length: 69
	}

	public private override double LastScheduledDspTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public AutoFireGunshotEmitter(Transform soundTransform, WeaponPlaybackSettings settings, IBetterSourceCustomPool sourcePool, IServerTimeProvider serverTimeProvider) { }

	private void AdjustFadeTimeForLead(float leadSec, float beatDuration) { }

	public override void Dispose() { }

	public override void EnabledOcclusion(bool enabled) { }

	public override void EnabledReverb(bool enabled) { }

	public override bool get_HasPendingFades() { }

	[CompilerGenerated]
	public override double get_LastScheduledDspTime() { }

	public override void RegisterInOcclusionProcess(IObserverToPlayerBridge playerBridge) { }

	public override void Reset() { }

	public override void ScheduleShotSound(ShotPlaybackContext playbackContext) { }

	[CompilerGenerated]
	private void set_LastScheduledDspTime(double value) { }

	private void SetFadeTime(float fadeTime = 0.1) { }

	public override void SetMixerGroup(AudioMixerGroup mixerGroup) { }

	public override void Tick(double dspNow) { }

	private void TrackPendingFade(BetterSource sourceToPlay, double scheduledPlayTime) { }

	private void UpdatePoolSize(in ShotPlaybackContext context, double scheduledPlayTime) { }

}

