namespace EFT.HandBook;

public class HandbookCategoryView : CategoryView
{
	[SerializeField]
	private RectTransform _nodesContainer; //Field offset: 0x1A0

	public HandbookCategoryView() { }

	protected virtual RectTransform GetSubcategoryContainer() { }

	public virtual void Show(RagFair ragfair, NodeBaseView categoryView, NodeBaseView subcategoryView, HandbookNode node, EViewListType viewListType, EWindowType windowType, Dictionary viewNodes, string forbiddenItem, Action onCategorySelected, Action onCategoryConfirmed = null) { }

}

