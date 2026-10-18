namespace EFT.AnimatedInteractionsSubsystem.States;

public class TakeItemInteractionState : BaseItemInteractionState
{

	public virtual AnimatedInteractionInstruction Instruction
	{
		 get { } //Length: 25
	}

	public TakeItemInteractionState() { }

	public virtual AnimatedInteractionInstruction get_Instruction() { }

}

