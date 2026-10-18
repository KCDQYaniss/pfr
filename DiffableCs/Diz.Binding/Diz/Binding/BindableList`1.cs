namespace Diz.Binding;

[DefaultMember("Item")]
public class BindableList`1 : IBindableListWithEvent, IBindableList, IEnumerable, IEnumerable, IList, ICollection
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
	[CompilerGenerated]
	private Action ItemUpdated; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsExceptionSafe>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly BindableEvent <ItemsChanged>k__BackingField; //Field offset: 0x0
	public readonly BindableState CountChanged; //Field offset: 0x0
	protected List List; //Field offset: 0x0
	private readonly Comparison _comparer; //Field offset: 0x0
	private readonly bool _sorted; //Field offset: 0x0

	public override event Action AllItemsRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action ItemAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action ItemRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action ItemsAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action ItemsRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action ItemUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override int Count
	{
		 get { } //Length: 26
	}

	public bool IsExceptionSafe
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override T Item
	{
		 get { } //Length: 92
		 set { } //Length: 308
	}

	public T Item
	{
		 get { } //Length: 222
		 set { } //Length: 403
	}

	public override BindableEvent ItemsChanged
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BindableList`1() { }

	protected BindableList`1(Comparison comparer) { }

	public BindableList`1(IEnumerable items) { }

	[CompilerGenerated]
	private bool <AddRange>b__49_0(T x) { }

	public override void Add(T newItem) { }

	[CompilerGenerated]
	public override void add_AllItemsRemoved(Action value) { }

	[CompilerGenerated]
	public override void add_ItemAdded(Action value) { }

	[CompilerGenerated]
	public override void add_ItemRemoved(Action value) { }

	[CompilerGenerated]
	public override void add_ItemsAdded(Action value) { }

	[CompilerGenerated]
	public override void add_ItemsRemoved(Action value) { }

	[CompilerGenerated]
	public void add_ItemUpdated(Action value) { }

	public void AddRange(IEnumerable list) { }

	private void AllItemsRemovedInvoke() { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public override int get_Count() { }

	[CompilerGenerated]
	public bool get_IsExceptionSafe() { }

	public override bool get_IsReadOnly() { }

	public override T get_Item(int index) { }

	public T get_Item(T item) { }

	[CompilerGenerated]
	public override BindableEvent get_ItemsChanged() { }

	public override IEnumerator GetEnumerator() { }

	public override int IndexOf(T item) { }

	public override void Insert(int index, T item) { }

	private void ItemAddedInvoke(T obj) { }

	private void ItemRemovedInvoke(T obj) { }

	private void ItemsAddedInvoke(IEnumerable obj) { }

	private void ItemsRemovedInvoke(IEnumerable obj) { }

	private void ItemUpdatedInvoke(T obj) { }

	public override bool Remove(T existingItem) { }

	[CompilerGenerated]
	public override void remove_AllItemsRemoved(Action value) { }

	[CompilerGenerated]
	public override void remove_ItemAdded(Action value) { }

	[CompilerGenerated]
	public override void remove_ItemRemoved(Action value) { }

	[CompilerGenerated]
	public override void remove_ItemsAdded(Action value) { }

	[CompilerGenerated]
	public override void remove_ItemsRemoved(Action value) { }

	[CompilerGenerated]
	public void remove_ItemUpdated(Action value) { }

	public override void RemoveAt(int index) { }

	[CompilerGenerated]
	public void set_IsExceptionSafe(bool value) { }

	public void set_Item(T item, T value) { }

	public override void set_Item(int index, T value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	protected void UpdateItem(T item) { }

}

