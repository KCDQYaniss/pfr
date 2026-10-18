namespace EFT.UI.WeaponModding;

public sealed class ModdingScreenSlotView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__58_0; //Field offset: 0x8
		public static Func <>9__58_1; //Field offset: 0x10
		public static Func <>9__58_2; //Field offset: 0x18
		public static Func <>9__58_4; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <SetFilters>b__58_0(ItemFilter x) { }

		internal bool <SetFilters>b__58_1(ItemFilter f) { }

		internal IEnumerable <SetFilters>b__58_2(ItemFilter x) { }

		internal bool <SetFilters>b__58_4(Sprite sprite) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public ItemView itemView; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal void <CreateModdingItemView>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public IEnumerable excludeTypes; //Field offset: 0x10

		public <>c__DisplayClass58_0() { }

		internal bool <SetFilters>b__3(Type t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_1
	{
		public Type t; //Field offset: 0x10

		public <>c__DisplayClass58_1() { }

		internal bool <SetFilters>b__5(Type excludeType) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__LoadModIconSprite; //Field offset: 0x0

	}

	[SerializeField]
	private Transform _filtersContainer; //Field offset: 0x70
	[SerializeField]
	private Image _boneIcon; //Field offset: 0x78
	[SerializeField]
	private RectTransform _slotCircleIcon; //Field offset: 0x80
	[SerializeField]
	private LineRenderer _lineRenderer; //Field offset: 0x88
	[SerializeField]
	private GameObject _boneNamePanel; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _boneName; //Field offset: 0x98
	[SerializeField]
	private CanvasGroup _lockedBlockCanvasGroup; //Field offset: 0xA0
	[SerializeField]
	private Transform _lockedFade; //Field offset: 0xA8
	[SerializeField]
	private Image _boneNameBackground; //Field offset: 0xB0
	[SerializeField]
	private Button _dropDownButton; //Field offset: 0xB8
	[SerializeField]
	private RectTransform _tooltipHoverArea; //Field offset: 0xC0
	[SerializeField]
	private RectTransform _moddingItemContainer; //Field offset: 0xC8
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0xD0
	[SerializeField]
	private EmptyItemView _emptyItemViewTemplate; //Field offset: 0xD8
	public RectTransform MenuAnchor; //Field offset: 0xE0
	public TextMeshProUGUI DebugText; //Field offset: 0xE8
	private CompoundItem _item; //Field offset: 0xF0
	private DropDownMenu _menu; //Field offset: 0xF8
	private InventoryController _inventoryController; //Field offset: 0x100
	private Transform _modBone; //Field offset: 0x108
	private IItemObserverScreen _moddingScreen; //Field offset: 0x110
	private SimpleTooltip _tooltip; //Field offset: 0x118
	private bool _locked; //Field offset: 0x120
	private Sprite _modOpenSprite; //Field offset: 0x128
	private Sprite _modCloseSprite; //Field offset: 0x130
	private ItemUiContext _itemUiContext; //Field offset: 0x138
	private ModdingSelectableItemContext _itemContext; //Field offset: 0x140
	private Slot _slot; //Field offset: 0x148
	[CompilerGenerated]
	private Color <Color>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private EModClass <ModClass>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private string <BoneName>k__BackingField; //Field offset: 0x168

	private string BoneName
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Color Color
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	private EModClass ModClass
	{
		[CompilerGenerated]
		private get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool UnacceptableCondition
	{
		private get { } //Length: 93
	}

	public ModdingScreenSlotView() { }

	public void CheckVisibility(EModClass visibleClasses) { }

	private void ClearFilters() { }

	public virtual void Close() { }

	private void CreateModdingItemView(SelectableItemContext itemContext, Item item, ItemController itemController, Transform container) { }

	private void DropDownButtonClickHandler() { }

	[CompilerGenerated]
	private string get_BoneName() { }

	[CompilerGenerated]
	public Color get_Color() { }

	[CompilerGenerated]
	private EModClass get_ModClass() { }

	private bool get_UnacceptableCondition() { }

	public Vector2 GetSlotScreenPosition() { }

	private void HoverEndHandler(PointerEventData pointerData) { }

	private void HoverStartHandler(PointerEventData pointerData) { }

	private void MenuClosedHandler(ModdingScreenSlotView slotView) { }

	private void MenuOpenHandler(ModdingScreenSlotView slotView) { }

	[CompilerGenerated]
	private void set_BoneName(string value) { }

	[CompilerGenerated]
	private void set_Color(Color value) { }

	[CompilerGenerated]
	private void set_ModClass(EModClass value) { }

	public void SetBoneIconActive(bool active) { }

	public void SetBoneScreenPosition(Vector2 boneScreenPosition) { }

	public void SetDebugValue(string debugValue) { }

	private void SetFilters(Slot slot) { }

	public void SetLockedStatus(bool locked) { }

	private void SetMenuOpen(bool isOpen) { }

	public void SetSlotScreenPosition(Vector2 slotScreenPosition) { }

	public void Show(ModdingSelectableItemContext itemContext, IItemObserverScreen moddingScreen, Slot slot, CompoundItem item, DropDownMenu menu, Transform modBone, InventoryController inventoryController, ItemUiContext itemUiContext) { }

	private void Start() { }

	private void UpdateInfo() { }

}

