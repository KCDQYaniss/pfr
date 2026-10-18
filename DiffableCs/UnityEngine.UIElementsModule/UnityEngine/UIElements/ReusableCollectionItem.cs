namespace UnityEngine.UIElements;

internal class ReusableCollectionItem
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <bindableElement>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ValueAnimation <animator>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <index>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <id>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isDragGhost>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action onGeometryChanged; //Field offset: 0x30
	protected EventCallback m_GeometryChangedEventCallback; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action onDestroy; //Field offset: 0x40

	internal event Action onDestroy
	{
		[CompilerGenerated]
		internal add { } //Length: 262
		[CompilerGenerated]
		internal remove { } //Length: 262
	}

	public event Action onGeometryChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public ValueAnimation animator
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public VisualElement bindableElement
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public int id
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int index
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal bool isDragGhost
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override VisualElement rootElement
	{
		 get { } //Length: 5
	}

	public ReusableCollectionItem() { }

	[CompilerGenerated]
	internal void add_onDestroy(Action value) { }

	[CompilerGenerated]
	public void add_onGeometryChanged(Action value) { }

	public override void DestroyElement() { }

	public override void DetachElement() { }

	[CompilerGenerated]
	public ValueAnimation get_animator() { }

	[CompilerGenerated]
	public VisualElement get_bindableElement() { }

	[CompilerGenerated]
	public int get_id() { }

	[CompilerGenerated]
	public int get_index() { }

	[CompilerGenerated]
	internal bool get_isDragGhost() { }

	public override VisualElement get_rootElement() { }

	public override void Init(VisualElement item) { }

	protected void OnGeometryChanged(GeometryChangedEvent evt) { }

	public override void PreAttachElement() { }

	[CompilerGenerated]
	internal void remove_onDestroy(Action value) { }

	[CompilerGenerated]
	public void remove_onGeometryChanged(Action value) { }

	[CompilerGenerated]
	public void set_animator(ValueAnimation value) { }

	[CompilerGenerated]
	protected void set_bindableElement(VisualElement value) { }

	[CompilerGenerated]
	public void set_id(int value) { }

	[CompilerGenerated]
	public void set_index(int value) { }

	[CompilerGenerated]
	private void set_isDragGhost(bool value) { }

	public override void SetDragGhost(bool dragGhost) { }

	public override void SetSelected(bool selected) { }

}

