namespace Dissonance.Audio.Playback;

internal interface IJitterEstimator
{

	public float Confidence
	{
		 get { } //Length: 0
	}

	public float Jitter
	{
		 get { } //Length: 0
	}

	public float get_Confidence() { }

	public float get_Jitter() { }

}

