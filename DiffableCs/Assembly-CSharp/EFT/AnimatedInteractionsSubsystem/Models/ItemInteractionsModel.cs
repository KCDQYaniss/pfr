namespace EFT.AnimatedInteractionsSubsystem.Models;

public class ItemInteractionsModel : BaseInteractionsModel
{

	public ItemInteractionsModel() { }

	public virtual AnimatedInteractionInstruction HandleInteraction(EInteraction interaction) { }

	protected virtual void InitializeStates() { }

}

