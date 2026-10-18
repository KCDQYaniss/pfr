namespace EFT.UI.Ragfair;

public sealed class OfferView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__101_4; //Field offset: 0x8
		public static Func <>9__101_5; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__101_4() { }

		internal UpdatableChatMember <Awake>b__101_5(string id) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass114_0
	{
		public int unlockLevel; //Field offset: 0x10

		public <>c__DisplayClass114_0() { }

		internal string <AvailableOfferStatus>b__0() { }

	}

	private const int HOVER_ALPHA = 85; //Field offset: 0x0
	[SerializeField]
	private GameObject _checkboxPanel; //Field offset: 0x70
	[SerializeField]
	private GameObject _selectedMark; //Field offset: 0x78
	[SerializeField]
	private Image _minimizeButton; //Field offset: 0x80
	[SerializeField]
	private Sprite _minimizedSprite; //Field offset: 0x88
	[SerializeField]
	private Sprite _expandedSprite; //Field offset: 0x90
	[SerializeField]
	private GameObject _buttonsContainer; //Field offset: 0x98
	[SerializeField]
	private DefaultUIButton _purchaseButton; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _removeButton; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _offerId; //Field offset: 0xB0
	[SerializeField]
	private GameObject _exchangeOffer; //Field offset: 0xB8
	[SerializeField]
	private MerchantInfoView _merchantInfoView; //Field offset: 0xC0
	[SerializeField]
	private CanvasGroup _merchantCanvasGroup; //Field offset: 0xC8
	[SerializeField]
	private OfferItemDescription _descriptionShrunk; //Field offset: 0xD0
	[SerializeField]
	private OfferItemDescription _descriptionExpanded; //Field offset: 0xD8
	[SerializeField]
	private OfferItemPrice _priceShrunk; //Field offset: 0xE0
	[SerializeField]
	private OfferItemPrice _priceExpanded; //Field offset: 0xE8
	[SerializeField]
	private GameObject _lockedButton; //Field offset: 0xF0
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0xF8
	[SerializeField]
	private HoverTooltipAreaClick _hoverTooltipArea; //Field offset: 0x100
	[SerializeField]
	private Button _renewButton; //Field offset: 0x108
	[SerializeField]
	private Image _disabledPanel; //Field offset: 0x110
	[SerializeField]
	private Image _selectedBackground; //Field offset: 0x118
	[SerializeField]
	private GameObject _notAvailableButton; //Field offset: 0x120
	[SerializeField]
	private GameObject _outOfStockButton; //Field offset: 0x128
	[SerializeField]
	private GameObject _expirationTimePanel; //Field offset: 0x130
	[SerializeField]
	private TextMeshProUGUI _expirationLabel; //Field offset: 0x138
	[SerializeField]
	private TextMeshProUGUI _createdTimeLabel; //Field offset: 0x140
	[SerializeField]
	private GameObject _availableTimePanel; //Field offset: 0x148
	[SerializeField]
	private TextMeshProUGUI _availableTimeLabel; //Field offset: 0x150
	[SerializeField]
	private GameObject _loader; //Field offset: 0x158
	[SerializeField]
	private Image[] _backgroundImages; //Field offset: 0x160
	[SerializeField]
	private Image _timeLeftImage; //Field offset: 0x168
	[SerializeField]
	private Image _borderImage; //Field offset: 0x170
	[SerializeField]
	private Image _backgroundIdImage; //Field offset: 0x178
	[SerializeField]
	private Sprite _myIdSprite; //Field offset: 0x180
	[SerializeField]
	private Sprite _traderIdSprite; //Field offset: 0x188
	private readonly Dictionary _defaultBackgroundColors; //Field offset: 0x190
	private readonly Dictionary _hoverBackgroundColors; //Field offset: 0x198
	private int _delaySinceOfferAdd; //Field offset: 0x1A0
	private EViewListType _viewType; //Field offset: 0x1A4
	private Handbook _handbook; //Field offset: 0x1A8
	private string _profileId; //Field offset: 0x1B0
	private TraderInfo _trader; //Field offset: 0x1B8
	private RagFair _ragfair; //Field offset: 0x1C0
	private InventoryController _inventoryController; //Field offset: 0x1C8
	private InsuranceCompany _insuranceCompany; //Field offset: 0x1D0
	private ItemUiContext _itemUiContext; //Field offset: 0x1D8
	private SocialNetwork _social; //Field offset: 0x1E0
	private Action _onRenew; //Field offset: 0x1E8
	private Action _onPurchase; //Field offset: 0x1F0
	private Action _onExpired; //Field offset: 0x1F8
	private Action _onRemove; //Field offset: 0x200
	private Color32 _defaultColor; //Field offset: 0x208
	private Color32 _defaultHoverColor; //Field offset: 0x20C
	private DateTime _lastUpdateStamp; //Field offset: 0x210
	private double _updateTime; //Field offset: 0x218
	private bool _expiredSoon; //Field offset: 0x220
	private bool _hovered; //Field offset: 0x221
	private Nullable _expanded; //Field offset: 0x222
	private int _amountNeeded; //Field offset: 0x224
	[CompilerGenerated]
	private Offer <Offer>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	private OfferData <OfferData>k__BackingField; //Field offset: 0x230

	private static Color32 BackgroundExpiredSoonColor
	{
		private get { } //Length: 13
	}

	private TimeSpan CreationTime
	{
		private get { } //Length: 160
	}

	private static Color32 DefaultPanelColor
	{
		private get { } //Length: 13
	}

	private static Color32 DefaultTextColor
	{
		private get { } //Length: 13
	}

	private static Color32 ExpiredSoonTextColor
	{
		private get { } //Length: 13
	}

	private static Color32 HoveredBackgroundExpiredSoonColor
	{
		private get { } //Length: 13
	}

	private bool IsMyOffer
	{
		private get { } //Length: 284
	}

	private bool IsOutOfStock
	{
		private get { } //Length: 36
	}

	private bool IsTraderOffer
	{
		private get { } //Length: 60
	}

	private bool IsWeaponBuildOffer
	{
		private get { } //Length: 11
	}

	private static Color32 MyOfferBorderColor
	{
		private get { } //Length: 13
	}

	private static Color32 MyOfferPanelColor
	{
		private get { } //Length: 13
	}

	private static Color32 NotAvailableColor
	{
		private get { } //Length: 13
	}

	private Offer Offer
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private OfferData OfferData
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private bool OfferNotAvailable
	{
		private get { } //Length: 105
	}

	private static Color32 OutOfStockColor
	{
		private get { } //Length: 13
	}

	private TimeSpan TimeLeft
	{
		private get { } //Length: 164
	}

	public OfferView() { }

	[CompilerGenerated]
	private void <Awake>b__101_0(PointerEventData eventData) { }

	[CompilerGenerated]
	private void <Awake>b__101_1(PointerEventData eventData) { }

	[CompilerGenerated]
	private void <Awake>b__101_2() { }

	[CompilerGenerated]
	private void <Awake>b__101_3() { }

	[CompilerGenerated]
	private void <Awake>b__101_6() { }

	[CompilerGenerated]
	private void <Awake>b__101_7() { }

	private bool AvailableOfferStatus() { }

	private void Awake() { }

	public virtual void Close() { }

	private static Color32 get_BackgroundExpiredSoonColor() { }

	private TimeSpan get_CreationTime() { }

	private static Color32 get_DefaultPanelColor() { }

	private static Color32 get_DefaultTextColor() { }

	private static Color32 get_ExpiredSoonTextColor() { }

	private static Color32 get_HoveredBackgroundExpiredSoonColor() { }

	private bool get_IsMyOffer() { }

	private bool get_IsOutOfStock() { }

	private bool get_IsTraderOffer() { }

	private bool get_IsWeaponBuildOffer() { }

	private static Color32 get_MyOfferBorderColor() { }

	private static Color32 get_MyOfferPanelColor() { }

	private static Color32 get_NotAvailableColor() { }

	[CompilerGenerated]
	private Offer get_Offer() { }

	[CompilerGenerated]
	private OfferData get_OfferData() { }

	private bool get_OfferNotAvailable() { }

	private static Color32 get_OutOfStockColor() { }

	private TimeSpan get_TimeLeft() { }

	private void ItemStackCountUpdatedHandler() { }

	private void OfferSoldHandler(Offer offer, int count, string handbookId) { }

	private void OnOfferProcessingHandler(IEnumerable offerIds, bool finished) { }

	private void OnOfferSelectedToPurchase(Offer offer, bool value) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void PurchaseButtonPressedHandler() { }

	[CompilerGenerated]
	private void set_Offer(Offer value) { }

	[CompilerGenerated]
	private void set_OfferData(OfferData value) { }

	private void SetBackgroundColor(Image image, bool hovered) { }

	private void SetBackgroundColors() { }

	private void SetColorScheme(bool hovered, bool bordered) { }

	private void SetExpandedStatus(bool expanded) { }

	private void SetUpdateTime() { }

	public void Show(EViewListType viewType, OfferData data) { }

	private void ShowAction() { }

	private void Tick() { }

	private void Update() { }

	private void UpdateAvailability() { }

	private void UpdateRenewButton() { }

}

