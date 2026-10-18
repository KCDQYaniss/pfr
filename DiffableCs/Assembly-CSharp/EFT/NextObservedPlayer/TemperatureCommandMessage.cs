namespace EFT.NextObservedPlayer;

public class TemperatureCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public float Temperature; //Field offset: 0x10

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public TemperatureCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static TemperatureCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

