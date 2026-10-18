namespace EFT.UI.DragAndDrop;

public interface IContainerView
{

	public Task AcceptItem(DragItemContext itemContext, ItemContext targetItemContext) { }

	public bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	public bool CanDrag(ItemContext itemContext) { }

	public void DisableHighlight() { }

	public void DragCancelled() { }

	public void DragStarted() { }

	public void HighlightItemViewPosition(DragItemContext itemContext, ItemContext targetItemContext, bool preview) { }

}

