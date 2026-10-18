namespace EFT.UI.Ragfair;

public sealed class CombinedView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public HandbookNode node; //Field offset: 0x10
		public CombinedView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private CategoryView _categoryView; //Field offset: 0x70
	[SerializeField]
	private NodeBaseView _subcategoryView; //Field offset: 0x78
	private EViewListType _viewListType; //Field offset: 0x80
	private RagFair _ragfair; //Field offset: 0x88

	public NodeBaseView CategoryView
	{
		 get { } //Length: 5
	}

	public NodeBaseView SelectedView
	{
		 get { } //Length: 397
	}

	public NodeBaseView SubcategoryView
	{
		 get { } //Length: 5
	}

	public CombinedView() { }

	public virtual void Close() { }

	public NodeBaseView get_CategoryView() { }

	public NodeBaseView get_SelectedView() { }

	public NodeBaseView get_SubcategoryView() { }

	private void OnOffersCountUpdatedHandler(HandbookNode node) { }

	private void SetVisibility(bool visible) { }

	public void Show(RagFair ragfair, NodeBaseView categoryView, NodeBaseView subcategoryView, HandbookNode node, EViewListType viewListType, EWindowType windowType, Dictionary viewNodes, string forbiddenItem, Action onSelection, Action onConfirmedSelection = null) { }

}

