namespace UnityEngine;

[RequireComponent(typeof(AudioBehaviour))]
public sealed class AudioLowPassFilter : Behaviour
{

	public float cutoffFrequency
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float lowpassResonanceQ
	{
		 set { } //Length: 94
	}

	public float get_cutoffFrequency() { }

	public void set_cutoffFrequency(float value) { }

	public void set_lowpassResonanceQ(float value) { }

}

