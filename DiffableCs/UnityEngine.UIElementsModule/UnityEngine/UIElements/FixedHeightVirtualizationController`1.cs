namespace UnityEngine.UIElements;

internal class FixedHeightVirtualizationController`1 : VerticalVirtualizationController
{

	private float resolvedItemHeight
	{
		private get { } //Length: 66
	}

	public FixedHeightVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	internal virtual void EndDrag(int dropIndex) { }

	private float get_resolvedItemHeight() { }

	public virtual float GetExpectedContentHeight() { }

	public virtual float GetExpectedItemHeight(int index) { }

	public virtual int GetIndexFromPosition(Vector2 position) { }

	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	public virtual void OnScroll(Vector2 scrollOffset) { }

	public virtual void Resize(Vector2 size) { }

	public virtual void ScrollToItem(int index) { }

	protected virtual bool VisibleItemPredicate(T i) { }

}

