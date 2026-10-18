namespace Vuplex.WebView;

[HelpURL("https://developer.vuplex.com/webview/IPointerInputDetector")]
public class DefaultPointerInputDetector : MonoBehaviour, IPointerInputDetector, IBeginDragHandler, IEventSystemHandler, IDragHandler, IPointerClickHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler, IPointerUpHandler, IScrollHandler
{
	[CompilerGenerated]
	private EventHandler BeganDrag; //Field offset: 0x20
	[CompilerGenerated]
	private EventHandler Dragged; //Field offset: 0x28
	[CompilerGenerated]
	private EventHandler PointerDown; //Field offset: 0x30
	[CompilerGenerated]
	private EventHandler PointerEntered; //Field offset: 0x38
	[CompilerGenerated]
	private EventHandler PointerExited; //Field offset: 0x40
	[CompilerGenerated]
	private EventHandler PointerMoved; //Field offset: 0x48
	[CompilerGenerated]
	private EventHandler PointerUp; //Field offset: 0x50
	[CompilerGenerated]
	private EventHandler Scrolled; //Field offset: 0x58
	[CompilerGenerated]
	private bool <PointerMovedEnabled>k__BackingField; //Field offset: 0x60
	private int _clickCount; //Field offset: 0x64
	private DateTime _lastPointerDownDateTime; //Field offset: 0x68
	private bool _isHovering; //Field offset: 0x70
	private Vector2 _previousPointerMovedPoint; //Field offset: 0x74

	public override event EventHandler BeganDrag
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler Dragged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler PointerDown
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler PointerEntered
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event EventHandler PointerExited
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler PointerMoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler PointerUp
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler Scrolled
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override bool PointerMovedEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private EventArgs _convertToEventArgs(Vector3 worldPosition) { }

	private EventArgs _convertToEventArgs(PointerEventData pointerEventData) { }

	protected override Vector2 _convertToNormalizedPoint(PointerEventData pointerEventData) { }

	protected override Vector2 _convertToNormalizedPoint(Vector3 worldPosition) { }

	private PointerEventArgs _convertToPointerEventArgs(PointerEventData eventData) { }

	private PointerEventData _getLastPointerEventData() { }

	protected override bool _positionIsZero(PointerEventData eventData) { }

	private void _processLegacyPointerMoveHandler() { }

	protected void _raiseBeganDragEvent(EventArgs eventArgs) { }

	protected void _raiseDraggedEvent(EventArgs eventArgs) { }

	protected void _raisePointerDownEvent(PointerEventArgs eventArgs) { }

	protected void _raisePointerEnteredEvent(EventArgs eventArgs) { }

	protected void _raisePointerExitedEvent(EventArgs eventArgs) { }

	protected void _raisePointerMovedEvent(EventArgs eventArgs) { }

	protected void _raisePointerUpEvent(PointerEventArgs eventArgs) { }

	protected void _raiseScrolledEvent(ScrolledEventArgs eventArgs) { }

	public DefaultPointerInputDetector() { }

	[CompilerGenerated]
	public override void add_BeganDrag(EventHandler value) { }

	[CompilerGenerated]
	public override void add_Dragged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_PointerDown(EventHandler value) { }

	[CompilerGenerated]
	public override void add_PointerEntered(EventHandler value) { }

	[CompilerGenerated]
	public override void add_PointerExited(EventHandler value) { }

	[CompilerGenerated]
	public override void add_PointerMoved(EventHandler value) { }

	[CompilerGenerated]
	public override void add_PointerUp(EventHandler value) { }

	[CompilerGenerated]
	public override void add_Scrolled(EventHandler value) { }

	[CompilerGenerated]
	public override bool get_PointerMovedEnabled() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerMove(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void OnScroll(PointerEventData eventData) { }

	[CompilerGenerated]
	public override void remove_BeganDrag(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_Dragged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_PointerDown(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_PointerEntered(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_PointerExited(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_PointerMoved(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_PointerUp(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_Scrolled(EventHandler value) { }

	[CompilerGenerated]
	public override void set_PointerMovedEnabled(bool value) { }

	protected override void Update() { }

}

