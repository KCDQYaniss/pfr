namespace System.Xml;

internal class XmlTextWriterBase64Encoder : Base64Encoder
{
	private XmlTextEncoder xmlTextEncoder; //Field offset: 0x28

	internal XmlTextWriterBase64Encoder(XmlTextEncoder xmlTextEncoder) { }

	internal virtual void WriteChars(char[] chars, int index, int count) { }

}

