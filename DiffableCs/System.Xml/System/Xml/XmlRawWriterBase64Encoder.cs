namespace System.Xml;

internal class XmlRawWriterBase64Encoder : Base64Encoder
{
	private XmlRawWriter rawWriter; //Field offset: 0x28

	internal XmlRawWriterBase64Encoder(XmlRawWriter rawWriter) { }

	internal virtual void WriteChars(char[] chars, int index, int count) { }

}

