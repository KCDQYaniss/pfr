namespace EFT.NextObservedPlayer;

public sealed class ChangeEquipCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public EquipmentSlot SlotType; //Field offset: 0x10
	public MongoID ItemId; //Field offset: 0x18
	[CanBeNull]
	public ItemDescriptor Item; //Field offset: 0x30

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ChangeEquipCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ChangeEquipCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

