namespace System.Buffers;

[IsReadOnly]
public struct StandardFormat : IEquatable
{
	private readonly byte _format; //Field offset: 0x0
	private readonly byte _precision; //Field offset: 0x1

	public bool HasPrecision
	{
		 get { } //Length: 8
	}

	public bool IsDefault
	{
		 get { } //Length: 16
	}

	public byte Precision
	{
		 get { } //Length: 5
	}

	public char Symbol
	{
		 get { } //Length: 4
	}

	public StandardFormat(char symbol, byte precision = 255) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(StandardFormat other) { }

	internal int Format(Span destination) { }

	public bool get_HasPrecision() { }

	public bool get_IsDefault() { }

	public byte get_Precision() { }

	public char get_Symbol() { }

	public virtual int GetHashCode() { }

	public static StandardFormat op_Implicit(char symbol) { }

	public static StandardFormat Parse(ReadOnlySpan format) { }

	public static StandardFormat Parse(string format) { }

	private static bool ParseHelper(ReadOnlySpan format, out StandardFormat standardFormat, bool throws = false) { }

	public virtual string ToString() { }

}

