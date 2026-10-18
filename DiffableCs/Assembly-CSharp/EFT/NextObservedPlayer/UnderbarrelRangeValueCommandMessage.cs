namespace EFT.NextObservedPlayer;

public class UnderbarrelRangeValueCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public int RangeValue; //Field offset: 0x10
	public int LastRangeValue; //Field offset: 0x14

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public UnderbarrelRangeValueCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

