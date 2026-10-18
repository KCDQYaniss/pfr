namespace EFT.UI.Insurance;

public sealed class ItemToInsurePanel : UIElement, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public ItemToInsurePanel <>4__this; //Field offset: 0x10
		public ItemToInsurePanel panelTemplate; //Field offset: 0x18
		public ItemsToInsureScreen insureScreen; //Field offset: 0x20

		public <>c__DisplayClass22_0() { }

		internal void <Show>b__0(InsuredItem child, ItemToInsurePanel view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public InsurePrices selectedInsurer; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal int <UpdatePrice>b__0(InsuredItem x) { }

	}

	[SerializeField]
	private TextMeshProUGUI _itemNameLabel; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _itemPriceLabel; //Field offset: 0x78
	[SerializeField]
	private Image _background; //Field offset: 0x80
	[SerializeField]
	private Color _defaultColor; //Field offset: 0x88
	[SerializeField]
	private Color _selectedColor; //Field offset: 0x98
	[SerializeField]
	private TradeItemType _itemType; //Field offset: 0xA8
	[SerializeField]
	private GameObject _childItemSpace; //Field offset: 0xB0
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI _itemsToInsureCount; //Field offset: 0xC0
	[SerializeField]
	private InsurerParametersPanel _insurerParametersPanel; //Field offset: 0xC8
	[SerializeField]
	private RectTransform _childContainer; //Field offset: 0xD0
	[SerializeField]
	private SwitchableParamsButton _dropdownButton; //Field offset: 0xD8
	private BindableViewList _viewList; //Field offset: 0xE0
	private InsuranceCompany _insurance; //Field offset: 0xE8
	private bool _expandedList; //Field offset: 0xF0
	[CompilerGenerated]
	private InsuredItem <InsuredItem>k__BackingField; //Field offset: 0xF8

	private InsuredItem InsuredItem
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private PriceData OverallPrice
	{
		private get { } //Length: 62
	}

	public ItemToInsurePanel() { }

	[CompilerGenerated]
	private void <Awake>b__21_0() { }

	[CompilerGenerated]
	private void <OnTraderChangedHandler>b__23_0(ItemToInsurePanel arg) { }

	[CompilerGenerated]
	private void <UpdateInsuranceItemsPrices>b__26_0(InsuredItem[] insuredItems) { }

	private void Awake() { }

	[CompilerGenerated]
	private InsuredItem get_InsuredItem() { }

	private PriceData get_OverallPrice() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void OnTraderChangedHandler() { }

	[CompilerGenerated]
	private void set_InsuredItem(InsuredItem value) { }

	public void SetAsChild(ItemToInsurePanel child, int parentsLevel) { }

	private void SetChildContainerStatus(bool value) { }

	private void SetCountParameters() { }

	public void Show(InsuredItem insuredItem, EItemType itemType, InsuranceCompany insurance, ItemToInsurePanel panelTemplate, ItemsToInsureScreen insureScreen) { }

	public void UpdateInsuranceItemsPrices(IEnumerable items) { }

	private void UpdatePrice() { }

	private void UpdatePrice(int price, int childPrice) { }

}

