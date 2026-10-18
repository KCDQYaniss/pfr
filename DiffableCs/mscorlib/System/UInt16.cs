namespace System;

[CLSCompliant(False)]
[IsReadOnly]
public struct ushort : IComparable, IConvertible, IFormattable, IComparable, IEquatable, ISpanFormattable
{
	public const ushort MaxValue = 65535; //Field offset: 0x0
	public const ushort MinValue = 0; //Field offset: 0x0
	private readonly ushort m_value; //Field offset: 0x0

	public override int CompareTo(object value) { }

	public override int CompareTo(ushort value) { }

	public virtual bool Equals(object obj) { }

	[NonVersionable]
	public override bool Equals(ushort obj) { }

	public virtual int GetHashCode() { }

	public override TypeCode GetTypeCode() { }

	private static ushort Parse(ReadOnlySpan s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliant(False)]
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliant(False)]
	public static ushort Parse(string s, IFormatProvider provider) { }

	[CLSCompliant(False)]
	public static ushort Parse(string s, NumberStyles style) { }

	[CLSCompliant(False)]
	public static ushort Parse(string s) { }

	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	public override string ToString(string format, IFormatProvider provider) { }

	public override string ToString(IFormatProvider provider) { }

	public virtual string ToString() { }

	public override bool TryFormat(Span destination, out int charsWritten, ReadOnlySpan format = null, IFormatProvider provider = null) { }

	[CLSCompliant(False)]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) { }

	private static bool TryParse(ReadOnlySpan s, NumberStyles style, NumberFormatInfo info, out ushort result) { }

}

