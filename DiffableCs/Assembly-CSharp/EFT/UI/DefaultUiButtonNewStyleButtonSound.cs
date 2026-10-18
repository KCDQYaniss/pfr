namespace EFT.UI;

[RequireComponent(typeof(DefaultUiButtonNewStyle))]
public sealed class DefaultUiButtonNewStyleButtonSound : ButtonSoundFeedback
{
	private DefaultUiButtonNewStyle _button; //Field offset: 0x30
	private Action _unsubscribeClick; //Field offset: 0x38

	public DefaultUiButtonNewStyleButtonSound() { }

	private void Awake() { }

	protected virtual bool CanPlaySound() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

}

