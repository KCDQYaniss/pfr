namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JValue : JToken, IEquatable, IFormattable, IComparable, IComparable, IConvertible
{
	[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
	private class JValueDynamicProxy : DynamicProxy
	{

		public JValueDynamicProxy() { }

		public virtual bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, out object result) { }

		public virtual bool TryConvert(JValue instance, ConvertBinder binder, out object result) { }

	}

	private JTokenType _valueType; //Field offset: 0x30
	[Nullable(2)]
	private object _value; //Field offset: 0x38

	public virtual bool HasValues
	{
		 get { } //Length: 3
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 4
	}

	[Nullable(2)]
	public object Value
	{
		[NullableContext(2)]
		 get { } //Length: 5
		[NullableContext(2)]
		 set { } //Length: 294
	}

	[NullableContext(2)]
	public JValue(Uri value) { }

	[NullableContext(2)]
	public JValue(object value) { }

	public JValue(TimeSpan value) { }

	public JValue(Guid value) { }

	[NullableContext(2)]
	public JValue(string value) { }

	public JValue(DateTimeOffset value) { }

	public JValue(DateTime value) { }

	public JValue(float value) { }

	public JValue(bool value) { }

	[CLSCompliant(False)]
	public JValue(ulong value) { }

	public JValue(char value) { }

	public JValue(decimal value) { }

	public JValue(long value) { }

	public JValue(JValue other) { }

	[NullableContext(2)]
	internal JValue(object value, JTokenType type) { }

	public JValue(double value) { }

	internal virtual JToken CloneToken() { }

	[NullableContext(2)]
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	private static int CompareBigInteger(BigInteger i1, object i2) { }

	private static int CompareFloat(object objA, object objB) { }

	public override int CompareTo(JValue obj) { }

	public static JValue CreateComment(string value) { }

	public static JValue CreateNull() { }

	public static JValue CreateString(string value) { }

	public static JValue CreateUndefined() { }

	internal virtual bool DeepEquals(JToken node) { }

	public virtual bool Equals(object obj) { }

	[NullableContext(2)]
	public override bool Equals(JValue other) { }

	public virtual bool get_HasValues() { }

	public virtual JTokenType get_Type() { }

	[NullableContext(2)]
	public object get_Value() { }

	internal virtual int GetDeepHashCode() { }

	public virtual int GetHashCode() { }

	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	private static JTokenType GetStringValueType(Nullable current) { }

	[NullableContext(2)]
	private static JTokenType GetValueType(Nullable current, object value) { }

	[NullableContext(2)]
	private static bool Operation(ExpressionType operation, object objA, object objB, out object result) { }

	[NullableContext(2)]
	public void set_Value(object value) { }

	private override int System.IComparable.CompareTo(object obj) { }

	private override TypeCode System.IConvertible.GetTypeCode() { }

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

	private override object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	public override string ToString(IFormatProvider formatProvider) { }

	public string ToString(string format) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	private static bool ValuesEquals(JValue v1, JValue v2) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

