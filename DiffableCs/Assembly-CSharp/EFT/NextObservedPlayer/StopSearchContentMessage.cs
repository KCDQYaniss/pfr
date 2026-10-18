namespace EFT.NextObservedPlayer;

public class StopSearchContentMessage : ICommandMessage, ISerializableMessage, IDisposable
{

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public StopSearchContentMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

