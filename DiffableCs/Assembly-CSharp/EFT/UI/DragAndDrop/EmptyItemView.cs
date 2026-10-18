namespace EFT.UI.DragAndDrop;

public sealed class EmptyItemView : UIElement, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private CanvasGroup _highlight; //Field offset: 0x70
	private ModdingSelectableItemContext _itemContext; //Field offset: 0x78
	private bool _interactable; //Field offset: 0x80

	public bool Interactable
	{
		 get { } //Length: 8
		 set { } //Length: 208
	}

	public EmptyItemView() { }

	public virtual void Close() { }

	public bool get_Interactable() { }

	public void set_Interactable(bool value) { }

	public void Show(ModdingSelectableItemContext itemContext) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

