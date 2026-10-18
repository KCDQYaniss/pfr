namespace System.Text.Json.Serialization;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DebuggerTypeProxy(typeof(ConfigurationListDebugView))]
[DefaultMember("Item")]
internal abstract class ConfigurationList`1 : IList, ICollection, IEnumerable, IEnumerable
{
	private sealed class ConfigurationListDebugView
	{

	}

	protected readonly List _list; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 26
	}

	public abstract bool IsReadOnly
	{
		 get { } //Length: 0
	}

	public override TItem Item
	{
		 get { } //Length: 78
		 set { } //Length: 248
	}

	public ConfigurationList`1(IEnumerable source = null) { }

	public override void Add(TItem item) { }

	public override void Clear() { }

	public override bool Contains(TItem item) { }

	public override void CopyTo(TItem[] array, int arrayIndex) { }

	public override int get_Count() { }

	public abstract bool get_IsReadOnly() { }

	public override TItem get_Item(int index) { }

	public Enumerator GetEnumerator() { }

	public override int IndexOf(TItem item) { }

	public override void Insert(int index, TItem item) { }

	protected abstract void OnCollectionModifying() { }

	public override bool Remove(TItem item) { }

	public override void RemoveAt(int index) { }

	public override void set_Item(int index, TItem value) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<TItem>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	protected override void ValidateAddedValue(TItem item) { }

}

