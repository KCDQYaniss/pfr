namespace UnityEngine.UIElements;

public class MultiColumnTreeView : BaseTreeView
{
	internal class UxmlFactory : UxmlFactory
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_SortingEnabled; //Field offset: 0xB8
		private readonly UxmlObjectAttributeDescription m_Columns; //Field offset: 0xC0
		private readonly UxmlObjectAttributeDescription m_SortColumnDescriptions; //Field offset: 0xC8

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private Columns m_Columns; //Field offset: 0x4C0
	private bool m_SortingEnabled; //Field offset: 0x4C8
	private SortColumnDescriptions m_SortColumnDescriptions; //Field offset: 0x4D0
	private List m_SortedColumns; //Field offset: 0x4D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnSortingChanged; //Field offset: 0x4E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action headerContextMenuPopulateEvent; //Field offset: 0x4E8

	public private Columns columns
	{
		 get { } //Length: 8
		private set { } //Length: 225
	}

	public private SortColumnDescriptions sortColumnDescriptions
	{
		 get { } //Length: 8
		private set { } //Length: 243
	}

	public bool sortingEnabled
	{
		 set { } //Length: 119
	}

	public MultiColumnTreeViewController viewController
	{
		 get { } //Length: 128
	}

	public MultiColumnTreeView() { }

	public MultiColumnTreeView(Columns columns) { }

	protected virtual CollectionViewController CreateViewController() { }

	virtual void CreateVirtualizationController() { }

	public Columns get_columns() { }

	public SortColumnDescriptions get_sortColumnDescriptions() { }

	public MultiColumnTreeViewController get_viewController() { }

	private void RaiseColumnSortingChanged() { }

	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

	private void set_columns(Columns value) { }

	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	public void set_sortingEnabled(bool value) { }

	public virtual void SetViewController(CollectionViewController controller) { }

}

