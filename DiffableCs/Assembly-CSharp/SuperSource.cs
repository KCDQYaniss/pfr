//Type is in global namespace

public class SuperSource : BetterSource
{
	protected AudioSource Source2; //Field offset: 0x130
	private BaseSpatialAudioSource _secondSourceSpatializer; //Field offset: 0x138
	private float _secondPreEffectsVolume; //Field offset: 0x140

	public virtual float EarlyReflectionsSendDB
	{
		 get { } //Length: 42
		 set { } //Length: 288
	}

	public virtual bool EnableReverb
	{
		 get { } //Length: 42
		 set { } //Length: 290
	}

	public virtual bool EnableSpatialization
	{
		 get { } //Length: 42
		 set { } //Length: 290
	}

	public virtual bool Loop
	{
		 get { } //Length: 90
		 set { } //Length: 194
	}

	public virtual float ReverbReach
	{
		 get { } //Length: 42
		 set { } //Length: 288
	}

	public virtual float ReverbSendDB
	{
		 get { } //Length: 42
		 set { } //Length: 288
	}

	public SuperSource() { }

	public virtual void Balance(float p) { }

	protected virtual float CalculateFinalVolume(int id) { }

	public virtual void Clear(float spatial = 1, float pitch = 1, float panStereo = 0) { }

	protected virtual void ClearClips() { }

	private AudioSource CreateSecondAudioSource() { }

	private BaseSpatialAudioSource CreateSecondSpatializer() { }

	public virtual float get_EarlyReflectionsSendDB() { }

	public virtual bool get_EnableReverb() { }

	public virtual bool get_EnableSpatialization() { }

	public virtual bool get_Loop() { }

	public virtual float get_ReverbReach() { }

	public virtual float get_ReverbSendDB() { }

	public virtual AudioClip GetClip(int id) { }

	public virtual float GetPitch(int clipIndex) { }

	public virtual float GetVolume(int id) { }

	public virtual void Mute(bool muted) { }

	protected virtual void OnInit() { }

	private void PlayInternal(AudioSource source, AudioClip clip, float preEffectsVolume) { }

	private void PlayScheduledInternal(AudioSource source, AudioClip clip, double time, float preEffectsVolume) { }

	protected virtual void PrepareClips(AudioClip clip1, AudioClip clip2) { }

	protected virtual void PreparePlayback(AudioClip clip1, AudioClip clip2, float balance, float volume) { }

	protected virtual void PrepareScheduledPlayback(AudioClip clip1, AudioClip clip2, float balance) { }

	public virtual void set_EarlyReflectionsSendDB(float value) { }

	public virtual void set_EnableReverb(bool value) { }

	public virtual void set_EnableSpatialization(bool value) { }

	public virtual void set_Loop(bool value) { }

	public virtual void set_ReverbReach(float value) { }

	public virtual void set_ReverbSendDB(float value) { }

	public virtual void SetBaseVolume(float volume) { }

	public virtual void SetClip(int id, AudioClip clip) { }

	public virtual void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	public virtual void SetDopplerLevel(float dopplerLevel = 0) { }

	public virtual void SetMixerGroup(AudioMixerGroup mixerGroup) { }

	public virtual void SetPanStereo(float pan = 0) { }

	public virtual void SetPitch(float p) { }

	public virtual void SetPitch(int clipIndex, float p) { }

	public virtual void SetPriority(int priority) { }

	public virtual void SetRolloff(float distance) { }

	public virtual void SetScheduledEndTime(double time) { }

	protected virtual void SetSourceActive(bool active) { }

	public virtual void SetSpatialBlend(float spatialBlend = 1) { }

	public virtual void SetSpread(float spread) { }

	public virtual void SetTime(float time) { }

	protected virtual void StartPlayback(AudioClip clip1, AudioClip clip2, float balance, float volume) { }

	protected virtual void StartScheduledPlayback(double time, AudioClip clip1, AudioClip clip2) { }

	protected virtual void StopPlayback() { }

	protected virtual void SyncPlayback() { }

	protected virtual void TrySetDefaultScheduledEndTime(double startTime, AudioClip clip1, AudioClip clip2, float pitch1, float pitch2) { }

	protected void TrySetDefaultScheduledEndTimeInternal(AudioSource source, double startTime, AudioClip clip, float pitch) { }

	public virtual void UpdateSourceVolume(float speed = 1) { }

	public virtual void UpdateSpatialParameters() { }

}

