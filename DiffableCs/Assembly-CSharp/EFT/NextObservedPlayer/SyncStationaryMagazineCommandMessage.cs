namespace EFT.NextObservedPlayer;

public sealed class SyncStationaryMagazineCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public string StationaryWeaponID; //Field offset: 0x10
	public string SlotModeID; //Field offset: 0x18
	public ItemDescriptor Items; //Field offset: 0x20

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SyncStationaryMagazineCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

