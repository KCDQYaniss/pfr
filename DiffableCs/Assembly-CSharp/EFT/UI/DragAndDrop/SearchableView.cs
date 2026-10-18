namespace EFT.UI.DragAndDrop;

[UsedImplicitly]
public sealed class SearchableView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public IItemOwner owner; //Field offset: 0x10
		public SearchableView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private SearchButton _searchButton; //Field offset: 0x70
	[SerializeField]
	private TimerText _searchTimer; //Field offset: 0x78
	[SerializeField]
	private Button _unsearchedPanel; //Field offset: 0x80
	[SerializeField]
	private GameObject _unsearchedButtonLoader; //Field offset: 0x88
	[CanBeNull]
	private IPlayerSearchController _searchController; //Field offset: 0x90
	private SearchableItem _item; //Field offset: 0x98
	private readonly BindableEvent _onShowGrids; //Field offset: 0xA0

	public IBindableEvent OnShowGrids
	{
		 get { } //Length: 8
	}

	public SearchableView() { }

	[CompilerGenerated]
	private void <Show>b__10_1() { }

	[CompilerGenerated]
	private void <Show>b__10_2(bool search) { }

	[CompilerGenerated]
	private void <Start>b__9_0() { }

	[CompilerGenerated]
	private bool <UpdateSearchState>b__13_0(SearchContentOperation x) { }

	public virtual void Close() { }

	public IBindableEvent get_OnShowGrids() { }

	private void ItemChangeHandler(ItemEventArgs args) { }

	private void ItemSearchedHandler(SearchableItem item) { }

	public void Show(SearchableItem item, IPlayerSearchController searchController) { }

	public void ShowContents() { }

	[UsedImplicitly]
	private void Start() { }

	private void UpdateSearchState() { }

}

