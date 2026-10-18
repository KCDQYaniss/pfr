namespace Audio.QueueSpeakerSystem;

public interface IQueueSpeaker : IDisposable
{

	public bool IsPlaying
	{
		 get { } //Length: 0
	}

	public bool get_IsPlaying() { }

	public void ManualUpdate(float dt = 0) { }

	public void Play(SoundBankWithSettings bank, bool stereo = false) { }

	public void Stop() { }

}

