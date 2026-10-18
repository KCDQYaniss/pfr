namespace EFT.AnimatedInteractionsSubsystem.Models;

public class InventoryInteractionsModel : BaseInteractionsModel, IInventoryInteractionsModel
{

	public InventoryInteractionsModel() { }

	public virtual AnimatedInteractionInstruction HandleInteraction(EInteraction interaction) { }

	protected virtual void InitializeStates() { }

}

