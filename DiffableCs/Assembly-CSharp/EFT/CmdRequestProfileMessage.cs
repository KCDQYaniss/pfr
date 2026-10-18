namespace EFT;

public sealed class CmdRequestProfileMessage : ISerializableMessage
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10

	public private string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public CmdRequestProfileMessage() { }

	public CmdRequestProfileMessage(string id) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public string get_Id() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_Id(string value) { }

}

