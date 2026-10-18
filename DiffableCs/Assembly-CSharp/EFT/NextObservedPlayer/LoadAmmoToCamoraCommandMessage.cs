namespace EFT.NextObservedPlayer;

public sealed class LoadAmmoToCamoraCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool LoadAmmo; //Field offset: 0x10
	public bool RemoveShell; //Field offset: 0x11
	public int CamoraIndex; //Field offset: 0x14
	public MongoID AmmoToLoad; //Field offset: 0x18

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public LoadAmmoToCamoraCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

