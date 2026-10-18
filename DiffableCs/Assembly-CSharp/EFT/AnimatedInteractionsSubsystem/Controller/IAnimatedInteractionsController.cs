namespace EFT.AnimatedInteractionsSubsystem.Controller;

public interface IAnimatedInteractionsController
{

	public bool CanInteract
	{
		 get { } //Length: 0
	}

	public bool IsInteractionInProcess
	{
		 get { } //Length: 0
	}

	public bool IsInteractionPlaying
	{
		 get { } //Length: 0
	}

	public bool IsScheduleDenied
	{
		 get { } //Length: 0
	}

	public void Dispose() { }

	public void ForceStopInteractions() { }

	public bool get_CanInteract() { }

	public bool get_IsInteractionInProcess() { }

	public bool get_IsInteractionPlaying() { }

	public bool get_IsScheduleDenied() { }

	public void SetInteraction(EInteraction interaction) { }

}

