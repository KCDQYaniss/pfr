namespace EFT.UI.Ragfair;

public sealed class SubcategoryView : NodeBaseView
{
	private const int EXPANDED_HEIGHT = 32; //Field offset: 0x0
	private const int SHRINKED_HEIGHT = 25; //Field offset: 0x0
	private const int EXPANDED_FONT_SIZE = 16; //Field offset: 0x0
	private const int SHRINKED_FONT_SIZE = 14; //Field offset: 0x0
	[SerializeField]
	private LayoutElement _mainLayoutElement; //Field offset: 0x160
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x168

	public SubcategoryView() { }

	protected virtual void OffersCountUpdatedHandler(HandbookNode node) { }

	private void SetExpandedStatus(HandbookNode node) { }

	public virtual void Show(RagFair ragfair, NodeBaseView categoryView, NodeBaseView subcategoryView, HandbookNode node, EViewListType viewListType, EWindowType windowType, Dictionary viewNodes, string forbiddenItem, Action onCategorySelected, Action onCategoryConfirmed = null) { }

}

