namespace EFT;

public sealed class CmdOnPlayerKeeperStatisticsChangedMessage : ISerializableMessage
{
	[CompilerGenerated]
	private string <PlayerProfileID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <StatisticsType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <ValueToSet>k__BackingField; //Field offset: 0x20

	public private string PlayerProfileID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private string StatisticsType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int ValueToSet
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CmdOnPlayerKeeperStatisticsChangedMessage() { }

	public CmdOnPlayerKeeperStatisticsChangedMessage(string playerProfileID, string statisticsType, int valueToSet) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public string get_PlayerProfileID() { }

	[CompilerGenerated]
	public string get_StatisticsType() { }

	[CompilerGenerated]
	public int get_ValueToSet() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_PlayerProfileID(string value) { }

	[CompilerGenerated]
	private void set_StatisticsType(string value) { }

	[CompilerGenerated]
	private void set_ValueToSet(int value) { }

}

