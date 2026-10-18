namespace System.Text;

[IsReadOnly]
internal struct Rune : IEquatable
{
	private readonly uint _value; //Field offset: 0x0

	public bool IsAscii
	{
		 get { } //Length: 7
	}

	public bool IsBmp
	{
		 get { } //Length: 10
	}

	public static Rune ReplacementChar
	{
		 get { } //Length: 6
	}

	public int Utf16SequenceLength
	{
		 get { } //Length: 11
	}

	public int Value
	{
		 get { } //Length: 3
	}

	public Rune(uint value) { }

	public Rune(int value) { }

	private Rune(uint scalarValue, bool _) { }

	public static OperationStatus DecodeFromUtf16(ReadOnlySpan source, out Rune result, out int charsConsumed) { }

	public static OperationStatus DecodeFromUtf8(ReadOnlySpan source, out Rune result, out int bytesConsumed) { }

	public override bool Equals(Rune other) { }

	public virtual bool Equals(object obj) { }

	public bool get_IsAscii() { }

	public bool get_IsBmp() { }

	public static Rune get_ReplacementChar() { }

	public int get_Utf16SequenceLength() { }

	public int get_Value() { }

	public virtual int GetHashCode() { }

	public static bool IsControl(Rune value) { }

	public static bool op_Equality(Rune left, Rune right) { }

	public static bool TryCreate(char ch, out Rune result) { }

	public static bool TryCreate(char highSurrogate, char lowSurrogate, out Rune result) { }

	public bool TryEncodeToUtf16(Span destination, out int charsWritten) { }

	public bool TryEncodeToUtf8(Span destination, out int bytesWritten) { }

	internal static Rune UnsafeCreate(uint scalarValue) { }

}

