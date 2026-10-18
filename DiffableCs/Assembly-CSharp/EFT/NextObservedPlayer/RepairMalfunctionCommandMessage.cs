namespace EFT.NextObservedPlayer;

public sealed class RepairMalfunctionCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public EMalfunctionState MalfunctionState; //Field offset: 0x10
	public Nullable AmmoToFire; //Field offset: 0x18
	public Nullable MalfunctionedAmmo; //Field offset: 0x38
	public Nullable AmmoToLoadAfterRepair; //Field offset: 0x58
	public int AmmoInMag; //Field offset: 0x78

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public RepairMalfunctionCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

