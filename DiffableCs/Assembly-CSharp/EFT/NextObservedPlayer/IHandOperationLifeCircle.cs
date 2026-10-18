namespace EFT.NextObservedPlayer;

public interface IHandOperationLifeCircle
{

	public void CheckAbort(CommandMessageType messageType) { }

	public void Entry(IHandOperation from) { }

	public void Exit(IHandOperation to) { }

	public void FastForward() { }

	public void Transition(Type toOperation, IHandOperation operation) { }

}

