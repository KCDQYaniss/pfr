namespace EFT.UI;

public sealed class GridWindow : Window, IRemoveHandler, IItemRelatedView
{
	[SerializeField]
	private SearchableView _searchableView; //Field offset: 0xB8
	[SerializeField]
	private ContainedGridsView _containedGridsTemplate; //Field offset: 0xC0
	[SerializeField]
	private Image _icon; //Field offset: 0xC8
	[SerializeField]
	private Color _iconColorIdle; //Field offset: 0xD0
	[SerializeField]
	private Color _iconColorSelected; //Field offset: 0xE0
	[SerializeField]
	private Image _selectBorder; //Field offset: 0xF0
	[SerializeField]
	private Color _selectBorderColorIdle; //Field offset: 0xF8
	[SerializeField]
	private Color _selectBorderColorSelected; //Field offset: 0x108
	[SerializeField]
	[Space]
	private Image _headerBackground; //Field offset: 0x118
	[SerializeField]
	private Color _headerBackgroundIdle; //Field offset: 0x120
	[SerializeField]
	private Color _headerBackgroundSelected; //Field offset: 0x130
	[SerializeField]
	private ToggleButton _priorityWindowToggle; //Field offset: 0x140
	[SerializeField]
	private TextMeshProUGUI _tagName; //Field offset: 0x148
	[SerializeField]
	private GridSortPanel _sortPanel; //Field offset: 0x150
	private ContainedGridsView _containedGrids; //Field offset: 0x158
	private ItemController _itemController; //Field offset: 0x160
	private ItemContext _itemContext; //Field offset: 0x168
	private CompoundItem _item; //Field offset: 0x170
	private IItemOwner _itemOwner; //Field offset: 0x178
	private ItemUiContext _itemUiContext; //Field offset: 0x180
	private Item[] _parents; //Field offset: 0x188
	private EPriorityWindowMode _priorityWindowMode; //Field offset: 0x190

	public GridWindow() { }

	[CompilerGenerated]
	private void <Show>b__22_0() { }

	public virtual void Close() { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs removeItemEventArgs) { }

	private void GridWindowSelectedHandler(bool active) { }

	private void OnRectTransformDimensionsChange() { }

	public void SetSelectedAsTargetVisual(bool selected) { }

	public GridWindowContext Show(CompoundItem compoundItem, ItemContext itemContext, ItemController itemController, ItemUiContext itemUiContext, EPriorityWindowMode priorityWindowMode) { }

	private void ShowContents() { }

	private void ShowGrids() { }

	private void UpdateTag() { }

}

