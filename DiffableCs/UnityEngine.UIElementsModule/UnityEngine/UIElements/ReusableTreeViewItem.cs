namespace UnityEngine.UIElements;

internal class ReusableTreeViewItem : ReusableCollectionItem
{
	private Toggle m_Toggle; //Field offset: 0x48
	private VisualElement m_Container; //Field offset: 0x50
	private VisualElement m_IndentElement; //Field offset: 0x58
	private VisualElement m_BindableContainer; //Field offset: 0x60
	private VisualElement m_Checkmark; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action onPointerUp; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action onToggleValueChanged; //Field offset: 0x78
	private int m_Depth; //Field offset: 0x80
	private float m_IndentWidth; //Field offset: 0x84
	private EventCallback m_PointerUpCallback; //Field offset: 0x88
	private EventCallback m_ToggleValueChangedCallback; //Field offset: 0x90
	private EventCallback m_ToggleGeometryChangedCallback; //Field offset: 0x98

	public event Action onPointerUp
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action onToggleValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public virtual VisualElement rootElement
	{
		 get { } //Length: 14
	}

	public ReusableTreeViewItem() { }

	[CompilerGenerated]
	public void add_onPointerUp(Action value) { }

	[CompilerGenerated]
	public void add_onToggleValueChanged(Action value) { }

	public virtual void DetachElement() { }

	public virtual VisualElement get_rootElement() { }

	public void Indent(int depth) { }

	public virtual void Init(VisualElement item) { }

	protected void InitExpandHierarchy(VisualElement root, VisualElement item) { }

	private void OnPointerUp(PointerUpEvent evt) { }

	private void OnToggleGeometryChanged(GeometryChangedEvent evt) { }

	private void OnToggleValueChanged(ChangeEvent evt) { }

	public virtual void PreAttachElement() { }

	[CompilerGenerated]
	public void remove_onPointerUp(Action value) { }

	[CompilerGenerated]
	public void remove_onToggleValueChanged(Action value) { }

	public void SetExpandedWithoutNotify(bool expanded) { }

	public void SetToggleVisibility(bool visible) { }

	private void UpdateIndentLayout() { }

}

