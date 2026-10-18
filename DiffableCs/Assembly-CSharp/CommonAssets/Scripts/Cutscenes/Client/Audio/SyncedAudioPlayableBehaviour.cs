namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public class SyncedAudioPlayableBehaviour : PlayableBehaviour
{
	private const float DESYNC_THRESHOLD = 0.05; //Field offset: 0x0
	private const float AGGRESSIVE_PITCH_LERP_SPEED = 0.7; //Field offset: 0x0
	private const float PITCH_RESET_LERP_SPEED = 0.2; //Field offset: 0x0
	private const float NEAR_CLIP_END_THRESHOLD = 0.05; //Field offset: 0x0
	private const float PITCH_RESET_THRESHOLD = 0.001; //Field offset: 0x0
	private const float SHORT_CLIP_THRESHOLD = 5; //Field offset: 0x0
	private const float REFERENCE_FPS = 60; //Field offset: 0x0
	private const float SMOOTH_PITCH_LERP_SPEED = 0.4; //Field offset: 0x0
	private const float DEFAULT_FRAME_TIME = 0.016666668; //Field offset: 0x0
	private const float SHORT_CLIP_ADAPTIVE_THRESHOLD_MIN = 0.6; //Field offset: 0x0
	private const float LOOP_WRAP_THRESHOLD_SHORT_CLIP = 10; //Field offset: 0x0
	private const float LOOP_WRAP_THRESHOLD_SHORT = 0.3; //Field offset: 0x0
	private const float LOOP_WRAP_THRESHOLD_LONG = 0.5; //Field offset: 0x0
	private const float CLIP_END_EPSILON_PERCENT = 0.01; //Field offset: 0x0
	private const float CLIP_END_EPSILON_ABSOLUTE_MIN = 0.001; //Field offset: 0x0
	private const float MAX_FRAME_TIME_FOR_TRACKING = 1; //Field offset: 0x0
	private const float NORMAL_PITCH = 1; //Field offset: 0x0
	private const float STABLE_PERIOD_HYSTERESIS_MULTIPLIER = 1.5; //Field offset: 0x0
	private const float AGGRESSIVE_PITCH_AHEAD = 1.05; //Field offset: 0x0
	private const float DESYNC_STABLE_DURATION = 0.2; //Field offset: 0x0
	private const float SMOOTH_CORRECTION_THRESHOLD = 0.12; //Field offset: 0x0
	private const float AGGRESSIVE_CORRECTION_THRESHOLD = 0.25; //Field offset: 0x0
	private const int FRAME_TIME_SAMPLE_COUNT = 10; //Field offset: 0x0
	private const float FREEZE_DETECTION_MULTIPLIER = 10; //Field offset: 0x0
	private const float FREEZE_COOLDOWN_DURATION = 0.5; //Field offset: 0x0
	private const float AGGRESSIVE_PITCH_BEHIND = 0.95; //Field offset: 0x0
	private const float HARD_RESYNC_COOLDOWN_DURATION = 0.5; //Field offset: 0x0
	private const float FREEZE_GRACE_PERIOD = 0.5; //Field offset: 0x0
	private const float TIMELINE_JUMP_MULTIPLIER = 5; //Field offset: 0x0
	private const float TIMELINE_JUMP_MIN_THRESHOLD = 0.1; //Field offset: 0x0
	private const float NO_TIMESTAMP = -1; //Field offset: 0x0
	private const int WARMUP_FRAMES = 10; //Field offset: 0x0
	private const float MIN_PITCH_ADJUSTMENT = 0.005; //Field offset: 0x0
	private const float MAX_PITCH_ADJUSTMENT = 0.02; //Field offset: 0x0
	private AudioSource _audioSource; //Field offset: 0x10
	private bool _isPlaying; //Field offset: 0x18
	private double _previousTime; //Field offset: 0x20
	private int _framesSinceReady; //Field offset: 0x28
	private float _realTimeAtPlayStart; //Field offset: 0x2C
	private bool _hasStartedPlaying; //Field offset: 0x30
	private float _lastFrameRealTime; //Field offset: 0x34
	private int _frameTimeIndex; //Field offset: 0x38
	private float _averageFrameTime; //Field offset: 0x3C
	private readonly float[] _recentFrameTimes; //Field offset: 0x40
	private float _lastFreezeTime; //Field offset: 0x48
	private float _lastHardResyncTime; //Field offset: 0x4C
	private float _syncStableUntil; //Field offset: 0x50
	private float _nextAllowedLargeDeltaLogTime; //Field offset: 0x54
	private float _nextAllowedDesyncLogTime; //Field offset: 0x58
	private float _cachedAdaptiveThreshold; //Field offset: 0x5C
	private bool _gracePeriodLogged; //Field offset: 0x60
	public AudioClip clip; //Field offset: 0x68
	public AudioMixerGroup mixerGroup; //Field offset: 0x70
	public float volume; //Field offset: 0x78
	public bool loop; //Field offset: 0x7C

	public SyncedAudioPlayableBehaviour() { }

	private void ApplyAggressivePitchCorrection(float delta, float targetTime, float actualTime) { }

	private void ApplyPitchCorrection(float delta, float targetTime, float actualTime) { }

	private void ApplySmoothPitchCorrection(float delta, float targetTime, float actualTime) { }

	private void ApplySyncCorrection(float delta, float targetTime, float actualTime) { }

	private float CalculateSyncDelta(float targetTime, float actualTime) { }

	private bool DetectAndHandleTimelineJump(double currentTime, float targetTime) { }

	private void ForceResync(float targetTime) { }

	private float GetAdaptiveAggressiveThreshold() { }

	private void HandlePlaybackSync(double currentTime) { }

	private void HandleWarmupPhase(double currentTime) { }

	private void InitializeAudioSource() { }

	private bool IsNearClipEnd(float actualTime) { }

	private bool IsNearClipStart(float actualTime) { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	public virtual void OnPlayableCreate(Playable playable) { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	private void ResetPitchSmoothly(float baseLerpSpeed) { }

	private void ResetPitchToNormal() { }

	public void SetAudioSource(AudioSource audioSource) { }

	private void StartPlayback(double currentTime) { }

	private void ValidateClipSettings() { }

}

