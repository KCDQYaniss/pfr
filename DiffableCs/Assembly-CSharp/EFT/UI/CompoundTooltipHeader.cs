namespace EFT.UI;

public class CompoundTooltipHeader : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _header; //Field offset: 0x70
	[SerializeField]
	private Image _headerImage; //Field offset: 0x78
	[SerializeField]
	private Image _headerBackground; //Field offset: 0x80
	[SerializeField]
	private Color _defaultBackgroundColor; //Field offset: 0x88

	public CompoundTooltipHeader() { }

	public void Show(string text, Sprite icon, Nullable backgroundColor = null) { }

}

