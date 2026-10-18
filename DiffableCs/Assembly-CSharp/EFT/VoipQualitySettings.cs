namespace EFT;

public sealed class VoipQualitySettings
{
	[CompilerGenerated]
	private static readonly VoipQualitySettings <Default>k__BackingField; //Field offset: 0x0
	public FrameSize FrameSize; //Field offset: 0x10
	public AudioQuality AudioQuality; //Field offset: 0x14
	public bool ForwardErrorCorrection; //Field offset: 0x18

	public static VoipQualitySettings Default
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static VoipQualitySettings() { }

	public VoipQualitySettings() { }

	public void Apply() { }

	public void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public static VoipQualitySettings get_Default() { }

	public void Serialize(NetworkWriter writer) { }

	public virtual string ToString() { }

}

