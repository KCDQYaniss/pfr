namespace EFT.AnimatedInteractionsSubsystem.Models;

public class DoorInteractionsModel : BaseInteractionsModel
{

	public DoorInteractionsModel() { }

	public virtual AnimatedInteractionInstruction HandleInteraction(EInteraction interaction) { }

	protected virtual void InitializeStates() { }

}

