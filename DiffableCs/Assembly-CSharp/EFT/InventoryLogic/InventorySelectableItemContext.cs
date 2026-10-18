namespace EFT.InventoryLogic;

public class InventorySelectableItemContext : SelectableItemContext
{
	private sealed class SelectionContextWrapper : ISelectionContext
	{
		[CompilerGenerated]
		private Action OnItemSelected; //Field offset: 0x10
		private ISelectionContext _realSelector; //Field offset: 0x18

		public override event Action OnItemSelected
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public SelectionContextWrapper() { }

		[CompilerGenerated]
		public override void add_OnItemSelected(Action value) { }

		public void Disable() { }

		private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsActive(ItemContext context, out string tooltip) { }

		private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsSelected(Item item) { }

		private override void EFT.InventoryLogic.SelectableItemContext.ISelectionContext.ToggleSelection(SelectableItemContext context) { }

		public void Enable(ISelectionContext realSelector) { }

		[CompilerGenerated]
		public override void remove_OnItemSelected(Action value) { }

		private void SelectionHandler(Item item, bool selected) { }

	}

	private readonly SelectionContextWrapper _selectionWrapper; //Field offset: 0x88

	public InventorySelectableItemContext(EItemViewType viewType) { }

	protected InventorySelectableItemContext(Item item, EItemViewType viewType) { }

	private InventorySelectableItemContext(Item item, EItemViewType viewType, SelectionContextWrapper selectionContext) { }

	protected InventorySelectableItemContext(Item item, InventorySelectableItemContext sourceContext) { }

	private InventorySelectableItemContext(ItemContext sourceContext, SelectionContextWrapper selectionContext) { }

	public static InventorySelectableItemContext CreateFromDefaultContext(ItemContext sourceContext) { }

	public virtual SelectableItemContext CreateSelectableChild(Item item) { }

	public void Disable() { }

	public virtual void Dispose() { }

	public void Enable(ISelectionContext realSelector) { }

}

