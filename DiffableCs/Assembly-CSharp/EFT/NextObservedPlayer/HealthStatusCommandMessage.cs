namespace EFT.NextObservedPlayer;

public class HealthStatusCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool isAlive; //Field offset: 0x10
	public ETagStatus HealthStatus; //Field offset: 0x14

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public HealthStatusCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static HealthStatusCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

