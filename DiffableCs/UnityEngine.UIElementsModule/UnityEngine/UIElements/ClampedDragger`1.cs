namespace UnityEngine.UIElements;

internal class ClampedDragger`1 : Clickable
{
	[Flags]
	internal enum DragDirection
	{
		None = 0,
		LowToHigh = 1,
		HighToLow = 2,
		Free = 4,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action dragging; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action draggingEnded; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DragDirection <dragDirection>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BaseSlider <slider>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <startMousePosition>k__BackingField; //Field offset: 0x0

	public event Action dragging
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action draggingEnded
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public Vector2 delta
	{
		 get { } //Length: 53
	}

	public DragDirection dragDirection
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private BaseSlider slider
	{
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Vector2 startMousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public ClampedDragger`1(BaseSlider slider, Action clickHandler, Action dragHandler) { }

	[CompilerGenerated]
	public void add_dragging(Action value) { }

	[CompilerGenerated]
	public void add_draggingEnded(Action value) { }

	public Vector2 get_delta() { }

	[CompilerGenerated]
	public DragDirection get_dragDirection() { }

	[CompilerGenerated]
	public Vector2 get_startMousePosition() { }

	protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[CompilerGenerated]
	public void remove_dragging(Action value) { }

	[CompilerGenerated]
	public void remove_draggingEnded(Action value) { }

	[CompilerGenerated]
	public void set_dragDirection(DragDirection value) { }

	[CompilerGenerated]
	private void set_slider(BaseSlider value) { }

	[CompilerGenerated]
	private void set_startMousePosition(Vector2 value) { }

}

