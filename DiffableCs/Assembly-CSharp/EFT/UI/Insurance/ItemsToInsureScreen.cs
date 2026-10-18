namespace EFT.UI.Insurance;

[UsedImplicitly]
public sealed class ItemsToInsureScreen : UIElement, IAddHandler, IItemRelatedView, IRemoveHandler, IRefreshHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__18_0; //Field offset: 0x8
		public static Func <>9__18_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__18_0() { }

		internal bool <Show>b__18_1(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public ItemsToInsureScreen <>4__this; //Field offset: 0x10
		public List allEquipmentItems; //Field offset: 0x18
		public Action <>9__4; //Field offset: 0x20

		public <>c__DisplayClass18_0() { }

		internal void <Show>b__2(InsuredItem[] result) { }

		internal void <Show>b__3() { }

		internal void <Show>b__4(ItemToInsurePanel arg) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__FindOrCreate; //Field offset: 0x0

	}

	[CompilerGenerated]
	private Action OnInsuranceAvailableChanged; //Field offset: 0x70
	[SerializeField]
	private ComplexStashPanel _itemsPanel; //Field offset: 0x78
	[SerializeField]
	private ItemToInsurePanel _itemToInsurePanel; //Field offset: 0x80
	[SerializeField]
	private RectTransform _itemsToInsureContainer; //Field offset: 0x88
	[SerializeField]
	private ScrollRect _scrollRect; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _itemsToInsureCount; //Field offset: 0x98
	[SerializeField]
	private InsurerParametersPanel _insurerParametersPanel; //Field offset: 0xA0
	[SerializeField]
	private Button _insureAllButton; //Field offset: 0xA8
	[SerializeField]
	private UpdatableToggle _insureAllToggle; //Field offset: 0xB0
	public BindableEvent OnTraderChanged; //Field offset: 0xB8
	private InsuranceCompany _insurance; //Field offset: 0xC0
	private InventoryController _controller; //Field offset: 0xC8
	private BindableViewList _viewList; //Field offset: 0xD0

	public event Action OnInsuranceAvailableChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private PriceData OverallPrice
	{
		private get { } //Length: 62
	}

	public ItemsToInsureScreen() { }

	[CompilerGenerated]
	private void <Awake>b__17_0(bool arg) { }

	[CompilerGenerated]
	private void <Awake>b__17_1() { }

	[CompilerGenerated]
	private void <Awake>b__17_2(bool available) { }

	[CompilerGenerated]
	private bool <Awake>b__17_3(Item item) { }

	[CompilerGenerated]
	private void <CreateItemsToInsureList>b__19_0(InsuredItem item, ItemToInsurePanel view) { }

	[CompilerGenerated]
	public void add_OnInsuranceAvailableChanged(Action value) { }

	[UsedImplicitly]
	private void Awake() { }

	public virtual void Close() { }

	private void CreateItemsToInsureList() { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs eventArgs) { }

	private override void EFT.IRefreshHandler.OnRefreshItem(RefreshItemEventArgs eventArgs) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	private PriceData get_OverallPrice() { }

	private void OnItemUncoveredHandler(InsuredItem obj) { }

	[CompilerGenerated]
	public void remove_OnInsuranceAvailableChanged(Action value) { }

	public void Show(Profile profile, InventoryController controller, InventoryEquipment equipment, InsuranceCompany insurance, ItemUiContext itemUiContext) { }

	private void Update() { }

}

