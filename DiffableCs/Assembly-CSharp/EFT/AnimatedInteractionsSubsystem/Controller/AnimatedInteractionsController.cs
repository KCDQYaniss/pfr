namespace EFT.AnimatedInteractionsSubsystem.Controller;

public class AnimatedInteractionsController : IAnimatedInteractionsController
{
	private readonly IAnimatedInteractionsModel _model; //Field offset: 0x10
	private readonly IAnimatedInteractionsView _view; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsInteractionInProcess>k__BackingField; //Field offset: 0x20
	private PlayerAnimator _playerAnimator; //Field offset: 0x28

	public override bool CanInteract
	{
		 get { } //Length: 78
	}

	public private override bool IsInteractionInProcess
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override bool IsInteractionPlaying
	{
		 get { } //Length: 78
	}

	public override bool IsScheduleDenied
	{
		 get { } //Length: 78
	}

	public AnimatedInteractionsController(PlayerAnimator playerAnimator) { }

	public override void Dispose() { }

	public override void ForceStopInteractions() { }

	public override bool get_CanInteract() { }

	[CompilerGenerated]
	public override bool get_IsInteractionInProcess() { }

	public override bool get_IsInteractionPlaying() { }

	public override bool get_IsScheduleDenied() { }

	private void OnInteractionForceReset() { }

	private void OnInteractionNeededPlay(byte interactionIndex) { }

	private void OnInteractionStatusChanged(AnimatedInteractionCallback callback) { }

	[CompilerGenerated]
	private void set_IsInteractionInProcess(bool value) { }

	public override void SetInteraction(EInteraction interaction) { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

