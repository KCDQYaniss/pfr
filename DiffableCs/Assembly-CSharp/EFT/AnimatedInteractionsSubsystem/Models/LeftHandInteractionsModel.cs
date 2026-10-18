namespace EFT.AnimatedInteractionsSubsystem.Models;

public class LeftHandInteractionsModel : BaseInteractionsModel
{

	public LeftHandInteractionsModel() { }

	public virtual AnimatedInteractionInstruction HandleInteraction(EInteraction interaction) { }

	protected virtual void InitializeStates() { }

}

