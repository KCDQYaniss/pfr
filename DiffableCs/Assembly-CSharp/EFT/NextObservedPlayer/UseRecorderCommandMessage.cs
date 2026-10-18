namespace EFT.NextObservedPlayer;

public class UseRecorderCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public MongoID RecorderId; //Field offset: 0x10
	public ERecorderHandsAction ActionType; //Field offset: 0x28

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public UseRecorderCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

