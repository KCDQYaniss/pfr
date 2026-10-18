namespace EFT.AnimatedInteractionsSubsystem.States;

public class BipodOffInteractionState : BaseInteractionState
{
	private readonly EInteraction _interaction; //Field offset: 0x20

	public virtual AnimatedInteractionInstruction Instruction
	{
		 get { } //Length: 21
	}

	public BipodOffInteractionState(EInteraction interaction) { }

	public virtual AnimatedInteractionInstruction get_Instruction() { }

}

