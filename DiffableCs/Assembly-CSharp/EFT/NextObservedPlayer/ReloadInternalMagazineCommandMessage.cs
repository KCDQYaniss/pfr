namespace EFT.NextObservedPlayer;

public class ReloadInternalMagazineCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public int AmmoInChamber; //Field offset: 0x10
	public int ShellsInWeapon; //Field offset: 0x14
	public int WeaponLevel; //Field offset: 0x18
	public bool InInventory; //Field offset: 0x1C
	public EMalfunctionState MalfunctionState; //Field offset: 0x20
	public int AmmoInStack; //Field offset: 0x24

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ReloadInternalMagazineCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

