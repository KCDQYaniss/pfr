namespace EFT.UI;

public sealed class ClothingItem : UIElement, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	internal enum EClothingItemState
	{
		Locked = 0,
		PurchaseAvailable = 1,
		Purchased = 2,
		Selected = 3,
	}

	internal sealed class FullOffer
	{
		public CustomizationOffer Offer; //Field offset: 0x10
		public CustomizationSuite Suite; //Field offset: 0x18
		public CustomizationClothing Clothing; //Field offset: 0x20

		public FullOffer() { }

	}

	internal sealed class OfferComparer : IComparer
	{
		private readonly CustomizationSolver _solver; //Field offset: 0x10

		public OfferComparer(CustomizationSolver solver) { }

		public override int Compare(FullOffer x, FullOffer y) { }

	}

	[SerializeField]
	private TextMeshProUGUI _clothingDescription; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _clothingName; //Field offset: 0x78
	[SerializeField]
	private Image _clothingIcon; //Field offset: 0x80
	[SerializeField]
	private GameObject _iconLoader; //Field offset: 0x88
	[SerializeField]
	private GameObject _previewIcon; //Field offset: 0x90
	[SerializeField]
	private Image _clothingIconBorder; //Field offset: 0x98
	[SerializeField]
	private ColorMap _textColor; //Field offset: 0xA0
	[SerializeField]
	private GameObject _hoveredBackground; //Field offset: 0xA8
	[SerializeField]
	private GameObject _hoveredIcon; //Field offset: 0xB0
	[SerializeField]
	private GameObject _internalObtainIcon; //Field offset: 0xB8
	[SerializeField]
	private GameObject _externalObtainIcon; //Field offset: 0xC0
	[SerializeField]
	private Dictionary _clothingItemStates; //Field offset: 0xC8
	private Action _onEquip; //Field offset: 0xD0
	private Action _onTestFit; //Field offset: 0xD8
	private ClothingIcon _icon; //Field offset: 0xE0
	private CustomizationOfferTooltip _tooltip; //Field offset: 0xE8
	private Stash _stashGrid; //Field offset: 0xF0
	private QuestBook _questBook; //Field offset: 0xF8
	private AchievementsBook _achievementsBook; //Field offset: 0x100
	private TraderInfo _traderInfo; //Field offset: 0x108
	private Profile _profile; //Field offset: 0x110
	private bool _hovered; //Field offset: 0x118
	private bool _previewed; //Field offset: 0x119
	[CompilerGenerated]
	private EClothingItemState <State>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private bool <IsPurchased>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private FullOffer <Offer>k__BackingField; //Field offset: 0x128

	public Sprite ClothingIcon
	{
		 get { } //Length: 33
	}

	public private bool IsPurchased
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private FullOffer Offer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private EClothingItemState State
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public ClothingItem() { }

	private void ApplyIconState() { }

	public virtual void Close() { }

	public Sprite get_ClothingIcon() { }

	[CompilerGenerated]
	public bool get_IsPurchased() { }

	[CompilerGenerated]
	public FullOffer get_Offer() { }

	[CompilerGenerated]
	public EClothingItemState get_State() { }

	private void IconChangedHandler() { }

	public void Init(Action onEquip, Action onTestFit, FullOffer offer, Profile profile, TraderInfo traderInfo, QuestBook questBook, AchievementsBook achievementsBook, Stash stashGrid) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	private void set_IsPurchased(bool value) { }

	[CompilerGenerated]
	private void set_Offer(FullOffer value) { }

	[CompilerGenerated]
	private void set_State(EClothingItemState value) { }

	public void SetHovered(bool hovered) { }

	public void SetItemState(EClothingItemState state) { }

	public void SetLock(bool isLocked) { }

	public void SetPreviewState(bool preview) { }

	private void UpdateView() { }

}

