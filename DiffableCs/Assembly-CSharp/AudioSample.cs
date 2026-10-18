//Type is in global namespace

public class AudioSample
{
	public readonly AudioClip Clip1; //Field offset: 0x10
	public float Volume; //Field offset: 0x18
	public float Pitch; //Field offset: 0x1C
	public readonly double Start; //Field offset: 0x20
	public readonly double End; //Field offset: 0x28

	public AudioSample() { }

	public AudioSample(AudioClip clip, double start, double end) { }

}

