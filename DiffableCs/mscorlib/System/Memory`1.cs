namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView`1))]
[IsReadOnly]
public struct Memory`1 : IEquatable
{
	private readonly object _object; //Field offset: 0x0
	private readonly int _index; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public static Memory Empty
	{
		 get { } //Length: 10
	}

	public int Length
	{
		 get { } //Length: 8
	}

	public Span Span
	{
		 get { } //Length: 937
	}

	public Memory`1(T[] array) { }

	internal Memory`1(T[] array, int start) { }

	public Memory`1(T[] array, int start, int length) { }

	internal Memory`1(object obj, int start, int length) { }

	private static int CombineHashCodes(int left, int right) { }

	private static int CombineHashCodes(int h1, int h2, int h3) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(Memory other) { }

	public static Memory get_Empty() { }

	public int get_Length() { }

	public Span get_Span() { }

	public virtual int GetHashCode() { }

	public static ReadOnlyMemory op_Implicit(Memory memory) { }

	public static Memory op_Implicit(T[] array) { }

	public static Memory op_Implicit(ArraySegment segment) { }

	public MemoryHandle Pin() { }

	public Memory Slice(int start, int length) { }

	public T[] ToArray() { }

	public virtual string ToString() { }

}

