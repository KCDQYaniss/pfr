namespace Sirenix.Utilities;

[Extension]
public static class GarbageFreeIterators
{
	internal struct DictionaryIterator`2 : IDisposable
	{
		private Dictionary dictionary; //Field offset: 0x0
		private Enumerator enumerator; //Field offset: 0x0
		private bool isNull; //Field offset: 0x0

		public KeyValuePair Current
		{
			 get { } //Length: 55
		}

		public DictionaryIterator`2(Dictionary dictionary) { }

		public override void Dispose() { }

		public KeyValuePair get_Current() { }

		public DictionaryIterator GetEnumerator() { }

		public bool MoveNext() { }

	}

	internal struct DictionaryValueIterator`2 : IDisposable
	{
		private Dictionary dictionary; //Field offset: 0x0
		private Enumerator enumerator; //Field offset: 0x0
		private bool isNull; //Field offset: 0x0

		public T2 Current
		{
			 get { } //Length: 525
		}

		public DictionaryValueIterator`2(Dictionary dictionary) { }

		public override void Dispose() { }

		public T2 get_Current() { }

		public DictionaryValueIterator GetEnumerator() { }

		public bool MoveNext() { }

	}

	internal struct HashsetIterator`1 : IDisposable
	{
		private bool isNull; //Field offset: 0x0
		private HashSet hashset; //Field offset: 0x0
		private Enumerator enumerator; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 297
		}

		public HashsetIterator`1(HashSet hashset) { }

		public override void Dispose() { }

		public T get_Current() { }

		public HashsetIterator GetEnumerator() { }

		public bool MoveNext() { }

	}

	internal struct ListIterator`1 : IDisposable
	{
		private bool isNull; //Field offset: 0x0
		private List list; //Field offset: 0x0
		private Enumerator enumerator; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 297
		}

		public ListIterator`1(List list) { }

		public override void Dispose() { }

		public T get_Current() { }

		public ListIterator GetEnumerator() { }

		public bool MoveNext() { }

	}


	[Extension]
	public static ListIterator GFIterator(List list) { }

	[Extension]
	public static DictionaryIterator GFIterator(Dictionary dictionary) { }

	[Extension]
	public static HashsetIterator GFIterator(HashSet hashset) { }

	[Extension]
	public static DictionaryValueIterator GFValueIterator(Dictionary dictionary) { }

}

