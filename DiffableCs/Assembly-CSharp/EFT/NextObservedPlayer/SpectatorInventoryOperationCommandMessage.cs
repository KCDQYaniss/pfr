namespace EFT.NextObservedPlayer;

public sealed class SpectatorInventoryOperationCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public InventoryOperationDescriptor Descriptor; //Field offset: 0x10

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SpectatorInventoryOperationCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

