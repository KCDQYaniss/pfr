namespace EFT.UI;

public sealed class SwapSpriteToggle : Toggle
{
	[SerializeField]
	[UsedImplicitly]
	private Sprite _spriteOn; //Field offset: 0x128
	[SerializeField]
	[UsedImplicitly]
	private Sprite _spriteOff; //Field offset: 0x130
	[SerializeField]
	[UsedImplicitly]
	private Image _image; //Field offset: 0x138

	public SwapSpriteToggle() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void ValueChangeHandler(bool isToggled) { }

}

