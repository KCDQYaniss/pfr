namespace EFT.UI.DragAndDrop;

[UsedImplicitly]
public sealed class QuickSlotItemView : ItemView, IRefreshHandler, IItemRelatedView, IAddHandler, IRemoveHandler
{
	[SerializeField]
	private TextMeshProUGUI _resourceValue; //Field offset: 0x238
	private EBoundItem _boundIndex; //Field offset: 0x240
	private InventoryController _inventoryController; //Field offset: 0x248

	protected virtual bool IsInteractable
	{
		 get { } //Length: 3
	}

	public QuickSlotItemView() { }

	public static QuickSlotItemView Create(Item item, EBoundItem boundIndex, InventoryController inventoryController, ItemUiContext itemUiContext) { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs args) { }

	private override void EFT.IRefreshHandler.OnRefreshItem(RefreshItemEventArgs args) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs args) { }

	protected virtual bool get_IsInteractable() { }

	private bool IsCompatibleItem(Item item, ItemAddress address) { }

	public virtual void Kill() { }

	private QuickSlotItemView NewQuickSlotItemView(Item item, EBoundItem boundIndex, ItemRotation rotation, InventoryController inventoryController, ItemUiContext itemUiContext) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	private void RefreshSlot(bool refreshIcon = true) { }

	protected virtual void RegisterItemView() { }

	private static bool TryGetResourceText(Item item, out string text) { }

	public virtual void UpdateInfo() { }

	protected virtual void UpdateScale() { }

}

