namespace EFT.NextObservedPlayer;

public class DoorBreachInteractionMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public string InteractionDoor; //Field offset: 0x10
	public bool InteractionDoorResult; //Field offset: 0x18

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public DoorBreachInteractionMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static DoorBreachInteractionMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

