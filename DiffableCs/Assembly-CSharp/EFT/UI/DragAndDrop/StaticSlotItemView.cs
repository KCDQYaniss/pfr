namespace EFT.UI.DragAndDrop;

public abstract class StaticSlotItemView : SlotItemView
{

	protected StaticSlotItemView() { }

	protected virtual void CheckAcceptHandler(DragItemContext dragItemContext) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	protected virtual void RegisterItemView() { }

}

