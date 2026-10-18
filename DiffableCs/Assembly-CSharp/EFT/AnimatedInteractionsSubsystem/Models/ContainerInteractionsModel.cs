namespace EFT.AnimatedInteractionsSubsystem.Models;

public class ContainerInteractionsModel : BaseInteractionsModel
{

	public ContainerInteractionsModel() { }

	public virtual AnimatedInteractionInstruction HandleInteraction(EInteraction interaction) { }

	protected virtual void InitializeStates() { }

}

