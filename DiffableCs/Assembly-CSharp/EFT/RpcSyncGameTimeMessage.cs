namespace EFT;

public sealed class RpcSyncGameTimeMessage : ISerializableMessage
{
	[CompilerGenerated]
	private long <Time>k__BackingField; //Field offset: 0x10

	public long Time
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public RpcSyncGameTimeMessage() { }

	public RpcSyncGameTimeMessage(long time) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public long get_Time() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_Time(long value) { }

}

