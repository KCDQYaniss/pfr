namespace EFT.NextObservedPlayer;

public class PickupCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool Pickup; //Field offset: 0x10

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public PickupCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static PickupCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

