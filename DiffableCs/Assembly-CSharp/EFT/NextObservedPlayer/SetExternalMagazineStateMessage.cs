namespace EFT.NextObservedPlayer;

public class SetExternalMagazineStateMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool CanReload; //Field offset: 0x10
	public bool Active; //Field offset: 0x11
	public bool ResetLeftHand; //Field offset: 0x12
	public int ShellsInWeapon; //Field offset: 0x14
	public bool InInventory; //Field offset: 0x18
	public bool MagInWeapon; //Field offset: 0x19

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SetExternalMagazineStateMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

