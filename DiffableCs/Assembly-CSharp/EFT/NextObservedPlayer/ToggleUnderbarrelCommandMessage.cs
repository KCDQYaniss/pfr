namespace EFT.NextObservedPlayer;

public class ToggleUnderbarrelCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool ToggleOn; //Field offset: 0x10

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ToggleUnderbarrelCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

