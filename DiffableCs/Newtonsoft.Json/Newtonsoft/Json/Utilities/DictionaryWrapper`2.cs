namespace Newtonsoft.Json.Utilities;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
internal class DictionaryWrapper`2 : IDictionary, ICollection, IEnumerable, IEnumerable, IWrappedDictionary, IDictionary, ICollection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func <>9__29_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal KeyValuePair <GetEnumerator>b__29_0(DictionaryEntry de) { }

	}

	[IsReadOnly]
	[Nullable(0)]
	private struct DictionaryEnumerator`2 : IDictionaryEnumerator, IEnumerator
	{
		[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 1})]
		private readonly IEnumerator _e; //Field offset: 0x0

		public override object Current
		{
			 get { } //Length: 1051
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 207
		}

		public override object Key
		{
			 get { } //Length: 117
		}

		public override object Value
		{
			 get { } //Length: 118
		}

		public DictionaryEnumerator`2(IEnumerator e) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	[Nullable(2)]
	private readonly IDictionary _dictionary; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private readonly IDictionary _genericDictionary; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private readonly IReadOnlyDictionary _readOnlyDictionary; //Field offset: 0x0
	[Nullable(2)]
	private object _syncRoot; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 230
	}

	internal IDictionary GenericDictionary
	{
		internal get { } //Length: 5
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 213
	}

	public override TValue Item
	{
		 get { } //Length: 871
		 set { } //Length: 682
	}

	public override ICollection Keys
	{
		 get { } //Length: 322
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 83
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 170
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 108
	}

	[Nullable(2)]
	private override object System.Collections.IDictionary.Item
	{
		private get { } //Length: 983
		private set { } //Length: 978
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 254
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 257
	}

	public override object UnderlyingDictionary
	{
		 get { } //Length: 48
	}

	public override ICollection Values
	{
		 get { } //Length: 328
	}

	public DictionaryWrapper`2(IDictionary dictionary) { }

	public DictionaryWrapper`2(IDictionary dictionary) { }

	public DictionaryWrapper`2(IReadOnlyDictionary dictionary) { }

	public override void Add(TKey key, TValue value) { }

	public override void Add(KeyValuePair item) { }

	public override void Clear() { }

	public override bool Contains(KeyValuePair item) { }

	public override bool ContainsKey(TKey key) { }

	public override void CopyTo(KeyValuePair[] array, int arrayIndex) { }

	public override int get_Count() { }

	internal IDictionary get_GenericDictionary() { }

	public override bool get_IsReadOnly() { }

	public override TValue get_Item(TKey key) { }

	public override ICollection get_Keys() { }

	public override object get_UnderlyingDictionary() { }

	public override ICollection get_Values() { }

	public override IEnumerator GetEnumerator() { }

	public override bool Remove(KeyValuePair item) { }

	public override bool Remove(TKey key) { }

	public override void Remove(object key) { }

	public override void set_Item(TKey key, TValue value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object key, object value) { }

	private override bool System.Collections.IDictionary.Contains(object key) { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override object System.Collections.IDictionary.get_Item(object key) { }

	private override ICollection System.Collections.IDictionary.get_Keys() { }

	private override ICollection System.Collections.IDictionary.get_Values() { }

	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(TKey key, out TValue value) { }

}

