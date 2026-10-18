namespace EFT.Hideout;

public sealed class FarmingView : ProduceViewBase
{
	private const float INTERVAL_SECONDS = 0.5; //Field offset: 0x0
	private const string STASH_ITEMS_FORMAT = "<color=#c5c3b2>{0}</color>
({1})"; //Field offset: 0x0
	private const string INSTALLED_ITEMS_FORMAT = "<color=#c5c3b2><b>{0}</b></color>/{1}"; //Field offset: 0x0
	private static readonly string _farmingKey; //Field offset: 0x0
	[SerializeField]
	private HideoutItemViewFactory _stashItemIconViewFactory; //Field offset: 0xC8
	[SerializeField]
	private HideoutItemViewFactory _installedIconViewFactory; //Field offset: 0xD0
	[SerializeField]
	private HideoutItemViewFactory _resultItemIconViewFactory; //Field offset: 0xD8
	[SerializeField]
	private GameObject _productionPercentagesPanel; //Field offset: 0xE0
	[SerializeField]
	private TextMeshProUGUI _productionPercentages; //Field offset: 0xE8
	[SerializeField]
	private DefaultUIButton _getItemsButton; //Field offset: 0xF0
	[SerializeField]
	private TextMeshProUGUI _productionStatus; //Field offset: 0xF8
	[SerializeField]
	private GameObject _statusContainer; //Field offset: 0x100
	[SerializeField]
	private Button _setAllButton; //Field offset: 0x108
	[SerializeField]
	private Button _setOneButton; //Field offset: 0x110
	[SerializeField]
	private Button _removeButton; //Field offset: 0x118
	[SerializeField]
	private CanvasGroup[] _addButtonsCanvases; //Field offset: 0x120
	[SerializeField]
	private CanvasGroup[] _removeButtonsCanvases; //Field offset: 0x128
	[SerializeField]
	private GameObject _loaderPanel; //Field offset: 0x130
	[SerializeField]
	private Dictionary _stateActiveObjects; //Field offset: 0x138
	private bool _requestInProgress; //Field offset: 0x140
	private DateTime _lastTimerUpdate; //Field offset: 0x148

	protected virtual bool ShowItemsListWindow
	{
		 get { } //Length: 3
	}

	private static FarmingView() { }

	public FarmingView() { }

	[CompilerGenerated]
	private void <Show>b__23_0() { }

	public virtual void Close() { }

	protected virtual bool get_ShowItemsListWindow() { }

	private void InstallAllSupplies() { }

	private void InstallOneSupplies() { }

	private void RemoveSupply() { }

	private void RequestCompleteHandler(IResult result) { }

	public void Show(ItemUiContext itemUiContext, InventoryController inventoryController, ProductionScheme scheme, BitcoinProducer producer, Action getProducedItems) { }

	private void Update() { }

	private void UpdateButtonsActivenessAndText() { }

	private void UpdateProducingInfo(ProducingItemController producingItem) { }

	private void UpdateSuppliesText() { }

	public virtual void UpdateView() { }

}

