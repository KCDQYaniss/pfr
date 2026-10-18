//Type is in global namespace

public class SimpleSource : BetterSource
{

	public virtual bool Loop
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public SimpleSource() { }

	public virtual void Balance(float p) { }

	protected virtual float CalculateFinalVolume(int id) { }

	protected virtual void ClearClips() { }

	public virtual bool get_Loop() { }

	public virtual AudioClip GetClip(int id) { }

	public virtual float GetVolume(int id) { }

	public virtual void Mute(bool muted) { }

	protected virtual void OnInit() { }

	protected virtual void PrepareClips(AudioClip clip1, AudioClip clip2) { }

	protected virtual void PreparePlayback(AudioClip clip1, AudioClip clip2, float balance, float volume) { }

	protected virtual void PrepareScheduledPlayback(AudioClip clip1, AudioClip clip2, float balance) { }

	public virtual void set_Loop(bool value) { }

	public virtual void SetBaseVolume(float volume) { }

	public virtual void SetClip(int id, AudioClip clip) { }

	public virtual void SetDopplerLevel(float dopplerLevel = 0) { }

	public virtual void SetMixerGroup(AudioMixerGroup mixerGroup) { }

	public virtual void SetPanStereo(float pan = 0) { }

	public virtual void SetPitch(int clipIndex, float p) { }

	public virtual void SetPitch(float p) { }

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

	public virtual void UpdateSourceVolume(float speed = 1) { }

}

