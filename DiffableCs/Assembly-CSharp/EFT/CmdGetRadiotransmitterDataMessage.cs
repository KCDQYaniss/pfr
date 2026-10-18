namespace EFT;

public sealed class CmdGetRadiotransmitterDataMessage : ISerializableMessage
{
	[CompilerGenerated]
	private string <PlayerProfileID>k__BackingField; //Field offset: 0x10

	public private string PlayerProfileID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public CmdGetRadiotransmitterDataMessage() { }

	public CmdGetRadiotransmitterDataMessage(string playerProfileID) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public string get_PlayerProfileID() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_PlayerProfileID(string value) { }

}

