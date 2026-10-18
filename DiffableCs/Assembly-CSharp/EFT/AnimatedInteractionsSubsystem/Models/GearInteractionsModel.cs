namespace EFT.AnimatedInteractionsSubsystem.Models;

public class GearInteractionsModel : BaseInteractionsModel
{

	public GearInteractionsModel() { }

	public virtual AnimatedInteractionInstruction HandleInteraction(EInteraction interaction) { }

	protected virtual void InitializeStates() { }

}

