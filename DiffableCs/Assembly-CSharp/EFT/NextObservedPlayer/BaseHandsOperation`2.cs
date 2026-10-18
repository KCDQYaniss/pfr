namespace EFT.NextObservedPlayer;

public abstract class BaseHandsOperation`2 : IHandOperation, IHandOperationLifeCircle
{
	protected BaseAnimationHandsController _handsController; //Field offset: 0x0
	[CompilerGenerated]
	private readonly HandsOperationAnimatorCallbacks <Callbacks>k__BackingField; //Field offset: 0x0

	public override HandsOperationAnimatorCallbacks Callbacks
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool CanFastForward
	{
		 get { } //Length: 3
	}

	protected BaseHandsOperation`2() { }

	public override void CheckAbort(CommandMessageType messageType) { }

	public override void Entry(IHandOperation from) { }

	public override void Exit(IHandOperation to) { }

	public abstract void FastForward() { }

	[CompilerGenerated]
	public override HandsOperationAnimatorCallbacks get_Callbacks() { }

	public override bool get_CanFastForward() { }

	public void SetController(BaseAnimationHandsController controller) { }

	public abstract TO Start(TI input) { }

	public override void Transition(Type toOperation, IHandOperation operation) { }

}

