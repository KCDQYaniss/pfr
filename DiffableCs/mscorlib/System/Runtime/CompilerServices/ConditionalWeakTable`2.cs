namespace System.Runtime.CompilerServices;

public sealed class ConditionalWeakTable`2 : IEnumerable, IEnumerable
{
	internal sealed class CreateValueCallback : MulticastDelegate
	{

		public CreateValueCallback(object object, IntPtr method) { }

		public override TValue Invoke(TKey key) { }

	}

	private sealed class Enumerator : IEnumerator, IDisposable, IEnumerator
	{
		private ConditionalWeakTable _table; //Field offset: 0x0
		private int _currentIndex; //Field offset: 0x0
		private KeyValuePair _current; //Field offset: 0x0

		public override KeyValuePair Current
		{
			 get { } //Length: 32
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 56
		}

		public Enumerator(ConditionalWeakTable table) { }

		public override void Dispose() { }

		protected virtual void Finalize() { }

		public override KeyValuePair get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private const int INITIAL_SIZE = 13; //Field offset: 0x0
	private const float LOAD_FACTOR = 0.7; //Field offset: 0x0
	private const float COMPACT_FACTOR = 0.5; //Field offset: 0x0
	private const float EXPAND_FACTOR = 1.1; //Field offset: 0x0
	private Ephemeron[] data; //Field offset: 0x0
	private object _lock; //Field offset: 0x0
	private int size; //Field offset: 0x0

	public ConditionalWeakTable`2() { }

	public void Add(TKey key, TValue value) { }

	protected virtual void Finalize() { }

	public TValue GetValue(TKey key, CreateValueCallback createValueCallback) { }

	private void RecomputeSize() { }

	private void Rehash() { }

	private void RehashWithoutResize() { }

	public bool Remove(TKey key) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetValue(TKey key, out TValue value) { }

}

