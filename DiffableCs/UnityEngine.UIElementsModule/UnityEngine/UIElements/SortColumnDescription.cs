namespace UnityEngine.UIElements;

public class SortColumnDescription
{
	public class UxmlObjectFactory`1 : UxmlObjectFactory
	{

		public UxmlObjectFactory`1() { }

	}

	public class UxmlObjectTraits`1 : UxmlObjectTraits
	{
		private readonly UxmlStringAttributeDescription m_ColumnName; //Field offset: 0x0
		private readonly UxmlIntAttributeDescription m_ColumnIndex; //Field offset: 0x0
		private readonly UxmlEnumAttributeDescription m_SortDescription; //Field offset: 0x0

		public UxmlObjectTraits`1() { }

		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[SerializeField]
	private int m_ColumnIndex; //Field offset: 0x10
	[SerializeField]
	private string m_ColumnName; //Field offset: 0x18
	[SerializeField]
	private SortDirection m_SortDirection; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Column <column>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action changed; //Field offset: 0x30

	internal event Action changed
	{
		[CompilerGenerated]
		internal add { } //Length: 262
		[CompilerGenerated]
		internal remove { } //Length: 262
	}

	public internal Column column
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public int columnIndex
	{
		 get { } //Length: 164
		 set { } //Length: 36
	}

	public string columnName
	{
		 get { } //Length: 5
		 set { } //Length: 182
	}

	public SortDirection direction
	{
		 get { } //Length: 4
		 set { } //Length: 36
	}

	public SortColumnDescription() { }

	public SortColumnDescription(int columnIndex, SortDirection direction) { }

	public SortColumnDescription(string columnName, SortDirection direction) { }

	[CompilerGenerated]
	internal void add_changed(Action value) { }

	[CompilerGenerated]
	public Column get_column() { }

	public int get_columnIndex() { }

	public string get_columnName() { }

	public SortDirection get_direction() { }

	[CompilerGenerated]
	internal void remove_changed(Action value) { }

	[CompilerGenerated]
	internal void set_column(Column value) { }

	public void set_columnIndex(int value) { }

	public void set_columnName(string value) { }

	public void set_direction(SortDirection value) { }

}

