namespace EFT.Hideout;

[UsedImplicitly]
public sealed class PermanentProductionView : ProduceViewBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__12_1(Item itemToTest) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public FuelSelectionCell selectionView; //Field offset: 0x10
		public PermanentProductionView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <Show>b__2(Item selectedItem) { }

		internal void <Show>b__3() { }

	}

	private const string INSTALLED_ITEMS_FORMAT = "<color=#c5c3b2><b>{0}</b></color>/{1}"; //Field offset: 0x0
	[SerializeField]
	private HideoutItemViewFactory _resultItemIconView; //Field offset: 0xC8
	[SerializeField]
	private GameObject _productionPercentagesPanel; //Field offset: 0xD0
	[SerializeField]
	private TextMeshProUGUI _productionPercentages; //Field offset: 0xD8
	[SerializeField]
	private DefaultUIButton _getItemsButton; //Field offset: 0xE0
	[SerializeField]
	private TextMeshProUGUI _productionStatus; //Field offset: 0xE8
	[SerializeField]
	private FuelSelectionCell _resourceContainerTemplate; //Field offset: 0xF0
	[SerializeField]
	private Transform _resourceCellsContainer; //Field offset: 0xF8
	[SerializeField]
	private GameObject _loaderPanel; //Field offset: 0x100
	private FuelSelectionCell[] _selectionCells; //Field offset: 0x108

	protected virtual bool ShowItemsListWindow
	{
		 get { } //Length: 3
	}

	public PermanentProductionView() { }

	[CompilerGenerated]
	private void <Show>b__12_0() { }

	public virtual void Close() { }

	protected virtual bool get_ShowItemsListWindow() { }

	private void ItemSelectionChangedHandler(FuelSelectionCell sender, Item selectedItem) { }

	public void Show(ItemUiContext itemUiContext, InventoryController inventoryController, ProductionScheme scheme, PermanentProducer producer, Action getItems) { }

	[UsedImplicitly]
	private void Update() { }

	private void UpdateConsumableItem(Item item, int index) { }

	private void UpdateProducingInfo(ProducingItemController producingItem) { }

	public virtual void UpdateView() { }

}

