namespace EFT;

public sealed class RpcGetNewQuestTemplatesMessage : ISerializableMessage
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

	public RpcGetNewQuestTemplatesMessage() { }

	public RpcGetNewQuestTemplatesMessage(byte[] data) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public byte[] get_Data() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_Data(byte[] value) { }

}

