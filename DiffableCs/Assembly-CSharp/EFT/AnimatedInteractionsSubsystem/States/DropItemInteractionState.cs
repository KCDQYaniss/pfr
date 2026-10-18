namespace EFT.AnimatedInteractionsSubsystem.States;

public class DropItemInteractionState : BaseItemInteractionState
{

	public virtual AnimatedInteractionInstruction Instruction
	{
		 get { } //Length: 25
	}

	public DropItemInteractionState() { }

	public virtual AnimatedInteractionInstruction get_Instruction() { }

}

