namespace EFT.NextObservedPlayer.Operations;

public class HighSwingHandsOperation : BaseHandsOperation
{

	public virtual bool CanFastForward
	{
		 get { } //Length: 3
	}

	public HighSwingHandsOperation() { }

	public static HighSwingHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual bool get_CanFastForward() { }

	public override void SetGrenadeFireHold() { }

	public virtual IHandsOperationResult Start(HandsOperationEmptyInput input) { }

}

