namespace EFT;

public sealed class RpcReceiveProfileMessage : ISerializableMessage
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; //Field offset: 0x18

	public byte[] Data
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public RpcReceiveProfileMessage() { }

	public RpcReceiveProfileMessage(string id, byte[] data) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public byte[] get_Data() { }

	[CompilerGenerated]
	public string get_Id() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_Data(byte[] value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

}

