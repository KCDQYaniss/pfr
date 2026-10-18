namespace EFT.NextObservedPlayer;

public sealed class SetStationaryWeaponCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public string StationaryWeaponId; //Field offset: 0x10
	public EStationaryCommand StationaryCommand; //Field offset: 0x18
	public int AmmoInMagCount; //Field offset: 0x1C
	public string MagazineSlotModeID; //Field offset: 0x20
	public ItemDescriptor Magazine; //Field offset: 0x28
	public string ChamberSlotModeID; //Field offset: 0x30
	[CanBeNull]
	public ItemDescriptor ChamberAmmo; //Field offset: 0x38

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SetStationaryWeaponCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

