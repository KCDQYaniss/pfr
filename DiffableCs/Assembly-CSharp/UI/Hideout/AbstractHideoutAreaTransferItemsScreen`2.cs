namespace UI.Hideout;

public abstract class AbstractHideoutAreaTransferItemsScreen`2 : BaseHideoutAreaTransferItemsScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public TemplatedGridsView templatedGridsView; //Field offset: 0x0
		public AbstractHideoutAreaTransferItemsScreen <>4__this; //Field offset: 0x0

		public <>c__DisplayClass10_0() { }

		internal void <UpdateAreaStashView>b__0() { }

	}

	[SerializeField]
	protected Transform _parent; //Field offset: 0x0
	[SerializeField]
	private HandoverHideoutAreaStashItemsWindow _handoverItemsWindow; //Field offset: 0x0
	protected ContainedGridsView _containedGridsView; //Field offset: 0x0
	private WindowContext _handoverWindowContext; //Field offset: 0x0
	private bool _canAddToFavorites; //Field offset: 0x0
	private VirtualContainer _filteredContainer; //Field offset: 0x0

	protected virtual bool SetAsLastSiblingTabGroup
	{
		 get { } //Length: 3
	}

	protected AbstractHideoutAreaTransferItemsScreen`2() { }

	public virtual void Close() { }

	private void DestroyPreviousGridView() { }

	protected virtual bool get_SetAsLastSiblingTabGroup() { }

	private void OnAllItemFilterHandler(string localizationKey) { }

	private void OpenHandoverWindow(IContainer container, string localizationKey) { }

	protected void Show(AreaData areaData, InventoryController controller, bool canAddToFavorites, IEftSession session) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	protected virtual void UpdateAreaStashView(AreaData areaData, CompoundItem stash) { }

	protected virtual void UpdateTabGroup(int selectedTabIndex) { }

}

