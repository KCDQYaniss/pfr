namespace EFT.UI;

[DisallowMultipleComponent]
[UsedImplicitly]
public class MouseEventPropagator : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerMoveHandler, IScrollHandler
{
	private readonly BindableEvent _onClick; //Field offset: 0x20
	private readonly BindableEvent _onPointerUp; //Field offset: 0x28
	private readonly BindableEvent _onPointerDown; //Field offset: 0x30
	private readonly BindableEvent _onPointerEnter; //Field offset: 0x38
	private readonly BindableEvent _onPointerExit; //Field offset: 0x40
	private readonly BindableEvent _onDrag; //Field offset: 0x48
	private readonly BindableEvent _onBeginDrag; //Field offset: 0x50
	private readonly BindableEvent _onEndDrag; //Field offset: 0x58
	private readonly BindableEvent _onPointerMove; //Field offset: 0x60
	private readonly BindableEvent _onScroll; //Field offset: 0x68

	public IBindableEvent OnBeginDrag
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnClick
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnDrag
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnEndDrag
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnPointerDown
	{
		 get { } //Length: 76
	}

	public IBindableEvent OnPointerEnter
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnPointerExit
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnPointerMove
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnPointerUp
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnScroll
	{
		 get { } //Length: 5
	}

	public MouseEventPropagator() { }

	public IBindableEvent get_OnBeginDrag() { }

	public IBindableEvent get_OnClick() { }

	public IBindableEvent get_OnDrag() { }

	public IBindableEvent get_OnEndDrag() { }

	public IBindableEvent get_OnPointerDown() { }

	public IBindableEvent get_OnPointerEnter() { }

	public IBindableEvent get_OnPointerExit() { }

	public IBindableEvent get_OnPointerMove() { }

	public IBindableEvent get_OnPointerUp() { }

	public IBindableEvent get_OnScroll() { }

	private void Propagate(BaseEventData eventData, EventFunction handler) { }

	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerMoveHandler.OnPointerMove(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IScrollHandler.OnScroll(PointerEventData eventData) { }

}

