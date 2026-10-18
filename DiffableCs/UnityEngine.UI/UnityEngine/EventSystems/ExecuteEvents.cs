namespace UnityEngine.EventSystems;

public static class ExecuteEvents
{
	internal sealed class EventFunction`1 : MulticastDelegate
	{

		public EventFunction`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T1 handler, BaseEventData eventData) { }

	}

	private static readonly EventFunction s_PointerMoveHandler; //Field offset: 0x0
	private static readonly EventFunction s_PointerEnterHandler; //Field offset: 0x8
	private static readonly EventFunction s_PointerExitHandler; //Field offset: 0x10
	private static readonly EventFunction s_PointerDownHandler; //Field offset: 0x18
	private static readonly EventFunction s_PointerUpHandler; //Field offset: 0x20
	private static readonly EventFunction s_PointerClickHandler; //Field offset: 0x28
	private static readonly EventFunction s_InitializePotentialDragHandler; //Field offset: 0x30
	private static readonly EventFunction s_BeginDragHandler; //Field offset: 0x38
	private static readonly EventFunction s_DragHandler; //Field offset: 0x40
	private static readonly EventFunction s_EndDragHandler; //Field offset: 0x48
	private static readonly EventFunction s_DropHandler; //Field offset: 0x50
	private static readonly EventFunction s_ScrollHandler; //Field offset: 0x58
	private static readonly EventFunction s_UpdateSelectedHandler; //Field offset: 0x60
	private static readonly EventFunction s_SelectHandler; //Field offset: 0x68
	private static readonly EventFunction s_DeselectHandler; //Field offset: 0x70
	private static readonly EventFunction s_MoveHandler; //Field offset: 0x78
	private static readonly EventFunction s_SubmitHandler; //Field offset: 0x80
	private static readonly EventFunction s_CancelHandler; //Field offset: 0x88
	private static readonly List s_InternalTransformList; //Field offset: 0x90

	public static EventFunction beginDragHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction cancelHandler
	{
		 get { } //Length: 87
	}

	public static EventFunction deselectHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction dragHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction dropHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction endDragHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction initializePotentialDrag
	{
		 get { } //Length: 84
	}

	public static EventFunction moveHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction pointerClickHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction pointerDownHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction pointerEnterHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction pointerExitHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction pointerMoveHandler
	{
		 get { } //Length: 83
	}

	public static EventFunction pointerUpHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction scrollHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction selectHandler
	{
		 get { } //Length: 84
	}

	public static EventFunction submitHandler
	{
		 get { } //Length: 87
	}

	public static EventFunction updateSelectedHandler
	{
		 get { } //Length: 84
	}

	private static ExecuteEvents() { }

	public static bool CanHandleEvent(GameObject go) { }

	public static bool Execute(GameObject target, BaseEventData eventData, EventFunction functor) { }

	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	public static GameObject ExecuteHierarchy(GameObject root, BaseEventData eventData, EventFunction callbackFunction) { }

	public static EventFunction get_beginDragHandler() { }

	public static EventFunction get_cancelHandler() { }

	public static EventFunction get_deselectHandler() { }

	public static EventFunction get_dragHandler() { }

	public static EventFunction get_dropHandler() { }

	public static EventFunction get_endDragHandler() { }

	public static EventFunction get_initializePotentialDrag() { }

	public static EventFunction get_moveHandler() { }

	public static EventFunction get_pointerClickHandler() { }

	public static EventFunction get_pointerDownHandler() { }

	public static EventFunction get_pointerEnterHandler() { }

	public static EventFunction get_pointerExitHandler() { }

	public static EventFunction get_pointerMoveHandler() { }

	public static EventFunction get_pointerUpHandler() { }

	public static EventFunction get_scrollHandler() { }

	public static EventFunction get_selectHandler() { }

	public static EventFunction get_submitHandler() { }

	public static EventFunction get_updateSelectedHandler() { }

	private static void GetEventChain(GameObject root, IList eventChain) { }

	public static GameObject GetEventHandler(GameObject root) { }

	private static void GetEventList(GameObject go, IList results) { }

	private static bool ShouldSendToComponent(Component component) { }

	public static T ValidateEventData(BaseEventData data) { }

}

