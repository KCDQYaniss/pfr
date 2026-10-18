namespace EFT.NextObservedPlayer;

public sealed class LoadAmmoToUnderbarrelWeaponCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public MongoID AmmoToLoad; //Field offset: 0x10
	public Nullable ShellToUnload; //Field offset: 0x28

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public LoadAmmoToUnderbarrelWeaponCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

