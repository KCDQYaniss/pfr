namespace Microsoft.CSharp.RuntimeBinder.Syntax;

internal sealed class NameTable
{
	private sealed class Entry
	{
		public readonly Name Name; //Field offset: 0x10
		public readonly int HashCode; //Field offset: 0x18
		public Entry Next; //Field offset: 0x20

		public Entry(Name name, int hashCode, Entry next) { }

	}

	private Entry[] _entries; //Field offset: 0x10
	private int _count; //Field offset: 0x18
	private int _mask; //Field offset: 0x1C

	internal NameTable() { }

	public Name Add(string key) { }

	public Name Add(string key, int length) { }

	internal void Add(Name name) { }

	private Name AddEntry(Name name, int hashCode) { }

	private static int ComputeHashCode(string key) { }

	private static int ComputeHashCode(string key, int length) { }

	private static bool Equals(string candidate, string key, int length) { }

	private void Grow() { }

}

