namespace EFT.AnimatedInteractionsSubsystem;

public class AnimatedInteractions : IAnimatedInteractions
{
	private readonly IAnimatedInteractionsController _controller; //Field offset: 0x10

	public override bool CanInteract
	{
		 get { } //Length: 78
	}

	public override bool IsInteractionInProcessByController
	{
		 get { } //Length: 75
	}

	public override bool IsInteractionPlaying
	{
		 get { } //Length: 78
	}

	public override bool IsScheduleDenied
	{
		 get { } //Length: 78
	}

	public AnimatedInteractions(PlayerAnimator playerAnimator) { }

	public override void Dispose() { }

	public override void ForceStopInteractions() { }

	public override bool get_CanInteract() { }

	public override bool get_IsInteractionInProcessByController() { }

	public override bool get_IsInteractionPlaying() { }

	public override bool get_IsScheduleDenied() { }

	public override void SetInteraction(EInteraction interaction) { }

}

