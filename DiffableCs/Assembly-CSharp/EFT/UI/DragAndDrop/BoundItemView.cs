namespace EFT.UI.DragAndDrop;

public sealed class BoundItemView : QuickSlotView, IBindHandler, IItemRelatedView, IUnbindHandler, ISetInHandsHandler, IRemoveFromHandsHandler
{

	public BoundItemView() { }

	public virtual Task AcceptItem(DragItemContext itemContext, ItemContext targetItemContext) { }

	public virtual bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	public virtual bool CanDrag(ItemContext itemContext) { }

	private override void EFT.IBindHandler.OnBindItem(BindItemEventArgs eventArgs) { }

	private override void EFT.IRemoveFromHandsHandler.OnRemoveFromHands(RemoveFromHandsEventArgs args) { }

	private override void EFT.ISetInHandsHandler.OnSetInHands(SetInHandsEventArgs args) { }

	private override void EFT.IUnbindHandler.OnUnbindItem(UnbindItemEventArgs eventArgs) { }

	public virtual void Hide() { }

	protected virtual void OnDestroy() { }

	public void Show(InventoryController inventoryController, ItemUiContext itemUiContext) { }

}

