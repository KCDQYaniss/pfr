namespace EFT.NextObservedPlayer.Operations;

public class ZombieMeleeAttackOperation : BaseHandsOperation
{

	public ZombieMeleeAttackOperation() { }

	public static ZombieMeleeAttackOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual IHandsOperationResult Start(ZombieMeleeAttackCommandMessage input) { }

}

