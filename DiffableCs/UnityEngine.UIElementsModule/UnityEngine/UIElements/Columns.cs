namespace UnityEngine.UIElements;

[DefaultMember("Item")]
public class Columns : ICollection, IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__76_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateVisibleColumns>b__76_0(Column c) { }

	}

	internal enum StretchMode
	{
		Grow = 0,
		GrowAndFill = 1,
	}

	public class UxmlObjectFactory`1 : UxmlObjectFactory
	{

		public UxmlObjectFactory`1() { }

	}

	public class UxmlObjectTraits`1 : UxmlObjectTraits
	{
		private readonly UxmlStringAttributeDescription m_PrimaryColumnName; //Field offset: 0x0
		private readonly UxmlEnumAttributeDescription m_StretchMode; //Field offset: 0x0
		private readonly UxmlBoolAttributeDescription m_Reorderable; //Field offset: 0x0
		private readonly UxmlBoolAttributeDescription m_Resizable; //Field offset: 0x0
		private readonly UxmlBoolAttributeDescription m_ResizePreview; //Field offset: 0x0
		private readonly UxmlObjectListAttributeDescription m_Columns; //Field offset: 0x0

		public UxmlObjectTraits`1() { }

		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	private IList m_Columns; //Field offset: 0x10
	private List m_DisplayColumns; //Field offset: 0x18
	private List m_VisibleColumns; //Field offset: 0x20
	private bool m_VisibleColumnsDirty; //Field offset: 0x28
	private StretchMode m_StretchMode; //Field offset: 0x2C
	private bool m_Reorderable; //Field offset: 0x30
	private bool m_Resizable; //Field offset: 0x31
	private bool m_ResizePreview; //Field offset: 0x32
	private string m_PrimaryColumnName; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action changed; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnAdded; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnRemoved; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnChanged; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnResized; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnReordered; //Field offset: 0x68

	internal event Action changed
	{
		[CompilerGenerated]
		internal add { } //Length: 262
		[CompilerGenerated]
		internal remove { } //Length: 262
	}

	internal event Action columnAdded
	{
		[CompilerGenerated]
		internal add { } //Length: 262
		[CompilerGenerated]
		internal remove { } //Length: 262
	}

	internal event Action columnChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 262
		[CompilerGenerated]
		internal remove { } //Length: 262
	}

	internal event Action columnRemoved
	{
		[CompilerGenerated]
		internal add { } //Length: 262
		[CompilerGenerated]
		internal remove { } //Length: 262
	}

	internal event Action columnReordered
	{
		[CompilerGenerated]
		internal add { } //Length: 262
		[CompilerGenerated]
		internal remove { } //Length: 262
	}

	internal event Action columnResized
	{
		[CompilerGenerated]
		internal add { } //Length: 262
		[CompilerGenerated]
		internal remove { } //Length: 262
	}

	public override int Count
	{
		 get { } //Length: 75
	}

	internal IEnumerable displayList
	{
		internal get { } //Length: 26
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 78
	}

	public Column Item
	{
		 get { } //Length: 87
	}

	public Column Item
	{
		 get { } //Length: 414
	}

	public string primaryColumnName
	{
		 get { } //Length: 5
		 set { } //Length: 181
	}

	public bool reorderable
	{
		 get { } //Length: 5
		 set { } //Length: 45
	}

	public bool resizable
	{
		 get { } //Length: 5
		 set { } //Length: 45
	}

	public bool resizePreview
	{
		 get { } //Length: 5
		 set { } //Length: 45
	}

	public StretchMode stretchMode
	{
		 get { } //Length: 4
		 set { } //Length: 45
	}

	internal IEnumerable visibleList
	{
		internal get { } //Length: 26
	}

	public Columns() { }

	public override void Add(Column item) { }

	[CompilerGenerated]
	internal void add_changed(Action value) { }

	[CompilerGenerated]
	internal void add_columnAdded(Action value) { }

	[CompilerGenerated]
	internal void add_columnChanged(Action value) { }

	[CompilerGenerated]
	internal void add_columnRemoved(Action value) { }

	[CompilerGenerated]
	internal void add_columnReordered(Action value) { }

	[CompilerGenerated]
	internal void add_columnResized(Action value) { }

	public override void Clear() { }

	public bool Contains(string name) { }

	public override bool Contains(Column item) { }

	public override void CopyTo(Column[] array, int arrayIndex) { }

	private void DirtyVisibleColumns() { }

	public override int get_Count() { }

	internal IEnumerable get_displayList() { }

	public override bool get_IsReadOnly() { }

	public Column get_Item(int index) { }

	public Column get_Item(string name) { }

	public string get_primaryColumnName() { }

	public bool get_reorderable() { }

	public bool get_resizable() { }

	public bool get_resizePreview() { }

	public StretchMode get_stretchMode() { }

	internal IEnumerable get_visibleList() { }

	public override IEnumerator GetEnumerator() { }

	public int IndexOf(Column column) { }

	private void InitOrderColumns() { }

	public void Insert(int index, Column column) { }

	public bool IsPrimary(Column column) { }

	private void NotifyChange(ColumnsDataType type) { }

	private void OnColumnChanged(Column column, ColumnDataType type) { }

	private void OnColumnResized(Column column) { }

	public override bool Remove(Column column) { }

	[CompilerGenerated]
	internal void remove_changed(Action value) { }

	[CompilerGenerated]
	internal void remove_columnAdded(Action value) { }

	[CompilerGenerated]
	internal void remove_columnChanged(Action value) { }

	[CompilerGenerated]
	internal void remove_columnRemoved(Action value) { }

	[CompilerGenerated]
	internal void remove_columnReordered(Action value) { }

	[CompilerGenerated]
	internal void remove_columnResized(Action value) { }

	public void ReorderDisplay(int from, int to) { }

	public void set_primaryColumnName(string value) { }

	public void set_reorderable(bool value) { }

	public void set_resizable(bool value) { }

	public void set_resizePreview(bool value) { }

	public void set_stretchMode(StretchMode value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void UpdateVisibleColumns() { }

}

