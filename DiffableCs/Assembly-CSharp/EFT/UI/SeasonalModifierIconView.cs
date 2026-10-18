namespace EFT.UI;

public sealed class SeasonalModifierIconView : UIElement
{
	private const int MAX_TOOLTIP_WIDTH = 400; //Field offset: 0x0
	[SerializeField]
	private Color PositiveHeaderColor; //Field offset: 0x70
	[SerializeField]
	private Color NegativeHeaderColor; //Field offset: 0x80
	[SerializeField]
	private NetworkImageView _icon; //Field offset: 0x90
	[SerializeField]
	private HoverTrigger _hoverTrigger; //Field offset: 0x98
	private readonly List _tooltipTextBlocks; //Field offset: 0xA0
	private CompoundTooltip _compoundTooltip; //Field offset: 0xA8

	public SeasonalModifierIconView() { }

	[CompilerGenerated]
	private void <Show>b__7_0() { }

	public virtual void Close() { }

	private Nullable GetHeaderColor(ISeasonalPerk perk) { }

	private void OnHoverEnd(PointerEventData eventData) { }

	private void OnHoverStart(PointerEventData eventData) { }

	public void Show(ISeasonalPerk perk, IImageLoader imageLoader) { }

}

