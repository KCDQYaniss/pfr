namespace EFT.NextObservedPlayer;

public class PhraseCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public int PhraseId; //Field offset: 0x10
	public EPhraseTrigger PhraseCommand; //Field offset: 0x14

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public PhraseCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static PhraseCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

