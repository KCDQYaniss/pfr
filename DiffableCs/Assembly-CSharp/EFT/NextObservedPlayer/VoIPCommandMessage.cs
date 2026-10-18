namespace EFT.NextObservedPlayer;

public class VoIPCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public EVoipState VoIPState; //Field offset: 0x10

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public VoIPCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static VoIPCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

