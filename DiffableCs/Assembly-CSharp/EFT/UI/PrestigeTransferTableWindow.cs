namespace EFT.UI;

public class PrestigeTransferTableWindow : Window, ISelectionContext
{
	[CompilerGenerated]
	private Action OnItemSelected; //Field offset: 0xB8
	[SerializeField]
	private GridView _grid; //Field offset: 0xC0
	[SerializeField]
	private Vector2Int _gridSize; //Field offset: 0xC8
	private Grid _transferGrid; //Field offset: 0xD0
	private ISelectionContext _source; //Field offset: 0xD8
	private TransferStashConfig _stashConfig; //Field offset: 0xE0
	private Action _closeAction; //Field offset: 0xE8
	private int _currentSizeY; //Field offset: 0xF0

	public override event Action OnItemSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public bool IsVisible
	{
		 get { } //Length: 8
	}

	public PrestigeTransferTableWindow() { }

	[CompilerGenerated]
	public override void add_OnItemSelected(Action value) { }

	public virtual void Close() { }

	private void CreateTransferGridRecursive(Stash fakeStash, GridItemCollection items) { }

	public bool get_IsVisible() { }

	public override bool IsActive(ItemContext context, out string tooltip) { }

	public override bool IsSelected(Item item) { }

	[CompilerGenerated]
	public override void remove_OnItemSelected(Action value) { }

	public void Show(ReferenceItemContext itemContext, InventoryController inventoryController, ItemUiContext uiContext, Action closeAction, ISelectionContext source, TransferStashConfig stashConfig) { }

	public override void ToggleSelection(SelectableItemContext context) { }

}

