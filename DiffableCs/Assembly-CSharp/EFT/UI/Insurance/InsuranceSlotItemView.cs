namespace EFT.UI.Insurance;

public class InsuranceSlotItemView : SlotItemView
{
	private static InsuranceCompany _insurance; //Field offset: 0x0
	[SerializeField]
	private Image _itemToInsureBorder; //Field offset: 0x338
	private InsuredItem _insuredItem; //Field offset: 0x340

	private bool InQueue
	{
		private get { } //Length: 98
	}

	private bool Insured
	{
		private get { } //Length: 98
	}

	public InsuranceSlotItemView() { }

	private void ChangeInsuranceQueueStatus(InsuredItem item) { }

	public static SlotItemView Create(Item item, ItemContext sourceContext, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompany insurance) { }

	protected virtual ItemContext CreateNewItemContext(ItemContext sourceContext) { }

	private bool get_InQueue() { }

	private bool get_Insured() { }

	private InsuranceSlotItemView NewInsuranceSlotItemView(InsuredItem insuredItem, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompany insurance) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

}

