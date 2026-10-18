namespace EFT.NextObservedPlayer.Operations;

public sealed class PlantTripwireOperation : BaseHandsOperation
{

	public virtual bool CanFastForward
	{
		 get { } //Length: 3
	}

	public PlantTripwireOperation() { }

	public static PlantTripwireOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual bool get_CanFastForward() { }

	public virtual IHandsOperationResult Start(HandsOperationEmptyInput input) { }

}

