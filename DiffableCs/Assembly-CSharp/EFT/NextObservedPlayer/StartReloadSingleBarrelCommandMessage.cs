namespace EFT.NextObservedPlayer;

public sealed class StartReloadSingleBarrelCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public MongoID AmmoToLoad; //Field offset: 0x10
	public Nullable ShellToUnload; //Field offset: 0x28
	public Nullable AmmoToUnload; //Field offset: 0x48
	public int WeaponLevel; //Field offset: 0x68
	public bool InInventory; //Field offset: 0x6C

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public StartReloadSingleBarrelCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

