namespace System.Collections.Generic;

[DefaultMember("Item")]
internal class LowLevelDictionary`2
{
	private sealed class DefaultComparer`1 : IEqualityComparer
	{

		public DefaultComparer`1() { }

		public override bool Equals(T x, T y) { }

		public override int GetHashCode(T obj) { }

	}

	private sealed class Entry
	{
		public TKey _key; //Field offset: 0x0
		public TValue _value; //Field offset: 0x0
		public Entry _next; //Field offset: 0x0

		public Entry() { }

	}

	private Entry[] _buckets; //Field offset: 0x0
	private int _numEntries; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private IEqualityComparer _comparer; //Field offset: 0x0

	public TKey Item
	{
		 set { } //Length: 414
	}

	public LowLevelDictionary`2() { }

	public LowLevelDictionary`2(int capacity, IEqualityComparer comparer) { }

	public void Clear(int capacity = 17) { }

	private void ExpandBuckets() { }

	private Entry Find(TKey key) { }

	private int GetBucket(TKey key, int numBuckets = 0) { }

	public bool Remove(TKey key) { }

	public void set_Item(TKey key, TValue value) { }

	private Entry UncheckedAdd(TKey key, TValue value) { }

}

