namespace EFT.NextObservedPlayer;

public class TripwireSoundInteractionCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool isSuccess; //Field offset: 0x10
	public bool hasMultiTool; //Field offset: 0x11
	public EInteractionStatus interactionStatus; //Field offset: 0x14

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public TripwireSoundInteractionCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static TripwireSoundInteractionCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

