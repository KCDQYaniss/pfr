namespace EFT.UI;

public sealed class EmptyMemberView : ButtonFeedback
{
	[CompilerGenerated]
	private Action OnClick; //Field offset: 0xA8
	[SerializeField]
	private Image _bgImage; //Field offset: 0xB0
	[SerializeField]
	private Sprite _bgIdleSprite; //Field offset: 0xB8
	[SerializeField]
	private Sprite _bgHoverSprite; //Field offset: 0xC0
	[SerializeField]
	private Image _borderImage; //Field offset: 0xC8
	[SerializeField]
	private Sprite _borderIdleSprite; //Field offset: 0xD0
	[SerializeField]
	private Sprite _borderHoverSprite; //Field offset: 0xD8
	[SerializeField]
	private Image _plusImage; //Field offset: 0xE0
	[SerializeField]
	private Color _idlePlusColor; //Field offset: 0xE8
	[SerializeField]
	private Color _hoverPlusColor; //Field offset: 0xF8

	public event Action OnClick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public EmptyMemberView() { }

	[CompilerGenerated]
	public void add_OnClick(Action value) { }

	private void HoverHandler(bool hover) { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	[CompilerGenerated]
	public void remove_OnClick(Action value) { }

	public void Show() { }

}

