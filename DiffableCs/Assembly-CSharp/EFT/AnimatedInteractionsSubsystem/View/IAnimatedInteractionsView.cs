namespace EFT.AnimatedInteractionsSubsystem.View;

public interface IAnimatedInteractionsView
{

	public void Dispose() { }

	public void ResetInteraction() { }

	public void ShowInteraction(byte interactionIndex) { }

	public void StopInteraction() { }

}

