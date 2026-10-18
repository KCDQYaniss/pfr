namespace EFT.UI.DragAndDrop;

public class TradingTableGridView : GridView
{
	private Assortment _traderAssortment; //Field offset: 0x108

	public TradingTableGridView() { }

	public virtual Task AcceptItem(DragItemContext itemContext, ItemContext targetItemContext) { }

	public virtual bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	protected virtual Color GetHighlightColor(DragItemContext itemContext, OperationResult possibleOperation, ItemContext targetItemContext) { }

	public void Show(Grid grid, Assortment traderAssortment, InventoryController inventoryController, ItemUiContext itemUiContext) { }

}

