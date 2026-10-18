namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerListCommandsMessagePooled : ObservedPlayerListCommandsMessage, IDisposable
{

	public ObservedPlayerListCommandsMessagePooled(int capacity) { }

	public override void Dispose() { }

}

