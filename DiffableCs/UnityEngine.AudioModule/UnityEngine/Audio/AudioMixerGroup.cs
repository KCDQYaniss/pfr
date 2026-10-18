namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
public class AudioMixerGroup : Object
{

	[NativeProperty]
	public AudioMixer audioMixer
	{
		 get { } //Length: 78
	}

	internal AudioMixerGroup() { }

	public AudioMixer get_audioMixer() { }

}

