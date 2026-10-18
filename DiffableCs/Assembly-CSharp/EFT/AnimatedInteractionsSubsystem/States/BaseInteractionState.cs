namespace EFT.AnimatedInteractionsSubsystem.States;

public abstract class BaseInteractionState
{
	[CompilerGenerated]
	private readonly AnimatedInteractionInstruction <Instruction>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnChangeInteractionStatusEvent; //Field offset: 0x18

	public event Action OnChangeInteractionStatusEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override AnimatedInteractionInstruction Instruction
	{
		[CompilerGenerated]
		 get { } //Length: 17
	}

	protected BaseInteractionState() { }

	[CompilerGenerated]
	public void add_OnChangeInteractionStatusEvent(Action value) { }

	[CompilerGenerated]
	public override AnimatedInteractionInstruction get_Instruction() { }

	public override void OnStateEnter(AnimatedInteractionCallback callback) { }

	public override void OnStateExit(AnimatedInteractionCallback callback) { }

	[CompilerGenerated]
	public void remove_OnChangeInteractionStatusEvent(Action value) { }

}

