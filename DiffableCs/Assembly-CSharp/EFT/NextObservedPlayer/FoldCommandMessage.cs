namespace EFT.NextObservedPlayer;

public sealed class FoldCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public MongoID ItemId; //Field offset: 0x10
	public bool Folded; //Field offset: 0x28
	public bool IsInInventory; //Field offset: 0x29

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public FoldCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static FoldCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

