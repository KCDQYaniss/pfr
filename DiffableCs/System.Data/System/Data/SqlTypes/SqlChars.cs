namespace System.Data.SqlTypes;

[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
public sealed class SqlChars : INullable, IXmlSerializable, ISerializable
{
	internal char[] _rgchBuf; //Field offset: 0x10
	private long _lCurLen; //Field offset: 0x18
	internal SqlStreamChars _stream; //Field offset: 0x20
	private SqlBytesCharsState _state; //Field offset: 0x28
	private char[] _rgchWorkBuf; //Field offset: 0x30

	public char[] Buffer
	{
		 get { } //Length: 42
	}

	public override bool IsNull
	{
		 get { } //Length: 8
	}

	public long Length
	{
		 get { } //Length: 129
	}

	public static SqlChars Null
	{
		 get { } //Length: 76
	}

	public char[] Value
	{
		 get { } //Length: 575
	}

	public SqlChars() { }

	public SqlChars(char[] buffer) { }

	public SqlChars(SqlString value) { }

	private void CopyStreamToBuffer() { }

	internal bool FStream() { }

	public char[] get_Buffer() { }

	public override bool get_IsNull() { }

	public long get_Length() { }

	public static SqlChars get_Null() { }

	public char[] get_Value() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private void SetBuffer(char[] buffer) { }

	public void SetNull() { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

}

