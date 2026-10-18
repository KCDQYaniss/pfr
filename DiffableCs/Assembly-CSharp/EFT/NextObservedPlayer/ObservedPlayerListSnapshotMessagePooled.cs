namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerListSnapshotMessagePooled : ObservedPlayerListSnapshotMessage, IDisposable
{

	public ObservedPlayerListSnapshotMessagePooled(int capacity) { }

	public override void Dispose() { }

}

