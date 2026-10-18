namespace Audio.RadioSystem;

public interface IBroadcastPlayer
{

	public ERadioStation RadioStation
	{
		 get { } //Length: 0
	}

	public void ChangeStation(ERadioStation station) { }

	public ERadioStation get_RadioStation() { }

	public void Initialize() { }

	public void Mute(bool value) { }

	public void Stop() { }

	public void SyncBroadcast(AudioClip clip, double time = 0, float crossfadeDuration = 1) { }

}

