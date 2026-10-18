namespace UnityEngine.UIElements;

internal interface IDragAndDropController`1
{

	public bool CanStartDrag(IEnumerable itemIds) { }

	public void DragCleanup() { }

	public IEnumerable GetSortedSelectedIds() { }

	public void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	public DragVisualMode HandleDragAndDrop(TArgs args) { }

	public void OnDrop(TArgs args) { }

	public StartDragArgs SetupDragAndDrop(IEnumerable itemIds, bool skipText = false) { }

}

