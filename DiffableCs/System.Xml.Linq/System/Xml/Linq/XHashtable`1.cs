namespace System.Xml.Linq;

internal sealed class XHashtable`1
{
	internal sealed class ExtractKeyDelegate : MulticastDelegate
	{

		public ExtractKeyDelegate(object object, IntPtr method) { }

		public override string Invoke(TValue value) { }

	}

	private sealed class XHashtableState
	{
		private struct Entry
		{
			public TValue Value; //Field offset: 0x0
			public int HashCode; //Field offset: 0x0
			public int Next; //Field offset: 0x0

		}

		private int[] _buckets; //Field offset: 0x0
		private Entry[] _entries; //Field offset: 0x0
		private int _numEntries; //Field offset: 0x0
		private ExtractKeyDelegate _extractKey; //Field offset: 0x0

		public XHashtableState(ExtractKeyDelegate extractKey, int capacity) { }

		private static int ComputeHashCode(string key, int index, int count) { }

		private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }

		public XHashtableState Resize() { }

		public bool TryAdd(TValue value, out TValue newValue) { }

		public bool TryGetValue(string key, int index, int count, out TValue value) { }

	}

	private XHashtableState _state; //Field offset: 0x0

	public XHashtable`1(ExtractKeyDelegate extractKey, int capacity) { }

	public TValue Add(TValue value) { }

	public bool TryGetValue(string key, int index, int count, out TValue value) { }

}

