namespace EFT.NextObservedPlayer;

public sealed class ReloadInternalMagWithOpenBoltMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public Nullable AmmoToLoadTemplate; //Field offset: 0x10
	public bool InInventory; //Field offset: 0x30
	public bool MagInWeapon; //Field offset: 0x31
	public bool IsExternalMag; //Field offset: 0x32
	public int AmmoPackCount; //Field offset: 0x34
	public int MagFreeSpace; //Field offset: 0x38
	public bool InMisfireMalfunction; //Field offset: 0x3C
	public bool HasAmmoInChamber; //Field offset: 0x3D

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ReloadInternalMagWithOpenBoltMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

