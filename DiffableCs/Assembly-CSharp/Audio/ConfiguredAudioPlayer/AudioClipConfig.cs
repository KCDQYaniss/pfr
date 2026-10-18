namespace Audio.ConfiguredAudioPlayer;

public class AudioClipConfig : IEquatable
{
	public AudioClip clip; //Field offset: 0x10
	[Range(0, 1)]
	public float volume; //Field offset: 0x18
	public float pitch; //Field offset: 0x1C
	public bool loop; //Field offset: 0x20
	public float fadeInTime; //Field offset: 0x24
	public float fadeOutTime; //Field offset: 0x28
	[Range(0, 1)]
	public float spatialBlend; //Field offset: 0x2C

	public AudioClipConfig() { }

	public override bool Equals(AudioClipConfig other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(AudioClipConfig a, AudioClipConfig b) { }

	public static bool op_Inequality(AudioClipConfig a, AudioClipConfig b) { }

}

