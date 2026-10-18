namespace ChartAndGraph;

internal class ChartItemEvents : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, InternalItemEvents
{
	internal class Event : UnityEvent
	{

		public Event() { }

	}

	[SerializeField]
	private ChartItemTextBlend _textBlend; //Field offset: 0x20
	private bool _mouseOver; //Field offset: 0x28
	private bool _mouseDown; //Field offset: 0x29
	private IInternalUse _parent; //Field offset: 0x30
	private object _userData; //Field offset: 0x38

	private override IInternalUse ChartAndGraph.InternalItemEvents.Parent
	{
		private get { } //Length: 76
		private set { } //Length: 82
	}

	private override object ChartAndGraph.InternalItemEvents.UserData
	{
		private get { } //Length: 5
		private set { } //Length: 82
	}

	public ChartItemEvents() { }

	private override IInternalUse ChartAndGraph.InternalItemEvents.get_Parent() { }

	private override object ChartAndGraph.InternalItemEvents.get_UserData() { }

	private override void ChartAndGraph.InternalItemEvents.set_Parent(IInternalUse value) { }

	private override void ChartAndGraph.InternalItemEvents.set_UserData(object value) { }

	public void OnMouseDown() { }

	public void OnMouseEnter() { }

	private void OnMouseExit() { }

	private void OnMouseUp() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

}

