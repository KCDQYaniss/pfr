namespace EFT;

public sealed class RpcSendBinaryDataMessage : ISerializableMessage
{
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; //Field offset: 0x10

	public byte[] Data
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public RpcSendBinaryDataMessage() { }

	public RpcSendBinaryDataMessage(byte[] data) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public byte[] get_Data() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_Data(byte[] value) { }

}

