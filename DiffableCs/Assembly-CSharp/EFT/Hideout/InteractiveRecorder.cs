namespace EFT.Hideout;

public sealed class InteractiveRecorder : InteractableObject
{
	private bool _energized; //Field offset: 0x48

	public InteractiveRecorder() { }

	public AvailableInteractionState InteractionStates(HideoutPlayerOwner owner) { }

	private void ShowRecorderUi() { }

	public void TurnOffEnergy() { }

	public void TurnOnEnergy() { }

}

