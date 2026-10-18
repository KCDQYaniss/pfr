namespace EFT.NextObservedPlayer.Operations;

public sealed class SetChamberStateHandsOperation : BaseHandsOperation
{

	public SetChamberStateHandsOperation() { }

	public static SetChamberStateHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual IHandsOperationResult Start(SetChamberStateCommandMessage input) { }

}

