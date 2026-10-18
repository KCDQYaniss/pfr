namespace WebSocketSharp;

internal abstract class HttpBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public List buff; //Field offset: 0x10
		public int cnt; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal void <readHeadersFrom>b__0(int i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0`1
	{
		public bool timeout; //Field offset: 0x0
		public Stream stream; //Field offset: 0x0

		public <>c__DisplayClass21_0`1() { }

		internal void <Read>b__0(object state) { }

	}

	private static readonly int _headersMaxLength; //Field offset: 0x0
	protected static readonly string CrLf; //Field offset: 0x8
	protected static readonly string CrLfHt; //Field offset: 0x10
	protected static readonly string CrLfSp; //Field offset: 0x18
	private string _entityBody; //Field offset: 0x10
	private byte[] _entityBodyData; //Field offset: 0x18
	private NameValueCollection _headers; //Field offset: 0x20
	private Version _protocolVersion; //Field offset: 0x28

	public string EntityBody
	{
		 get { } //Length: 352
	}

	internal byte[] EntityBodyData
	{
		internal get { } //Length: 7
	}

	public NameValueCollection Headers
	{
		 get { } //Length: 7
	}

	public Version ProtocolVersion
	{
		 get { } //Length: 7
	}

	private static HttpBase() { }

	protected HttpBase(Version protocolVersion, NameValueCollection headers) { }

	public string get_EntityBody() { }

	internal byte[] get_EntityBodyData() { }

	public NameValueCollection get_Headers() { }

	public Version get_ProtocolVersion() { }

	private string getEntityBody() { }

	protected static T Read(Stream stream, Func parser, int millisecondsTimeout) { }

	private static byte[] readEntityBodyFrom(Stream stream, string length) { }

	private static string[] readHeadersFrom(Stream stream) { }

	public byte[] ToByteArray() { }

}

