namespace EFT.UI;

public sealed class CharacterSelectionSeasonPerkView : UIElement
{
	[SerializeField]
	private NetworkImageView _icon; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _name; //Field offset: 0x78

	public CharacterSelectionSeasonPerkView() { }

	public void Show(SeasonalPerkData perkData, IImageLoader imageLoader) { }

}

