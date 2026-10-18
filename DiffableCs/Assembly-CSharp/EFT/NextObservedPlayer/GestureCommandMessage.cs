namespace EFT.NextObservedPlayer;

public class GestureCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public EInteraction Gesture; //Field offset: 0x10

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public GestureCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static GestureCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

