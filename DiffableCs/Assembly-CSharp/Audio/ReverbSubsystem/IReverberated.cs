namespace Audio.ReverbSubsystem;

public interface IReverberated
{

	public float EarlyReflectionsSendDB
	{
		 get { } //Length: 0
	}

	public bool EnableDirectSound
	{
		 get { } //Length: 0
	}

	public bool EnableReverb
	{
		 get { } //Length: 0
	}

	public float ReverbReach
	{
		 get { } //Length: 0
	}

	public float ReverbSendDB
	{
		 get { } //Length: 0
	}

	public float get_EarlyReflectionsSendDB() { }

	public bool get_EnableDirectSound() { }

	public bool get_EnableReverb() { }

	public float get_ReverbReach() { }

	public float get_ReverbSendDB() { }

}

