namespace EFT.NextObservedPlayer;

public sealed class ReloadExternalMagazineCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public int AmmoInChamberCurrent; //Field offset: 0x10
	public int AmmoInChamberResult; //Field offset: 0x14
	public bool NeedToAddAmmoInChamber; //Field offset: 0x18
	public int ShellsInWeapon; //Field offset: 0x1C
	public int WeaponLevel; //Field offset: 0x20
	public bool InInventory; //Field offset: 0x24
	public bool MagInWeapon; //Field offset: 0x25
	public int AmmoInMag; //Field offset: 0x28
	public bool Malfunction; //Field offset: 0x2C
	public bool MagOutFromInventory; //Field offset: 0x2D
	public string SlotModeID; //Field offset: 0x30
	public ItemDescriptor NextMag; //Field offset: 0x38
	public bool IsQuickReload; //Field offset: 0x40
	public int OldMagAnimIndex; //Field offset: 0x44
	public int NewMagAnimIndex; //Field offset: 0x48
	public bool InMisfireMalfunction; //Field offset: 0x4C

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ReloadExternalMagazineCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

