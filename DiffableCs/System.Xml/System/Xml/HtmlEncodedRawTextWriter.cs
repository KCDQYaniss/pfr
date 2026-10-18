namespace System.Xml;

internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter
{
	protected static TernaryTreeReadOnly elementPropertySearch; //Field offset: 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; //Field offset: 0x8
	protected ByteStack elementScope; //Field offset: 0xC0
	protected ElementProperties currentElementProperties; //Field offset: 0xC8
	private AttributeProperties currentAttributeProperties; //Field offset: 0xCC
	private bool endsWithAmpersand; //Field offset: 0xD0
	private byte[] uriEscapingBuffer; //Field offset: 0xD8
	private string mediaType; //Field offset: 0xE0
	private bool doNotEscapeUriAttributes; //Field offset: 0xE8

	public HtmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) { }

	public HtmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) { }

	private void Init(XmlWriterSettings settings) { }

	private void OutputRestAmps() { }

	internal virtual void StartElementContent() { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(char[] buffer, int index, int count) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	public virtual void WriteEntityRef(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	protected void WriteMetaElement() { }

	public virtual void WriteProcessingInstruction(string target, string text) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

