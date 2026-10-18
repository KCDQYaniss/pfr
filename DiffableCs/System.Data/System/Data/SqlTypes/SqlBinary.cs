namespace System.Data.SqlTypes;

[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlBinary : INullable, IComparable, IXmlSerializable
{
	public static readonly SqlBinary Null; //Field offset: 0x0
	private byte[] _value; //Field offset: 0x0

	public override bool IsNull
	{
		 get { } //Length: 8
	}

	public byte[] Value
	{
		 get { } //Length: 210
	}

	private static SqlBinary() { }

	private SqlBinary(bool fNull) { }

	public SqlBinary(byte[] value) { }

	public override int CompareTo(object value) { }

	public int CompareTo(SqlBinary value) { }

	public virtual bool Equals(object value) { }

	public override bool get_IsNull() { }

	public byte[] get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	internal static int HashByteArray(byte[] rgbValue, int length) { }

	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	public static SqlBinary op_Implicit(byte[] x) { }

	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public virtual string ToString() { }

}

