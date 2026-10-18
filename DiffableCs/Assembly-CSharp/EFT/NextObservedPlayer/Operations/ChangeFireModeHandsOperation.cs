namespace EFT.NextObservedPlayer.Operations;

public class ChangeFireModeHandsOperation : BaseHandsOperation
{

	public ChangeFireModeHandsOperation() { }

	public static ChangeFireModeHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual IHandsOperationResult Start(EFireMode fireMode) { }

}

