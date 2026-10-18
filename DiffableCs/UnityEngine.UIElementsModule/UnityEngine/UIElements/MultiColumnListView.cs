namespace UnityEngine.UIElements;

public class MultiColumnListView : BaseListView
{
	internal class UxmlFactory : UxmlFactory
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_SortingEnabled; //Field offset: 0xD8
		private readonly UxmlObjectAttributeDescription m_Columns; //Field offset: 0xE0
		private readonly UxmlObjectAttributeDescription m_SortColumnDescriptions; //Field offset: 0xE8

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private Columns m_Columns; //Field offset: 0x540
	private bool m_SortingEnabled; //Field offset: 0x548
	private SortColumnDescriptions m_SortColumnDescriptions; //Field offset: 0x550
	private List m_SortedColumns; //Field offset: 0x558
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnSortingChanged; //Field offset: 0x560
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action headerContextMenuPopulateEvent; //Field offset: 0x568

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

	public MultiColumnListViewController viewController
	{
		 get { } //Length: 128
	}

	public MultiColumnListView() { }

	public MultiColumnListView(Columns columns) { }

	protected virtual CollectionViewController CreateViewController() { }

	virtual void CreateVirtualizationController() { }

	public Columns get_columns() { }

	public SortColumnDescriptions get_sortColumnDescriptions() { }

	public MultiColumnListViewController get_viewController() { }

	private void RaiseColumnSortingChanged() { }

	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

	private void set_columns(Columns value) { }

	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	public void set_sortingEnabled(bool value) { }

	public virtual void SetViewController(CollectionViewController controller) { }

}

