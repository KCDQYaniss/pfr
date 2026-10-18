namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
public class AudioMixerSnapshot : Object
{

	[NativeProperty]
	public AudioMixer audioMixer
	{
		 get { } //Length: 78
	}

	internal AudioMixerSnapshot() { }

	public AudioMixer get_audioMixer() { }

	public void TransitionTo(float timeToReach) { }

}

