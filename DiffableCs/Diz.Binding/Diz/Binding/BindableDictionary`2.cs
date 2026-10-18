namespace Diz.Binding;

[DefaultMember("Item")]
public class BindableDictionary`2 : IDictionary, ICollection, IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private Action ItemAdded; //Field offset: 0x0
	[CompilerGenerated]
	private Action ItemRemoved; //Field offset: 0x0
	[CompilerGenerated]
	private Action ItemsAdded; //Field offset: 0x0
	[CompilerGenerated]
	private Action ItemsRemoved; //Field offset: 0x0
	[CompilerGenerated]
	private Action AllItemsRemoved; //Field offset: 0x0
	private readonly BindableEvent OnItemsChanged; //Field offset: 0x0
	private readonly Dictionary _dictionary; //Field offset: 0x0
	private BindableDictionaryToListAdapter _listAdapter; //Field offset: 0x0

	public event Action AllItemsRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action ItemAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action ItemRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action ItemsAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action ItemsRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override int Count
	{
		 get { } //Length: 29
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override TV Item
	{
		 get { } //Length: 42
		 set { } //Length: 267
	}

	public override ICollection Keys
	{
		 get { } //Length: 42
	}

	public override ICollection Values
	{
		 get { } //Length: 42
	}

	protected BindableDictionary`2() { }

	public override void Add(KeyValuePair item) { }

	public override void Add(TK key, TV value) { }

	[CompilerGenerated]
	public void add_AllItemsRemoved(Action value) { }

	[CompilerGenerated]
	public void add_ItemAdded(Action value) { }

	[CompilerGenerated]
	public void add_ItemRemoved(Action value) { }

	[CompilerGenerated]
	public void add_ItemsAdded(Action value) { }

	[CompilerGenerated]
	public void add_ItemsRemoved(Action value) { }

	public override void AddRange(IDictionary dict) { }

	public IBindableList AsBindableList() { }

	public override void Clear() { }

	public override bool Contains(KeyValuePair item) { }

	public override bool ContainsKey(TK key) { }

	public override void CopyTo(KeyValuePair[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override TV get_Item(TK key) { }

	public override ICollection get_Keys() { }

	public override ICollection get_Values() { }

	public override IEnumerator GetEnumerator() { }

	public override bool Remove(TK existingItem) { }

	public override bool Remove(KeyValuePair item) { }

	[CompilerGenerated]
	public void remove_AllItemsRemoved(Action value) { }

	[CompilerGenerated]
	public void remove_ItemAdded(Action value) { }

	[CompilerGenerated]
	public void remove_ItemRemoved(Action value) { }

	[CompilerGenerated]
	public void remove_ItemsAdded(Action value) { }

	[CompilerGenerated]
	public void remove_ItemsRemoved(Action value) { }

	public override void set_Item(TK key, TV value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(TK key, out TV value) { }

}

