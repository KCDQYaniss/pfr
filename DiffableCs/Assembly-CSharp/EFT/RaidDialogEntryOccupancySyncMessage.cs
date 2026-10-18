namespace EFT;

public sealed class RaidDialogEntryOccupancySyncMessage : ISerializableMessage
{
	[CompilerGenerated]
	private string <PointId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <OccupantRaidID>k__BackingField; //Field offset: 0x18

	public private int OccupantRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string PointId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public RaidDialogEntryOccupancySyncMessage() { }

	public RaidDialogEntryOccupancySyncMessage(string pointId, int occupantRaidID) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public int get_OccupantRaidID() { }

	[CompilerGenerated]
	public string get_PointId() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_OccupantRaidID(int value) { }

	[CompilerGenerated]
	private void set_PointId(string value) { }

}

