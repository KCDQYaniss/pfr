namespace System.Collections.Specialized;

[DefaultMember("Item")]
public class ListDictionary : IDictionary, ICollection, IEnumerable
{
	internal class DictionaryNode
	{
		public object key; //Field offset: 0x10
		public object value; //Field offset: 0x18
		public DictionaryNode next; //Field offset: 0x20

		public DictionaryNode() { }

	}

	private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private ListDictionary _list; //Field offset: 0x10
		private DictionaryNode _current; //Field offset: 0x18
		private int _version; //Field offset: 0x20
		private bool _start; //Field offset: 0x24

		public override object Current
		{
			 get { } //Length: 188
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 123
		}

		public override object Key
		{
			 get { } //Length: 106
		}

		public override object Value
		{
			 get { } //Length: 106
		}

		public NodeEnumerator(ListDictionary list) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private class NodeKeyValueCollection : ICollection, IEnumerable
	{
		private class NodeKeyValueEnumerator : IEnumerator
		{
			private ListDictionary _list; //Field offset: 0x10
			private DictionaryNode _current; //Field offset: 0x18
			private int _version; //Field offset: 0x20
			private bool _isKeys; //Field offset: 0x24
			private bool _start; //Field offset: 0x25

			public override object Current
			{
				 get { } //Length: 121
			}

			public NodeKeyValueEnumerator(ListDictionary list, bool isKeys) { }

			public override object get_Current() { }

			public override bool MoveNext() { }

			public override void Reset() { }

		}

		private ListDictionary _list; //Field offset: 0x10
		private bool _isKeys; //Field offset: 0x18

		private override int System.Collections.ICollection.Count
		{
			private get { } //Length: 53
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 181
		}

		public NodeKeyValueCollection(ListDictionary list, bool isKeys) { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override int System.Collections.ICollection.get_Count() { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private DictionaryNode head; //Field offset: 0x10
	private int version; //Field offset: 0x18
	private int count; //Field offset: 0x1C
	private readonly IComparer comparer; //Field offset: 0x20
	private object _syncRoot; //Field offset: 0x28

	public override int Count
	{
		 get { } //Length: 4
	}

	public override bool IsFixedSize
	{
		 get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public override object Item
	{
		 get { } //Length: 309
		 set { } //Length: 424
	}

	public override ICollection Keys
	{
		 get { } //Length: 152
	}

	public override object SyncRoot
	{
		 get { } //Length: 170
	}

	public override ICollection Values
	{
		 get { } //Length: 152
	}

	public ListDictionary() { }

	public ListDictionary(IComparer comparer) { }

	public override void Add(object key, object value) { }

	public override void Clear() { }

	public override bool Contains(object key) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(object key) { }

	public override ICollection get_Keys() { }

	public override object get_SyncRoot() { }

	public override ICollection get_Values() { }

	public override IDictionaryEnumerator GetEnumerator() { }

	public override void Remove(object key) { }

	public override void set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

