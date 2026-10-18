namespace Coffee.UISoftMaskInternal;

internal class ObjectRepository`1
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__5_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__5_0(T x) { }

	}

	private class Entry
	{
		public Hash128 hash; //Field offset: 0x0
		public int reference; //Field offset: 0x0
		public T storedObject; //Field offset: 0x0

		public Entry() { }

		public void Release(Action onRelease) { }

		public virtual string ToString() { }

	}

	private readonly Dictionary _cache; //Field offset: 0x0
	private readonly Dictionary _objectKey; //Field offset: 0x0
	private readonly string _name; //Field offset: 0x0
	private readonly Action _onRelease; //Field offset: 0x0
	private readonly Stack _pool; //Field offset: 0x0

	public int count
	{
		 get { } //Length: 29
	}

	public ObjectRepository`1(Action onRelease = null) { }

	private void Add(Hash128 hash, ref T obj, T newObject) { }

	public void Clear() { }

	public void Get(Hash128 hash, ref T obj, Func onCreate) { }

	public void Get(Hash128 hash, ref T obj, Func onCreate, TS source) { }

	public int get_count() { }

	private bool GetFromCache(Hash128 hash, ref T obj) { }

	public void Release(ref T obj) { }

	private void Remove(Entry entry) { }

	public bool Valid(Hash128 hash, T obj) { }

}

