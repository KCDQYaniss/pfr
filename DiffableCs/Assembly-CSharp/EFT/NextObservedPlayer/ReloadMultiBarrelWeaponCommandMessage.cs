namespace EFT.NextObservedPlayer;

public sealed class ReloadMultiBarrelWeaponCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public Nullable[] AmmoToLoad; //Field offset: 0x10
	public Nullable[] ShellToUnload; //Field offset: 0x18
	public int AmmoInChambers; //Field offset: 0x20
	public bool InInventory; //Field offset: 0x24

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ReloadMultiBarrelWeaponCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

