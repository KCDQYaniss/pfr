namespace EFT.NextObservedPlayer;

public class DoorUnlockInteractionMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public string InteractionDoor; //Field offset: 0x10
	public string InteractionDoorKey; //Field offset: 0x18
	public bool InteractionDoorResult; //Field offset: 0x20

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public DoorUnlockInteractionMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static DoorUnlockInteractionMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

