namespace Audio.ReverbSubsystem;

public class ReverbSuperSource : SuperSource
{
	[SerializeField]
	private AudioSource _reverbSourceA; //Field offset: 0x148
	[SerializeField]
	private AudioSource _reverbSourceB; //Field offset: 0x150
	[SerializeField]
	private BaseSpatialAudioSource _spatializerA; //Field offset: 0x158
	[SerializeField]
	private BaseSpatialAudioSource _spatializerB; //Field offset: 0x160
	private AudioSourcePrewarmer _prewarmer; //Field offset: 0x168
	private bool _enabledPrewarm; //Field offset: 0x170

	public virtual bool Loop
	{
		 get { } //Length: 90
		 set { } //Length: 385
	}

	public ReverbSuperSource() { }

	public virtual void Balance(float p) { }

	public virtual bool get_Loop() { }

	public virtual void Mute(bool muted) { }

	private void PlayInternal(AudioSource reverbSource) { }

	private void PlayScheduledInternal(AudioSource reverbSource, double time) { }

	protected virtual void PrepareClips(AudioClip clip1, AudioClip clip2) { }

	protected virtual void PreparePlayback(AudioClip clip1, AudioClip clip2, float balance, float volume) { }

	private void PreparePlaybackInternal(AudioSource reverbSource, AudioSource donorSource) { }

	protected virtual void PrepareScheduledPlayback(AudioClip clip1, AudioClip clip2, float balance) { }

	private void PrepareScheduledPlaybackInternal(AudioSource reverbSource, AudioSource donorSource) { }

	private void Prewarm(AudioSource source, BaseSpatialAudioSource spatializer) { }

	private void ResetReverbComponents() { }

	public virtual void set_Loop(bool value) { }

	public virtual void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	public virtual void SetMixerGroup(AudioMixerGroup mixerGroup) { }

	public virtual void SetPitch(int clipIndex, float p) { }

	public virtual void SetPitch(float p) { }

	public virtual void SetPriority(int priority) { }

	public virtual void SetScheduledEndTime(double time) { }

	protected virtual void SetSourceActive(bool active) { }

	private void SetSpatialSettings(BaseSpatialAudioSource spatializer) { }

	public virtual void SetSpread(float spread) { }

	public virtual void SetTime(float time) { }

	protected virtual void StartPlayback(AudioClip clip1, AudioClip clip2, float balance, float volume) { }

	protected virtual void StartScheduledPlayback(double time, AudioClip clip1, AudioClip clip2) { }

	protected virtual void StopPlayback() { }

	protected virtual void SyncPlayback() { }

	private void SyncReverbSource(AudioSource reverb, AudioSource donor, double startTime) { }

	protected virtual void TrySetDefaultScheduledEndTime(double startTime, AudioClip clip1, AudioClip clip2, float pitch1, float pitch2) { }

	public virtual void UpdateSpatialParameters() { }

}

