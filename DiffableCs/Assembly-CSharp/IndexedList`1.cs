//Type is in global namespace

[DefaultMember("Item")]
public class IndexedList`1 : IDisposable
{
	private T[] _data; //Field offset: 0x0
	private int _used; //Field offset: 0x0
	private Queue _freeIndices; //Field offset: 0x0
	private List _activeSpheresIndices; //Field offset: 0x0

	public List ActiveIndexes
	{
		 get { } //Length: 5
	}

	public int Count
	{
		 get { } //Length: 65
	}

	public T[] Data
	{
		 get { } //Length: 5
	}

	public T Item
	{
		 get { } //Length: 208
		 set { } //Length: 370
	}

	public int Used
	{
		 get { } //Length: 4
	}

	public IndexedList`1(int size) { }

	public int Add(T item) { }

	public override void Dispose() { }

	public List get_ActiveIndexes() { }

	public int get_Count() { }

	public T[] get_Data() { }

	public T get_Item(int index) { }

	public int get_Used() { }

	public T GetDataByIndex(int index) { }

	public int Index(int i) { }

	public void Remove(int index) { }

	public void set_Item(int index, T value) { }

	public void SetDataByIndex(int index, T value) { }

}

