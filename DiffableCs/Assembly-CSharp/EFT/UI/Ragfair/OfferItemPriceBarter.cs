namespace EFT.UI.Ragfair;

public sealed class OfferItemPriceBarter : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[SerializeField]
	private GameObject _separator; //Field offset: 0x70
	[SerializeField]
	private GameObject _barterIcon; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _requirementName; //Field offset: 0x80
	private IExchangeRequirement _requirement; //Field offset: 0x88
	private ItemTooltip _tooltip; //Field offset: 0x90
	private Offer _offer; //Field offset: 0x98
	private InventoryController _inventoryController; //Field offset: 0xA0
	private ItemUiContext _itemUiContext; //Field offset: 0xA8
	private InsuranceCompany _insuranceCompany; //Field offset: 0xB0
	private bool _expanded; //Field offset: 0xB8

	public OfferItemPriceBarter() { }

	public virtual void Close() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(IExchangeRequirement requirement, ItemTooltip tooltip, Offer offer, InventoryController inventoryController, ItemUiContext itemUiContext, InsuranceCompany insuranceCompany, int index, bool expanded) { }

}

