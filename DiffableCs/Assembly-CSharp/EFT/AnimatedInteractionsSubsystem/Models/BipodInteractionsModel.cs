namespace EFT.AnimatedInteractionsSubsystem.Models;

public class BipodInteractionsModel : BaseInteractionsModel
{

	public BipodInteractionsModel() { }

	public virtual AnimatedInteractionInstruction HandleInteraction(EInteraction interaction) { }

	protected virtual void InitializeStates() { }

}

