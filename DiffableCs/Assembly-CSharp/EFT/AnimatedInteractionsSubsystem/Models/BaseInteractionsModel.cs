namespace EFT.AnimatedInteractionsSubsystem.Models;

public abstract class BaseInteractionsModel : IAnimatedStates
{
	protected Dictionary encapsulatedStates; //Field offset: 0x10

	public override Dictionary EncapsulatedStates
	{
		 get { } //Length: 5
	}

	public BaseInteractionsModel() { }

	public override Dictionary get_EncapsulatedStates() { }

	public abstract AnimatedInteractionInstruction HandleInteraction(EInteraction interaction) { }

	public bool HasInteraction(EInteraction interaction) { }

	protected abstract void InitializeStates() { }

}

