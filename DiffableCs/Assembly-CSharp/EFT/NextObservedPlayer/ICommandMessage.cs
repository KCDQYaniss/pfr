namespace EFT.NextObservedPlayer;

public interface ICommandMessage : ISerializableMessage, IDisposable
{

	public CommandMessageType Type
	{
		 get { } //Length: 0
	}

	public ICommandMessage CloneCommand() { }

	public CommandMessageType get_Type() { }

}

