namespace EFT.UI;

public sealed class ItemTooltip : SimpleTooltip
{
	[SerializeField]
	private GameObject _itemObject; //Field offset: 0xB8
	[SerializeField]
	private RagfairOfferItemView _itemView; //Field offset: 0xC0

	public RagfairOfferItemView ItemView
	{
		 get { } //Length: 8
	}

	public ItemTooltip() { }

	public virtual void Close() { }

	public RagfairOfferItemView get_ItemView() { }

	public void Show(string text, float delay, Offer offer, Item item, InventoryController inventoryController, ItemUiContext itemUiContext, InsuranceCompany insuranceCompany) { }

}

