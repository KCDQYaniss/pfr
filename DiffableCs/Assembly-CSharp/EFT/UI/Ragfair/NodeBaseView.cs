namespace EFT.UI.Ragfair;

public class NodeBaseView : UIElement, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	private const float DOUBLE_CLICK_DELAY = 0.3; //Field offset: 0x0
	[SerializeField]
	protected TextMeshProUGUI CategoryElementName; //Field offset: 0x70
	[SerializeField]
	protected TextMeshProUGUI CategoryChildCount; //Field offset: 0x78
	[SerializeField]
	private bool _canBeSelected; //Field offset: 0x80
	[SerializeField]
	private GameObject _newNodeObject; //Field offset: 0x88
	[SerializeField]
	private GameObject _newCompletableObject; //Field offset: 0x90
	[SerializeField]
	private Image _background; //Field offset: 0x98
	[SerializeField]
	private HorizontalLayoutGroup _layoutGroup; //Field offset: 0xA0
	[SerializeField]
	private int _layoutLeftPadding; //Field offset: 0xA8
	[SerializeField]
	private Image _icon; //Field offset: 0xB0
	[SerializeField]
	private Image _iconBack; //Field offset: 0xB8
	[SerializeField]
	private GameObject _iconPanel; //Field offset: 0xC0
	[SerializeField]
	private GameObject _loader; //Field offset: 0xC8
	[SerializeField]
	private Color _selectedBackgroundColor; //Field offset: 0xD0
	[SerializeField]
	private Color32 _defaultTextColor; //Field offset: 0xE0
	[SerializeField]
	private Color32 _defaultChildCountColor; //Field offset: 0xE4
	[SerializeField]
	private Color32 _hoverTextColor; //Field offset: 0xE8
	[SerializeField]
	private Color32 _iconSelectedColor; //Field offset: 0xEC
	[SerializeField]
	private RagfairUnlockLevelView _unlockByLevel; //Field offset: 0xF0
	public HandbookNode Node; //Field offset: 0xF8
	protected EViewListType ViewListType; //Field offset: 0x100
	protected EWindowType WindowType; //Field offset: 0x104
	private HoverTrigger _trigger; //Field offset: 0x108
	private bool _iconLoaded; //Field offset: 0x110
	private bool _canBeExpanded; //Field offset: 0x111
	private int _displayedChildrenCount; //Field offset: 0x114
	private float _lastClickTime; //Field offset: 0x118
	[CompilerGenerated]
	private RagFair <Ragfair>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Dictionary <ViewNodes>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private Action <OnCategorySelected>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private Action <OnCategoryConfirmed>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private string <ForbiddenItemId>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private NodeBaseView <CategoryView>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private NodeBaseView <SubcategoryView>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private bool <Selected>k__BackingField; //Field offset: 0x158

	private Color BackgroundColor
	{
		private get { } //Length: 253
	}

	protected bool CanBeExpanded
	{
		 get { } //Length: 8
	}

	protected bool CanBeSelected
	{
		 get { } //Length: 8
	}

	protected private NodeBaseView CategoryView
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected override Color DefaultBackgroundColor
	{
		 get { } //Length: 138
	}

	protected private string ForbiddenItemId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected override Color HoverBackgroundColor
	{
		 get { } //Length: 66
	}

	protected bool IsForbidden
	{
		 get { } //Length: 489
	}

	protected private Action OnCategoryConfirmed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private Action OnCategorySelected
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private RagFair Ragfair
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private bool Selected
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected private NodeBaseView SubcategoryView
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private Dictionary ViewNodes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public NodeBaseView() { }

	[CompilerGenerated]
	private void <Show>b__71_0() { }

	[CompilerGenerated]
	private void <Show>b__71_1() { }

	[CompilerGenerated]
	private void <Show>b__71_2() { }

	[CompilerGenerated]
	private void <Show>b__71_3(Sprite arg) { }

	public void DeselectView() { }

	private Color get_BackgroundColor() { }

	protected bool get_CanBeExpanded() { }

	protected bool get_CanBeSelected() { }

	[CompilerGenerated]
	protected NodeBaseView get_CategoryView() { }

	protected override Color get_DefaultBackgroundColor() { }

	[CompilerGenerated]
	protected string get_ForbiddenItemId() { }

	protected override Color get_HoverBackgroundColor() { }

	protected bool get_IsForbidden() { }

	[CompilerGenerated]
	protected Action get_OnCategoryConfirmed() { }

	[CompilerGenerated]
	protected Action get_OnCategorySelected() { }

	[CompilerGenerated]
	protected RagFair get_Ragfair() { }

	[CompilerGenerated]
	private bool get_Selected() { }

	[CompilerGenerated]
	protected NodeBaseView get_SubcategoryView() { }

	[CompilerGenerated]
	protected Dictionary get_ViewNodes() { }

	private void NewCompletableUpdatedHandler(bool hasNewCompletable) { }

	private void NewStatusUpdatedHandler(bool isNew) { }

	protected override void OffersCountUpdatedHandler(HandbookNode node) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void PointerEnterHandler(PointerEventData eventData) { }

	public override void PointerExitHandler(PointerEventData eventData) { }

	public void SelectView() { }

	[CompilerGenerated]
	private void set_CategoryView(NodeBaseView value) { }

	[CompilerGenerated]
	private void set_ForbiddenItemId(string value) { }

	[CompilerGenerated]
	private void set_OnCategoryConfirmed(Action value) { }

	[CompilerGenerated]
	private void set_OnCategorySelected(Action value) { }

	[CompilerGenerated]
	private void set_Ragfair(RagFair value) { }

	[CompilerGenerated]
	private void set_Selected(bool value) { }

	[CompilerGenerated]
	private void set_SubcategoryView(NodeBaseView value) { }

	[CompilerGenerated]
	private void set_ViewNodes(Dictionary value) { }

	public override void Show(RagFair ragfair, NodeBaseView categoryView, NodeBaseView subcategoryView, HandbookNode node, EViewListType viewListType, EWindowType windowType, Dictionary viewNodes, string forbiddenItem, Action onCategorySelected, Action onCategoryConfirmed = null) { }

}

