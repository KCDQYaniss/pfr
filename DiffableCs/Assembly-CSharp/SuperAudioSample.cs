//Type is in global namespace

public class SuperAudioSample : AudioSample
{
	public readonly AudioClip Clip2; //Field offset: 0x30
	public readonly float Balance; //Field offset: 0x38

	public SuperAudioSample(AudioClip clip1, AudioClip clip2, float balance, double start, double end) { }

	public void PlayOn(SuperSource source) { }

}

