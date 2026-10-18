namespace EFT.UI.Insurance;

public sealed class InsuranceItemView : GridItemView
{
	[SerializeField]
	private Image _itemToInsureBorder; //Field offset: 0x2E0
	private InsuranceCompany _insurance; //Field offset: 0x2E8
	private InsuredItem _insuredItem; //Field offset: 0x2F0

	private bool InQueue
	{
		private get { } //Length: 49
	}

	private bool Insured
	{
		private get { } //Length: 49
	}

	public InsuranceItemView() { }

	private void ChangeInsuranceQueueStatus(InsuredItem item) { }

	public static InsuranceItemView Create(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	protected virtual ItemContext CreateNewItemContext(ItemContext sourceContext) { }

	private bool get_InQueue() { }

	private bool get_Insured() { }

	private InsuranceItemView NewInsuranceItemView(InsuredItem insuredItem, ItemContext sourceContext, ItemRotation rotation, IItemOwner itemOwner, ItemController itemController, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

}

