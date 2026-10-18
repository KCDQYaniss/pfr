namespace EFT.AnimatedInteractionsSubsystem.States;

public interface IInteractionStateBehaviour : IStateBehaviour
{

	public BaseInteractionState EncapsulatedState
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public EInteraction Interaction
	{
		 get { } //Length: 0
	}

	public BaseInteractionState get_EncapsulatedState() { }

	public EInteraction get_Interaction() { }

	public void set_EncapsulatedState(BaseInteractionState value) { }

}

