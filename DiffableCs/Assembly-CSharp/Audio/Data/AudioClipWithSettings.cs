namespace Audio.Data;

public class AudioClipWithSettings
{
	public AudioClip clip; //Field offset: 0x10
	public int maxDistance; //Field offset: 0x18
	[Range(0, 1)]
	public float volume; //Field offset: 0x1C

	public AudioClipWithSettings() { }

}

