namespace Audio.ReverbSubsystem;

public class ReverbSimpleSource : SimpleSource
{
	[SerializeField]
	private AudioSource _reverbSource; //Field offset: 0x130
	[SerializeField]
	private BaseSpatialAudioSource _spatializer; //Field offset: 0x138
	private AudioSourcePrewarmer _prewarmer; //Field offset: 0x140
	private bool _enabledPrewarm; //Field offset: 0x148

	public virtual bool Loop
	{
		 get { } //Length: 90
		 set { } //Length: 199
	}

	public ReverbSimpleSource() { }

	public virtual bool get_Loop() { }

	public virtual void Mute(bool muted) { }

	protected virtual void PrepareClips(AudioClip clip1, AudioClip clip2) { }

	protected virtual void PreparePlayback(AudioClip clip1, AudioClip clip2, float balance, float volume) { }

	protected virtual void PrepareScheduledPlayback(AudioClip clip1, AudioClip clip2, float balance) { }

	private void Prewarm() { }

	private void ResetReverbComponents() { }

	public virtual void set_Loop(bool value) { }

	public virtual void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	public virtual void SetMixerGroup(AudioMixerGroup mixerGroup) { }

	public virtual void SetPitch(float p) { }

	public virtual void SetPitch(int clipIndex, float p) { }

	public virtual void SetPriority(int priority) { }

	protected virtual void SetSourceActive(bool active) { }

	public virtual void SetSpread(float spread) { }

	public virtual void SetTime(float time) { }

	protected virtual void StartPlayback(AudioClip clip1, AudioClip clip2, float balance, float volume) { }

	protected virtual void StartScheduledPlayback(double time, AudioClip clip1, AudioClip clip2) { }

	protected virtual void StopPlayback() { }

	protected virtual void SyncPlayback() { }

	protected virtual void TrySetDefaultScheduledEndTime(double startTime, AudioClip clip1, AudioClip clip2, float pitch1, float pitch2) { }

	public virtual void UpdateParameters() { }

	public virtual void UpdateSourceVolume(float speed = 1) { }

	public virtual void UpdateSpatialParameters() { }

}

