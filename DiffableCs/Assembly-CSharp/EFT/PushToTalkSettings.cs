namespace EFT;

public sealed class PushToTalkSettings
{
	[CompilerGenerated]
	private static readonly PushToTalkSettings <Default>k__BackingField; //Field offset: 0x0
	public float SpeakingSecondsLimit; //Field offset: 0x10
	public float SpeakingSecondsInterval; //Field offset: 0x14
	public byte ActivationsLimit; //Field offset: 0x18
	public float ActivationsInterval; //Field offset: 0x1C
	public float BlockingTime; //Field offset: 0x20
	public byte AlertDistanceMeters; //Field offset: 0x24
	public byte HearingDistance; //Field offset: 0x25
	public float AbuseTraceSeconds; //Field offset: 0x28

	public static PushToTalkSettings Default
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static PushToTalkSettings() { }

	public PushToTalkSettings() { }

	public void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public static PushToTalkSettings get_Default() { }

	public void Serialize(NetworkWriter writer) { }

	public virtual string ToString() { }

}

