namespace EFT.NextObservedPlayer.Operations;

public class MagAndChamberStateHandsOperation : BaseHandsOperation
{

	public MagAndChamberStateHandsOperation() { }

	public static MagAndChamberStateHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual IHandsOperationResult Start(MagAndChamberStateCommandMessage input) { }

}

