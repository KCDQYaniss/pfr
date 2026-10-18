namespace EFT.UI.Ragfair;

public sealed class OfferItemPrice : UIElement
{
	[SerializeField]
	private OfferItemPriceBarter _barterRequirementView; //Field offset: 0x70
	[SerializeField]
	private RectTransform _barterRequirementsContainer; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _priceLabel; //Field offset: 0x80
	[SerializeField]
	private Image _priceIcon; //Field offset: 0x88
	[SerializeField]
	private GameObject _estimatedPriceObject; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _estimatedPriceLabel; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI _packLabel; //Field offset: 0xA0
	[SerializeField]
	private GridLayoutGroup _gridLayout; //Field offset: 0xA8
	private readonly List _barterViews; //Field offset: 0xB0
	private UiElementPool _barterViewPool; //Field offset: 0xB8

	public OfferItemPrice() { }

	public virtual void Close() { }

	private void ReleaseBarterViews() { }

	public void Show(Offer offer, ItemTooltip tooltip, InventoryController inventoryController, ItemUiContext itemUiContext, InsuranceCompany insuranceCompany, bool expanded) { }

}

