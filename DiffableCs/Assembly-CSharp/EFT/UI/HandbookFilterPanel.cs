namespace EFT.UI;

public class HandbookFilterPanel : FilterPanel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__19_3; //Field offset: 0x8
		public static Func <>9__19_6; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <Awake>b__19_3(HandbookData cat) { }

		internal string <Awake>b__19_6(HandbookNode child) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public HandbookSpecialCategory special; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <Awake>b__4(HandbookData cat) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public HandbookNode node; //Field offset: 0x10
		public HierarchyFilterTab tab; //Field offset: 0x18
		public HandbookFilterPanel <>4__this; //Field offset: 0x20
		public HoverTrigger hover; //Field offset: 0x28

		public <>c__DisplayClass25_0() { }

		internal void <CreateTab>b__0(PointerEventData arg) { }

		internal void <CreateTab>b__1(PointerEventData arg) { }

		internal bool <CreateTab>b__2(HandbookSpecialCategory cat) { }

		internal void <CreateTab>b__3(Sprite iconSprite) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public KeyValuePair tabToLoad; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal void <LoadIcons>b__0(Sprite iconSprite) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public HandbookNode parentNode; //Field offset: 0x10
		public Predicate <>9__0; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal bool <RegisterInFilterTabs>b__0(HandbookNode node) { }

	}

	private sealed class HandbookFilterTabController : ITabController
	{
		private readonly int _nodeIndex; //Field offset: 0x10
		private readonly HandbookFilterPanel _panel; //Field offset: 0x18

		public HandbookFilterTabController(HandbookFilterPanel panel, int nodeIndex) { }

		public override void Show() { }

		public override Task TryHide() { }

	}

	private const string BARTER_ITEMS_CATEGORY_ID = "5b47574386f77428ca22b33e"; //Field offset: 0x0
	private readonly HashSet IGNORING_CATEGORIES; //Field offset: 0xB8
	private int _barterCategoryIndex; //Field offset: 0xC0
	[SerializeField]
	private HierarchyFilterTab _tabTemplate; //Field offset: 0xC8
	[SerializeField]
	private RectTransform _subTabsContainer; //Field offset: 0xD0
	[SerializeField]
	private RectTransform _hiddenSubGroupsContainer; //Field offset: 0xD8
	[SerializeField]
	private HandbookSpecialCategory[] _specialCategories; //Field offset: 0xE0
	private HoverTrigger _subTabsHover; //Field offset: 0xE8
	private Assortment _assortment; //Field offset: 0xF0
	private List _registeredCategoryNodes; //Field offset: 0xF8
	private int _selectedNodeIndex; //Field offset: 0x100
	private HierarchyFilterTab _currentHoveredTab; //Field offset: 0x108
	private readonly Dictionary _registeredCategories; //Field offset: 0x110
	private readonly Dictionary _tabsWithNoIcons; //Field offset: 0x118
	private float _hideAtTime; //Field offset: 0x120
	private HoverTrigger _hoveredTrigger; //Field offset: 0x128

	private Handbook Handbook
	{
		private get { } //Length: 46
	}

	public HandbookFilterPanel() { }

	[CompilerGenerated]
	private bool <Awake>b__19_2(HandbookData cat) { }

	[CompilerGenerated]
	private bool <Awake>b__19_5(HandbookNode child) { }

	[CompilerGenerated]
	private void <Awake>g__SubTabHoverEndHandler|19_1(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>g__SubTabHoverStartHandler|19_0(PointerEventData arg) { }

	protected virtual void Awake() { }

	public virtual void ClearChoice() { }

	public virtual void Close() { }

	private HierarchyFilterTab CreateTab(HandbookNode node, Transform parent) { }

	private Handbook get_Handbook() { }

	public virtual IEnumerable GetFilteredItems(IEnumerable allItems) { }

	private void HideSubTabs() { }

	private void HoverEndHandler(HoverTrigger hoverTrigger) { }

	private void HoverStartHandler(HoverTrigger hoverTrigger, HierarchyFilterTab tab) { }

	public virtual bool IsFilteredSingleItem(Item item) { }

	private void LoadIcons() { }

	public virtual void PreInit(Assortment assortment, IEnumerable items) { }

	private void RegisterInFilterTabs(Item item) { }

	public virtual void RegisterItem(Item item) { }

	private void SelectNode(int index) { }

	private void SetBarterAlpha() { }

	public virtual void Show() { }

	public virtual void UnregisterItem(Item item) { }

	private void Update() { }

}

