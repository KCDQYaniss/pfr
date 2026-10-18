namespace EFT.UI.DragAndDrop;

public sealed class HideoutItemView : StaticGridItemView
{
	private bool _modSlotView; //Field offset: 0x2E0

	public virtual ItemRotation ItemRotation
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public HideoutItemView() { }

	public static HideoutItemView Create(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, ItemUiContext itemUiContext, InsuranceCompany insurance, WishlistManager wishlist, bool modSlotView) { }

	public virtual ItemRotation get_ItemRotation() { }

	private void NewHideoutItemView(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, ItemUiContext itemUiContext, InsuranceCompany insurance, WishlistManager wishlist, bool modSlotView) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	protected virtual void set_ItemRotation(ItemRotation value) { }

	public virtual void UpdateInfo() { }

	public virtual void UpdateRemoveError(bool ignoreMalfunctions = true) { }

	protected virtual void UpdateScale() { }

}

