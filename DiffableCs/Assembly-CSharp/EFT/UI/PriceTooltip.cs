namespace EFT.UI;

public sealed class PriceTooltip : SimpleTooltip
{
	private const string TRADER_BUY_ERROR = "Trader can't buy this item"; //Field offset: 0x0
	private const string ITEM_ALREADY_SOLD_ERROR = "The item has been sold"; //Field offset: 0x0
	[SerializeField]
	private Image _currencyIcon; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI _price; //Field offset: 0xC0
	[SerializeField]
	private Color _priceColor; //Field offset: 0xC8
	[SerializeField]
	private Color _unbuyableColor; //Field offset: 0xD8

	public PriceTooltip() { }

	public void Show(EOwnerType ownerType, string text, int price, Nullable currencyTemplate) { }

}

