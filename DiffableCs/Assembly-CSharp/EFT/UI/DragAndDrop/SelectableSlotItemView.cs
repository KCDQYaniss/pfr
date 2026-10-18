namespace EFT.UI.DragAndDrop;

public class SelectableSlotItemView : StaticSlotItemView
{
	private SelectableItemContext _selectableContext; //Field offset: 0x338
	private bool _available; //Field offset: 0x340
	protected string _tooltipText; //Field offset: 0x348
	protected Color _backgroundColor; //Field offset: 0x350

	public virtual ItemRotation ItemRotation
	{
		 get { } //Length: 7
		 set { } //Length: 3
	}

	public SelectableSlotItemView() { }

	public static SlotItemView Create(Item item, ItemContext sourceContext, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompany insurance) { }

	public virtual ItemRotation get_ItemRotation() { }

	public virtual void Kill() { }

	protected SelectableSlotItemView NewSelectableSlotItemView(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompany insurance) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	protected virtual void set_ItemRotation(ItemRotation value) { }

	private void SetAvailability(bool available, string tooltip) { }

	protected virtual void UpdateStaticInfo() { }

}

