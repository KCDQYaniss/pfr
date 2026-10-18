namespace EFT.NextObservedPlayer;

public sealed class InsertMagazineCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool InMisfireMalfunction; //Field offset: 0x10
	public int MagTypeCurrent; //Field offset: 0x14
	public int MagTypeNew; //Field offset: 0x18
	public int AmmoInChamberCurrent; //Field offset: 0x1C
	public int AmmoInChamberResult; //Field offset: 0x20
	public int AmmoInMag; //Field offset: 0x24
	public bool NeedToAddAmmoInChamber; //Field offset: 0x28
	public int ShellsInWeapon; //Field offset: 0x2C
	public int WeaponLevel; //Field offset: 0x30
	public bool Boltcatch; //Field offset: 0x34
	public bool ForceEmptyChamber; //Field offset: 0x35
	public string WeaponItemID; //Field offset: 0x38
	public string SlotModeID; //Field offset: 0x40
	public ItemDescriptor Items; //Field offset: 0x48

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public InsertMagazineCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

