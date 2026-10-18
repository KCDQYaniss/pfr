namespace EFT.UI;

public sealed class SeasonRankView : UIElement
{
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	[SerializeField]
	private HoverTooltipArea _tooltipArea; //Field offset: 0x78

	public SeasonRankView() { }

	public void Show(int rank) { }

}

