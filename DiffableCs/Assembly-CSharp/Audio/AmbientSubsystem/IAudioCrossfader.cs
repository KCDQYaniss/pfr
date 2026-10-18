namespace Audio.AmbientSubsystem;

public interface IAudioCrossfader
{

	public AudioSource CurrentSource
	{
		 get { } //Length: 0
	}

	public bool IsCrossfadeStarted
	{
		 get { } //Length: 0
	}

	public AudioSource MixSource
	{
		 get { } //Length: 0
	}

	public AudioSource get_CurrentSource() { }

	public bool get_IsCrossfadeStarted() { }

	public AudioSource get_MixSource() { }

	public void StartCrossfade(float duration = 1, float speed = 1, float startVolume = 1, float endVolume = 0, bool startFromRndTime = true, Action callback = null) { }

	public void Stop() { }

}

