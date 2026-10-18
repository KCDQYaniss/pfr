namespace EFT.NextObservedPlayer;

public class ChangeFireModeCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public EFireMode FireMode; //Field offset: 0x10

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ChangeFireModeCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

