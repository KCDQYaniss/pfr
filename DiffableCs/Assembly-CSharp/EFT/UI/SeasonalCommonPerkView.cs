namespace EFT.UI;

public sealed class SeasonalCommonPerkView : UIElement
{
	[SerializeField]
	private NetworkImageView _icon; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _name; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0x80

	public SeasonalCommonPerkView() { }

	public void Show(CommonPerk perk, IImageLoader imageLoader) { }

}

