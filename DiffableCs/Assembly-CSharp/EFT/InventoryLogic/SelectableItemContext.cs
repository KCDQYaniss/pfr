namespace EFT.InventoryLogic;

public class SelectableItemContext : ItemContext
{
	internal interface ISelectionContext
	{

		public event Action OnItemSelected
		{
			[CompilerGenerated]
			 add { } //Length: 0
			[CompilerGenerated]
			 remove { } //Length: 0
		}

		[CompilerGenerated]
		public void add_OnItemSelected(Action value) { }

		public bool IsActive(ItemContext context, out string tooltip) { }

		public bool IsSelected(Item item) { }

		[CompilerGenerated]
		public void remove_OnItemSelected(Action value) { }

		public void ToggleSelection(SelectableItemContext context) { }

	}

	[CompilerGenerated]
	private Action OnSelected; //Field offset: 0x68
	private bool _selected; //Field offset: 0x70
	protected readonly ISelectionContext _selectionContext; //Field offset: 0x78
	private SelectableItemContext _selectableSource; //Field offset: 0x80

	public event Action OnSelected
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool IsSelected
	{
		 get { } //Length: 82
	}

	public SelectableItemContext(EItemViewType viewType, ISelectionContext selectionContext) { }

	protected SelectableItemContext(Item item, EItemViewType viewType, ISelectionContext selectionContext) { }

	protected SelectableItemContext(Item item, SelectableItemContext sourceContext) { }

	protected SelectableItemContext(Item item, ItemContext sourceContext, ISelectionContext selectionContext) { }

	[CompilerGenerated]
	public void add_OnSelected(Action value) { }

	public virtual ItemContext CreateChild(Item item) { }

	public override SelectableItemContext CreateSelectableChild(Item item) { }

	public virtual void Dispose() { }

	public bool get_IsSelected() { }

	public bool IsActive(out string tooltip) { }

	private void ItemSelectionHandler(Item item, bool selected) { }

	[CompilerGenerated]
	public void remove_OnSelected(Action value) { }

	protected virtual void SwitchToParentsSource() { }

	public void ToggleSelection() { }

}

