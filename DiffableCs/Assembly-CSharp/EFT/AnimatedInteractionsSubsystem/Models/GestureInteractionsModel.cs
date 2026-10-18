namespace EFT.AnimatedInteractionsSubsystem.Models;

public class GestureInteractionsModel : BaseInteractionsModel, IGestureInteractionModel
{

	public GestureInteractionsModel() { }

	public virtual AnimatedInteractionInstruction HandleInteraction(EInteraction interaction) { }

	protected virtual void InitializeStates() { }

}

