namespace System.Xml;

internal class XmlUtf8RawTextWriter : XmlRawWriter
{
	private readonly bool useAsync; //Field offset: 0x28
	protected byte[] bufBytes; //Field offset: 0x30
	protected Stream stream; //Field offset: 0x38
	protected Encoding encoding; //Field offset: 0x40
	protected XmlCharType xmlCharType; //Field offset: 0x48
	protected int bufPos; //Field offset: 0x50
	protected int textPos; //Field offset: 0x54
	protected int contentPos; //Field offset: 0x58
	protected int cdataPos; //Field offset: 0x5C
	protected int attrEndPos; //Field offset: 0x60
	protected int bufLen; //Field offset: 0x64
	protected bool writeToNull; //Field offset: 0x68
	protected bool hadDoubleBracket; //Field offset: 0x69
	protected bool inAttributeValue; //Field offset: 0x6A
	protected NewLineHandling newLineHandling; //Field offset: 0x6C
	protected bool closeOutput; //Field offset: 0x70
	protected bool omitXmlDeclaration; //Field offset: 0x71
	protected string newLineChars; //Field offset: 0x78
	protected bool checkCharacters; //Field offset: 0x80
	protected XmlStandalone standalone; //Field offset: 0x84
	protected XmlOutputMethod outputMethod; //Field offset: 0x88
	protected bool autoXmlDeclaration; //Field offset: 0x8C
	protected bool mergeCDataSections; //Field offset: 0x8D

	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		internal get { } //Length: 3
	}

	protected XmlUtf8RawTextWriter(XmlWriterSettings settings) { }

	public XmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings) { }

	protected static byte* AmpEntity(byte* pDst) { }

	protected static byte* CarriageReturnEntity(byte* pDst) { }

	private static byte* CharEntity(byte* pDst, char ch) { }

	internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	public virtual void Close() { }

	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

	private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

	public virtual void Flush() { }

	protected override void FlushBuffer() { }

	private void FlushEncoder() { }

	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	protected static byte* GtEntity(byte* pDst) { }

	private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

	private static bool IsSurrogateByte(byte b) { }

	protected static byte* LineFeedEntity(byte* pDst) { }

	protected static byte* LtEntity(byte* pDst) { }

	protected static byte* QuoteEntity(byte* pDst) { }

	protected static byte* RawEndCData(byte* pDst) { }

	protected static byte* RawStartCData(byte* pDst) { }

	protected void RawText(string s) { }

	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	internal virtual void StartElementContent() { }

	protected static byte* TabEntity(byte* pDst) { }

	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	public virtual void WriteCData(string text) { }

	protected void WriteCDataSection(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	protected void WriteCommentOrPi(string text, int stopChar) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	public virtual void WriteEndAttribute() { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteEndNamespaceDeclaration() { }

	public virtual void WriteEntityRef(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	protected byte* WriteNewLine(byte* pDst) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(char[] buffer, int index, int count) { }

	public virtual void WriteRaw(string data) { }

	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteWhitespace(string ws) { }

	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

