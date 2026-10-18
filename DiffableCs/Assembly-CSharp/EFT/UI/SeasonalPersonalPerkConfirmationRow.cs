namespace EFT.UI;

public sealed class SeasonalPersonalPerkConfirmationRow : UIElement
{
	private static readonly Color PositiveColor; //Field offset: 0x0
	private static readonly Color NegativeColor; //Field offset: 0x10
	[SerializeField]
	private Image _iconBackground; //Field offset: 0x70
	[SerializeField]
	private SeasonalModifierIconView _icon; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _name; //Field offset: 0x80
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0x88

	private static SeasonalPersonalPerkConfirmationRow() { }

	public SeasonalPersonalPerkConfirmationRow() { }

	public virtual void Close() { }

	public void Show(PersonalPerk perk, IImageLoader imageLoader) { }

}

