namespace EFT.AnimatedInteractionsSubsystem;

public interface IAnimatedInteractions
{

	public bool CanInteract
	{
		 get { } //Length: 0
	}

	public bool IsInteractionInProcessByController
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

	public bool get_IsInteractionInProcessByController() { }

	public bool get_IsInteractionPlaying() { }

	public bool get_IsScheduleDenied() { }

	public void SetInteraction(EInteraction interaction) { }

}

