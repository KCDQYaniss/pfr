namespace EFT;

public sealed class CmdGetTraderServicesDataMessage : ISerializableMessage
{
	[CompilerGenerated]
	private string <PlayerProfileID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <TraderId>k__BackingField; //Field offset: 0x18

	public private string PlayerProfileID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public string TraderId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public CmdGetTraderServicesDataMessage() { }

	public CmdGetTraderServicesDataMessage(string playerProfileID, string traderId) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public string get_PlayerProfileID() { }

	[CompilerGenerated]
	public string get_TraderId() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_PlayerProfileID(string value) { }

	[CompilerGenerated]
	public void set_TraderId(string value) { }

}

