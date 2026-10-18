namespace EFT.NextObservedPlayer;

public class SpectatorWhiteNoiseStatusCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool Enabled; //Field offset: 0x10

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SpectatorWhiteNoiseStatusCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static SpectatorWhiteNoiseStatusCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

