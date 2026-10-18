namespace EFT.NextObservedPlayer;

public class SetChamberStateCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool CanReload; //Field offset: 0x10
	public bool Active; //Field offset: 0x11
	public bool ResetLeftHand; //Field offset: 0x12
	public int AmmoInChamber; //Field offset: 0x14
	public int ShellsInWeapon; //Field offset: 0x18
	public bool InInventory; //Field offset: 0x1C

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SetChamberStateCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

