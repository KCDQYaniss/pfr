namespace EFT.InventoryLogic;

public sealed class FirstLevelSelectableItemContext : SelectableItemContext
{
	private static readonly EItemViewComponent[] _viewComponents; //Field offset: 0x0

	protected virtual IEnumerable ViewComponents
	{
		 get { } //Length: 83
	}

	private static FirstLevelSelectableItemContext() { }

	public FirstLevelSelectableItemContext(EItemViewType viewType, ISelectionContext selectionContext) { }

	private FirstLevelSelectableItemContext(Item item, SelectableItemContext sourceContext) { }

	public virtual ItemContext CreateChild(Item item) { }

	public virtual SelectableItemContext CreateSelectableChild(Item item) { }

	protected virtual IEnumerable get_ViewComponents() { }

}

