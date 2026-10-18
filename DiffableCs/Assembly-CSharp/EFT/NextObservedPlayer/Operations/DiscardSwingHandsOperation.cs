namespace EFT.NextObservedPlayer.Operations;

public sealed class DiscardSwingHandsOperation : BaseHandsOperation
{

	public virtual bool CanFastForward
	{
		 get { } //Length: 3
	}

	public DiscardSwingHandsOperation() { }

	public static DiscardSwingHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual bool get_CanFastForward() { }

	private void SetGrenadeFireIdle() { }

	public virtual IHandsOperationResult Start(HandsOperationEmptyInput input) { }

}

