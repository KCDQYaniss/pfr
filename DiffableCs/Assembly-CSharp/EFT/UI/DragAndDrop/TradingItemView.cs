namespace EFT.UI.DragAndDrop;

public class TradingItemView : GridItemView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__26_0; //Field offset: 0x8
		public static Func <>9__27_0; //Field offset: 0x10
		public static Func <>9__39_0; //Field offset: 0x18
		public static Func <>9__39_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal float <get_Transparency>b__26_0(float baseTransparent, bool isBeingSold, bool hasNoScheme, bool outOfStock, bool priceToLow) { }

		internal bool <InitInteractiveBinding>b__27_0(bool filtered, bool dragged, bool added, bool drained, bool removed, bool searched, bool sold) { }

		internal IEnumerable <SetContainerCanvasGroup>b__39_0(Grid grid) { }

		internal bool <SetContainerCanvasGroup>b__39_1(KeyValuePair containedItem) { }

	}

	[SerializeField]
	private Image _schemeIcon; //Field offset: 0x2E0
	[SerializeField]
	private TextMeshProUGUI _currency; //Field offset: 0x2E8
	[SerializeField]
	private TextMeshProUGUI _price; //Field offset: 0x2F0
	[SerializeField]
	private GameObject _selectedBorder; //Field offset: 0x2F8
	[SerializeField]
	private GameObject _selectedCorner; //Field offset: 0x300
	[SerializeField]
	private GameObject _prepareBorder; //Field offset: 0x308
	[SerializeField]
	private GameObject _barterIcon; //Field offset: 0x310
	[SerializeField]
	private GameObject _outOfStockPanel; //Field offset: 0x318
	[SerializeField]
	private TextMeshProUGUI _outOfStockText; //Field offset: 0x320
	protected bool ModSlotView; //Field offset: 0x328
	protected Trader Trader; //Field offset: 0x330
	private Assortment _traderAssortment; //Field offset: 0x338
	private bool _canSelect; //Field offset: 0x340
	private bool _canDrag; //Field offset: 0x341
	private TradingItemContext _sourceContext; //Field offset: 0x348
	private ETradingItemViewType _itemViewType; //Field offset: 0x350
	private EOwnerType _ownerType; //Field offset: 0x354
	private readonly BindableState _isBeingSold; //Field offset: 0x358
	private readonly BindableState _hasNoScheme; //Field offset: 0x360
	private readonly BindableState _outOfStock; //Field offset: 0x368
	private readonly BindableState _priceTooLow; //Field offset: 0x370

	private bool IsTransparent
	{
		private get { } //Length: 114
	}

	protected override Nullable ItemPrice
	{
		 get { } //Length: 227
	}

	protected virtual IBindable Transparency
	{
		 get { } //Length: 688
	}

	public TradingItemView() { }

	[CompilerGenerated]
	private void <NewTradingItemView>b__29_0() { }

	[CompilerGenerated]
	private void <NewTradingItemView>b__29_1(bool x) { }

	private void AssortmentUpdatedHandler() { }

	public static TradingItemView Create(Item item, TradingItemContext sourceContext, ItemRotation rotation, Trader trader, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ETradeMode tradeMode, bool canSelect, bool canDrag, ETradingItemViewType itemViewType, ItemUiContext itemUiContext, InsuranceCompany insurance, WishlistManager wishlistStorage, bool modSlotView) { }

	private bool get_IsTransparent() { }

	protected override Nullable get_ItemPrice() { }

	protected virtual IBindable get_Transparency() { }

	protected virtual void HideTooltip() { }

	protected virtual void InitInteractiveBinding() { }

	protected TradingItemView NewTradingItemView(Item item, TradingItemContext sourceContext, ItemRotation rotation, Trader trader, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ETradeMode tradeMode, bool canSelect, bool canDrag, ETradingItemViewType itemViewType, ItemUiContext itemUiContext, InsuranceCompany insurance, WishlistManager wishlistStorage, bool modSlotView) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	private void SetContainerCanvasGroup(CompoundItem item) { }

	protected virtual void SetCountValue() { }

	public void SetPrepareBorder(bool set) { }

	protected void SetPrice(Nullable price) { }

	protected virtual void ShowTooltip() { }

	private void TradingItemSelectedHandler() { }

	public virtual void UpdateInfo() { }

	public virtual void UpdateRemoveError(bool ignoreMalfunctions = true) { }

	protected override void UpdateScheme() { }

	protected virtual void UpdateStaticInfo() { }

}

