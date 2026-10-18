namespace EFT.NextObservedPlayer;

public sealed class HeadGearToggleCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public MongoID ItemId; //Field offset: 0x10
	public bool State; //Field offset: 0x28

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public HeadGearToggleCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static HeadGearToggleCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

