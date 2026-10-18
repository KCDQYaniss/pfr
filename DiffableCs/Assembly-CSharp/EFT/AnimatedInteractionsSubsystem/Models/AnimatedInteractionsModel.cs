namespace EFT.AnimatedInteractionsSubsystem.Models;

public class AnimatedInteractionsModel : IAnimatedInteractionsModel
{
	[CompilerGenerated]
	private Action OnInteractionForceResetEvent; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnInteractionNeededPlayEvent; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnInteractionStatusChangedEvent; //Field offset: 0x20
	private readonly IInteractionStateBehaviour[] _interactionStateBehaviours; //Field offset: 0x28
	private readonly Dictionary _indexToInteractionDict; //Field offset: 0x30
	private readonly Queue _interactionsQueue; //Field offset: 0x38
	private readonly Queue _interactionsQueueCached; //Field offset: 0x40
	private readonly List _interactionsModel; //Field offset: 0x48
	private bool _canInteract; //Field offset: 0x50
	private bool _isScheduleDenied; //Field offset: 0x51
	private bool _isForceReset; //Field offset: 0x52
	private EInteraction _currentInteraction; //Field offset: 0x53
	private Nullable _currentInstruction; //Field offset: 0x54

	public override event Action OnInteractionForceResetEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action OnInteractionNeededPlayEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnInteractionStatusChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override bool CanInteract
	{
		 get { } //Length: 5
	}

	public override bool IsInteractionPlaying
	{
		 get { } //Length: 83
	}

	public override bool IsScheduleDenied
	{
		 get { } //Length: 5
	}

	public AnimatedInteractionsModel(IInteractionStateBehaviour[] behaviours) { }

	[CompilerGenerated]
	public override void add_OnInteractionForceResetEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnInteractionNeededPlayEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnInteractionStatusChangedEvent(Action value) { }

	public override void Dispose() { }

	public override void ForceReset() { }

	public override bool get_CanInteract() { }

	public override bool get_IsInteractionPlaying() { }

	public override bool get_IsScheduleDenied() { }

	private byte GetInteractionIndex(EInteraction interaction) { }

	private void HandleInstruction(Nullable instruction) { }

	private void InitInteractionStates() { }

	private bool IsOperation(EInteraction interaction) { }

	private void OnInteractionStatusChange(AnimatedInteractionCallback callback) { }

	private void ProceedQueueInteraction() { }

	[CompilerGenerated]
	public override void remove_OnInteractionForceResetEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnInteractionNeededPlayEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnInteractionStatusChangedEvent(Action value) { }

	private void ResetQueue() { }

	public override void SetInteraction(EInteraction interaction) { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

