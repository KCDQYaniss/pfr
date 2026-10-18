//Type is in global namespace

public class SimpleBetterAudioQueue : BetterAudioQueue
{
	private Queue _samples; //Field offset: 0x18
	private double _nextUpdate; //Field offset: 0x20
	private double _scheduledEndTime; //Field offset: 0x28
	private int _lastSource; //Field offset: 0x30

	public SimpleBetterAudioQueue(BetterSource[] audioSources) { }

	public void Enqueue(AudioClip clip1, float startTime, float clipTime = 0, float volume = 1, float pitch = 1) { }

	public virtual void Update() { }

}

