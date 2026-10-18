namespace EFT.NextObservedPlayer;

public sealed class ReloadCylinderMagazineCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public MongoID AmmoForLoad; //Field offset: 0x10
	public bool ReloadFast; //Field offset: 0x28
	public int CurrentCamoraIndex; //Field offset: 0x2C
	public int WeaponLevel; //Field offset: 0x30
	public bool InInventory; //Field offset: 0x34
	public int AmmoInMag; //Field offset: 0x38
	public int FreeCamorasCount; //Field offset: 0x3C
	public List FreeCamoras; //Field offset: 0x40
	public int ShellsCount; //Field offset: 0x48
	public List Shells; //Field offset: 0x50

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ReloadCylinderMagazineCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

