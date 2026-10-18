namespace ChartAndGraph;

[DefaultMember("Item")]
public abstract class ChartDataSourceBaseCollection`1 : ICollection, IEnumerable, IEnumerable
{
	private Dictionary mNameToItem; //Field offset: 0x0
	private List mItems; //Field offset: 0x0
	[CompilerGenerated]
	private Action NameChanged; //Field offset: 0x0
	[CompilerGenerated]
	private EventHandler OrderChanged; //Field offset: 0x0
	[CompilerGenerated]
	private Action ItemRemoved; //Field offset: 0x0

	public event Action ItemRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action NameChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler OrderChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override int Count
	{
		 get { } //Length: 26
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public T Item
	{
		 get { } //Length: 64
	}

	public T Item
	{
		 get { } //Length: 194
	}

	protected abstract string ItemTypeName
	{
		 get { } //Length: 0
	}

	protected ChartDataSourceBaseCollection`1() { }

	public override void Add(T item) { }

	[CompilerGenerated]
	public void add_ItemRemoved(Action value) { }

	[CompilerGenerated]
	public void add_NameChanged(Action value) { }

	[CompilerGenerated]
	public void add_OrderChanged(EventHandler value) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public T get_Item(string name) { }

	public T get_Item(int index) { }

	protected abstract string get_ItemTypeName() { }

	public override IEnumerator GetEnumerator() { }

	public void Insert(int index, T item) { }

	private void NameChangedHandler(string prevName, IDataItem item) { }

	public override bool Remove(T item) { }

	[CompilerGenerated]
	public void remove_ItemRemoved(Action value) { }

	[CompilerGenerated]
	public void remove_NameChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OrderChanged(EventHandler value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetIndexByName(string name, out int result) { }

}

