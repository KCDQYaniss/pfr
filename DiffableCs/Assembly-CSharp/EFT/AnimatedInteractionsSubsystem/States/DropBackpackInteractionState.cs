namespace EFT.AnimatedInteractionsSubsystem.States;

public class DropBackpackInteractionState : BaseInventoryInteractionState
{

	public virtual AnimatedInteractionInstruction Instruction
	{
		 get { } //Length: 16
	}

	public DropBackpackInteractionState() { }

	public virtual AnimatedInteractionInstruction get_Instruction() { }

}

