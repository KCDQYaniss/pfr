namespace EFT;

public sealed class RpcGameStartingMessage : ISerializableMessage
{
	[CompilerGenerated]
	private int <Seconds>k__BackingField; //Field offset: 0x10

	public int Seconds
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RpcGameStartingMessage() { }

	public RpcGameStartingMessage(int seconds) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public int get_Seconds() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_Seconds(int value) { }

}

