namespace EFT;

public sealed class VoipSettings
{
	[CompilerGenerated]
	private static readonly VoipSettings <Default>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <MicrophoneChecked>k__BackingField; //Field offset: 0x10
	public bool VoipEnabled; //Field offset: 0x11
	public VoipQualitySettings VoipQualitySettings; //Field offset: 0x18
	public PushToTalkSettings PushToTalkSettings; //Field offset: 0x20

	public static VoipSettings Default
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	public bool MicrophoneChecked
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static VoipSettings() { }

	public VoipSettings() { }

	public void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public static VoipSettings get_Default() { }

	[CompilerGenerated]
	public bool get_MicrophoneChecked() { }

	public void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_MicrophoneChecked(bool value) { }

	public virtual string ToString() { }

}

