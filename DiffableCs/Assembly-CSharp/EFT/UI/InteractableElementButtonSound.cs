namespace EFT.UI;

[RequireComponent(typeof(InteractableElement))]
public sealed class InteractableElementButtonSound : ButtonSoundFeedback
{
	private InteractableElement _element; //Field offset: 0x30

	public InteractableElementButtonSound() { }

	private void Awake() { }

	protected virtual bool CanPlaySound() { }

}

