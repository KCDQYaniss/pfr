namespace EFT.NextObservedPlayer;

public sealed class ChangeModOnItemCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool ModAdded; //Field offset: 0x10
	public MongoID RootItemId; //Field offset: 0x18
	public ItemAddressDescriptor Address; //Field offset: 0x30
	[Nullable]
	public ItemDescriptor ModItem; //Field offset: 0x38

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ChangeModOnItemCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ChangeModOnItemCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

