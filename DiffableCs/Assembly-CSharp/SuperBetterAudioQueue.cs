//Type is in global namespace

public class SuperBetterAudioQueue : BetterAudioQueue
{
	private Queue _samples; //Field offset: 0x18
	private double _nextUpdate; //Field offset: 0x20
	private double _scheduledEndTime; //Field offset: 0x28
	private int _lastSource; //Field offset: 0x30

	public SuperBetterAudioQueue() { }

	public void Balance(float distance) { }

	public void EnableStereo(bool stereo = false) { }

	public void Enqueue(AudioClip clip1, AudioClip clip2, float balance, double startTime, float clipTime = 0, float volume = 1, float pitch = 1) { }

	public void IncludeInOcclusionProcess(bool included) { }

	public void Initialize(BetterSource source1, BetterSource source2) { }

	public void SetMixerGroup(AudioMixerGroup group) { }

	public void SetPitch(float pitch) { }

	public void SetPriority(int priority) { }

	public void SetRolloff(float distance) { }

	public void SetSpatialBlend(float spatialBlend) { }

	public virtual void Update() { }

}

