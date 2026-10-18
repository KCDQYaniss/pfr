namespace EFT.AnimatedInteractionsSubsystem.States;

public class BaseGearInteractionState : BaseInteractionState
{

	public virtual AnimatedInteractionInstruction Instruction
	{
		 get { } //Length: 15
	}

	public BaseGearInteractionState() { }

	public virtual AnimatedInteractionInstruction get_Instruction() { }

}

