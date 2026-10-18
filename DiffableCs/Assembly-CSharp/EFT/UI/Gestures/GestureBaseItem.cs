namespace EFT.UI.Gestures;

public abstract class GestureBaseItem : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	internal struct PointerClick
	{
		public int ItemIndex; //Field offset: 0x0
		public Vector2 Position; //Field offset: 0x4
		public InputButton Button; //Field offset: 0xC

	}

	public readonly BindableEvent OnPointerClicked; //Field offset: 0x70
	private bool _isUnderPointer; //Field offset: 0x78

	public bool IsUnderPointer
	{
		 get { } //Length: 5
		 set { } //Length: 29
	}

	public abstract int ItemIndex
	{
		 get { } //Length: 0
	}

	protected GestureBaseItem() { }

	protected abstract void BindUpdatedHandler(UpdatedGestureBind bind) { }

	public bool get_IsUnderPointer() { }

	public abstract int get_ItemIndex() { }

	private void OnDisable() { }

	public void set_IsUnderPointer(bool value) { }

	protected void ShowInternal(ECommand command, int index, string caption) { }

	protected abstract void UnderPointerChanged(bool isUnderPointer) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

