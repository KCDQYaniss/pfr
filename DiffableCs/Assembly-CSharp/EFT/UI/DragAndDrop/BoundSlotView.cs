namespace EFT.UI.DragAndDrop;

public sealed class BoundSlotView : QuickSlotView, IAddHandler, IItemRelatedView, IRemoveHandler, ISetInHandsHandler, IRemoveFromHandsHandler
{
	[SerializeField]
	private BoundSlotView _subWeaponView; //Field offset: 0xE0
	private Slot _slot; //Field offset: 0xE8

	public BoundSlotView() { }

	public virtual bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	public virtual bool CanDrag(ItemContext itemContext) { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs eventArgs) { }

	private override void EFT.IRemoveFromHandsHandler.OnRemoveFromHands(RemoveFromHandsEventArgs args) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	private override void EFT.ISetInHandsHandler.OnSetInHands(SetInHandsEventArgs args) { }

	public Slot GetSlot() { }

	public virtual void Hide() { }

	protected virtual void OnDestroy() { }

	public void RefreshSelectView(Item itemInHands) { }

	public virtual void SetBoundIndex(EBoundItem boundIndex) { }

	protected virtual void SetIconScale() { }

	public void Show(Slot slot, InventoryController inventoryController, ItemUiContext itemUiContext) { }

	private void ShowMainSlot(Slot slot, InventoryController inventoryController, ItemUiContext itemUiContext) { }

	private void ShowSubItem(Slot slot, InventoryController inventoryController, ItemUiContext itemUiContext) { }

}

