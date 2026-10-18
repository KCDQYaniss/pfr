namespace EFT.UI.Ragfair;

public class CategoryView : NodeBaseView
{
	[SerializeField]
	private Toggle _toggle; //Field offset: 0x160
	[SerializeField]
	private Transform _subcategoryContainer; //Field offset: 0x168
	[SerializeField]
	private Image _toggleImage; //Field offset: 0x170
	[SerializeField]
	private Sprite _closeSprite; //Field offset: 0x178
	[SerializeField]
	private Sprite _openSprite; //Field offset: 0x180
	[SerializeField]
	private List _views; //Field offset: 0x188
	private bool _categoryOpen; //Field offset: 0x190
	private BindableOrderedViewList _categoryViewList; //Field offset: 0x198

	protected virtual Color DefaultBackgroundColor
	{
		 get { } //Length: 138
	}

	protected GameObject ToggleObject
	{
		 get { } //Length: 93
	}

	public CategoryView() { }

	[CompilerGenerated]
	private void <Awake>b__12_0(bool value) { }

	[CompilerGenerated]
	private NodeBaseView <OpenCategory>b__14_0(HandbookNode x) { }

	[CompilerGenerated]
	private Transform <OpenCategory>b__14_1(HandbookNode x) { }

	[CompilerGenerated]
	private void <OpenCategory>b__14_2(HandbookNode item, NodeBaseView view) { }

	private void Awake() { }

	public virtual void Close() { }

	public void CloseCategory() { }

	protected virtual Color get_DefaultBackgroundColor() { }

	protected GameObject get_ToggleObject() { }

	private NodeBaseView GetNodeView(ENodeType type) { }

	protected override RectTransform GetSubcategoryContainer() { }

	protected virtual void OffersCountUpdatedHandler(HandbookNode node) { }

	[CanBeNull]
	public IEnumerable OpenCategory() { }

	private void SetExpanded(bool expanded) { }

	public virtual void Show(RagFair ragfair, NodeBaseView categoryView, NodeBaseView subcategoryView, HandbookNode node, EViewListType viewListType, EWindowType windowType, Dictionary viewNodes, string forbiddenItem, Action onCategorySelected, Action onCategoryConfirmed = null) { }

}

