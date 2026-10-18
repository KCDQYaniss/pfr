namespace EFT.AnimatedInteractionsSubsystem.States;

public class InteractionStateContainer : StateMachineBehaviour, IInteractionStateBehaviour, IStateBehaviour
{
	[SerializeField]
	private EInteraction _interactionName; //Field offset: 0x18
	[CompilerGenerated]
	private BaseInteractionState <EncapsulatedState>k__BackingField; //Field offset: 0x20

	public override BaseInteractionState EncapsulatedState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override EInteraction Interaction
	{
		 get { } //Length: 5
	}

	public InteractionStateContainer() { }

	[CompilerGenerated]
	public override BaseInteractionState get_EncapsulatedState() { }

	public override EInteraction get_Interaction() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	[CompilerGenerated]
	public override void set_EncapsulatedState(BaseInteractionState value) { }

}

