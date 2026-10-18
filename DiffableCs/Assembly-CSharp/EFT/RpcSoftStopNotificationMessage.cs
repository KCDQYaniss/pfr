namespace EFT;

public sealed class RpcSoftStopNotificationMessage : ISerializableMessage
{
	[CompilerGenerated]
	private int <SessionSeconds>k__BackingField; //Field offset: 0x10

	public int SessionSeconds
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RpcSoftStopNotificationMessage() { }

	public RpcSoftStopNotificationMessage(int sessionSeconds) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public int get_SessionSeconds() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_SessionSeconds(int value) { }

}

