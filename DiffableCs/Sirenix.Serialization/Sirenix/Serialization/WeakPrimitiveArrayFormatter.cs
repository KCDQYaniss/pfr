namespace Sirenix.Serialization;

public sealed class WeakPrimitiveArrayFormatter : WeakMinimalBaseFormatter
{
	internal enum PrimitiveArrayType
	{
		PrimitiveArray_char = 0,
		PrimitiveArray_sbyte = 1,
		PrimitiveArray_short = 2,
		PrimitiveArray_int = 3,
		PrimitiveArray_long = 4,
		PrimitiveArray_byte = 5,
		PrimitiveArray_ushort = 6,
		PrimitiveArray_uint = 7,
		PrimitiveArray_ulong = 8,
		PrimitiveArray_decimal = 9,
		PrimitiveArray_bool = 10,
		PrimitiveArray_float = 11,
		PrimitiveArray_double = 12,
		PrimitiveArray_Guid = 13,
	}

	private static readonly Dictionary PrimitiveTypes; //Field offset: 0x0
	private readonly Type ElementType; //Field offset: 0x20
	private readonly PrimitiveArrayType PrimitiveType; //Field offset: 0x28

	private static WeakPrimitiveArrayFormatter() { }

	public WeakPrimitiveArrayFormatter(Type arrayType, Type elementType) { }

	protected virtual object GetUninitializedObject() { }

	protected virtual void Read(ref object value, IDataReader reader) { }

	protected virtual void Write(ref object value, IDataWriter writer) { }

}

