namespace Koenigz.PerfectCulling;

[DefaultMember("Item")]
public class IndexBuffer`1 : IEnumerable, IEnumerable
{
	private sealed class BufferIterator : IEnumerator, IEnumerator, IDisposable
	{
		private T[] buffer; //Field offset: 0x0
		private int validNum; //Field offset: 0x0
		private int position; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			private get { } //Length: 42
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 76
		}

		public BufferIterator(T[] buffer, int validNum) { }

		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override bool System.Collections.IEnumerator.MoveNext() { }

		private override void System.Collections.IEnumerator.Reset() { }

		private override void System.IDisposable.Dispose() { }

	}

	public T[] buffer; //Field offset: 0x0
	public int numIndices; //Field offset: 0x0

	public T[] BufferCopy
	{
		 get { } //Length: 370
	}

	public T Item
	{
		 get { } //Length: 43
		 set { } //Length: 43
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public IndexBuffer`1(int cap) { }

	public T[] get_BufferCopy() { }

	public T get_Item(int i) { }

	public int get_Length() { }

	public override IEnumerator GetEnumerator() { }

	public void Reset() { }

	public void set_Item(int i, T value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

