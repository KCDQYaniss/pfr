namespace EFT.NextObservedPlayer;

public sealed class RechamberCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public Nullable AmmoToLoad; //Field offset: 0x10
	public Nullable ShellToUnload; //Field offset: 0x30
	public Nullable AmmoToUnload; //Field offset: 0x50
	public bool InInventory; //Field offset: 0x70
	public bool InMisfireMalfunction; //Field offset: 0x71

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public RechamberCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

