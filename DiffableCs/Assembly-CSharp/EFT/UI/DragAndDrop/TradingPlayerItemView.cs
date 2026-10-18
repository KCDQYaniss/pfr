namespace EFT.UI.DragAndDrop;

public sealed class TradingPlayerItemView : TradingItemView
{
	private const int MAX_ITEMS_IN_TOOLTIP = 10; //Field offset: 0x0

	protected virtual Nullable ItemPrice
	{
		 get { } //Length: 80
	}

	public TradingPlayerItemView() { }

	[CompilerGenerated]
	private void <RegisterItemView>b__6_0() { }

	private SingleLineInfo[] CantBeBoughtInfos(Item rootItem, IEnumerable unsellableParts) { }

	public static TradingPlayerItemView Create(Item item, TradingItemContext sourceContext, ItemRotation rotation, Trader trader, ItemController inventoryController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ETradeMode tradeMode, bool canSelect, bool canDrag, ETradingItemViewType itemViewType, ItemUiContext itemUiContext, InsuranceCompany insurance, WishlistManager wishlistStorage, bool modSlotView) { }

	protected virtual Nullable get_ItemPrice() { }

	private bool HasAnyArmor(Item item) { }

	protected virtual void HideTooltip() { }

	private void OnItemAddedHandler(AddItemEventArgs args) { }

	private void OnItemChangedHandler(Item item) { }

	private void OnItemRefreshedHandler(RefreshItemEventArgs args) { }

	private void OnItemRemovedHandler(RemoveItemEventArgs args) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	protected virtual void RegisterItemView() { }

	protected virtual void ShowTooltip() { }

	protected virtual void UpdateScheme() { }

}

