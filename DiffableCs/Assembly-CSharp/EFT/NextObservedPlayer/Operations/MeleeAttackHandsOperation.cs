namespace EFT.NextObservedPlayer.Operations;

public class MeleeAttackHandsOperation : BaseHandsOperation
{

	public MeleeAttackHandsOperation() { }

	public static MeleeAttackHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual IHandsOperationResult Start(MeleeAttackCommandMessage input) { }

}

