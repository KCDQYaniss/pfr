namespace EFT.NextObservedPlayer.Operations;

public sealed class SetExternalMagazineStateHandsOperation : BaseHandsOperation
{

	public SetExternalMagazineStateHandsOperation() { }

	public static SetExternalMagazineStateHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual IHandsOperationResult Start(SetExternalMagazineStateMessage input) { }

}

