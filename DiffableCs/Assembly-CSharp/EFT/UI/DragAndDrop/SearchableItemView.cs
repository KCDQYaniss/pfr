namespace EFT.UI.DragAndDrop;

[UsedImplicitly]
public sealed class SearchableItemView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public ContainedGridsView containedGridsView; //Field offset: 0x10
		public SearchableItemView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private SearchableView _searchableView; //Field offset: 0x70
	[SerializeField]
	private ContainedGridsView _containedGridsTemplate; //Field offset: 0x78
	[SerializeField]
	private Transform _gridsContainer; //Field offset: 0x80
	[SerializeField]
	private GridViewMagnifier _viewMagnifier; //Field offset: 0x88
	private ContainedGridsView _containedGridsView; //Field offset: 0x90
	private ItemContext _itemContext; //Field offset: 0x98
	private CompoundItem _item; //Field offset: 0xA0
	private ItemController _itemController; //Field offset: 0xA8
	private FilterPanel _filterPanel; //Field offset: 0xB0
	private ItemUiContext _itemUiContext; //Field offset: 0xB8
	private bool _magnify; //Field offset: 0xC0

	public SearchableItemView() { }

	[UsedImplicitly]
	private void Awake() { }

	public virtual void Close() { }

	public void HideContents() { }

	public void Show(CompoundItem compoundItem, ItemContext itemContext, ItemController itemController, FilterPanel filterPanel, ItemUiContext itemUiContext) { }

	public void ShowContents() { }

	private void ShowGrids() { }

}

