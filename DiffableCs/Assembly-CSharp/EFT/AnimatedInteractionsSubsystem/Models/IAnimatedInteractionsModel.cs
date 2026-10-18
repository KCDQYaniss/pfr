namespace EFT.AnimatedInteractionsSubsystem.Models;

public interface IAnimatedInteractionsModel
{

	public event Action OnInteractionForceResetEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnInteractionNeededPlayEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnInteractionStatusChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool CanInteract
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

	[CompilerGenerated]
	public void add_OnInteractionForceResetEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnInteractionNeededPlayEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnInteractionStatusChangedEvent(Action value) { }

	public void Dispose() { }

	public void ForceReset() { }

	public bool get_CanInteract() { }

	public bool get_IsInteractionPlaying() { }

	public bool get_IsScheduleDenied() { }

	[CompilerGenerated]
	public void remove_OnInteractionForceResetEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnInteractionNeededPlayEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnInteractionStatusChangedEvent(Action value) { }

	public void SetInteraction(EInteraction interaction) { }

}

