namespace System.Net;

public class WebClient : Component
{
	private sealed class ProgressData
	{
		internal long BytesSent; //Field offset: 0x10
		internal long TotalBytesToSend; //Field offset: 0x18
		internal long BytesReceived; //Field offset: 0x20
		internal long TotalBytesToReceive; //Field offset: 0x28
		internal bool HasUploadPhase; //Field offset: 0x30

		internal void Reset() { }

	}

	private static readonly char[] s_parseContentTypeSeparators; //Field offset: 0x0
	private static readonly Encoding[] s_knownEncodings; //Field offset: 0x8
	private Uri _baseAddress; //Field offset: 0x28
	private ICredentials _credentials; //Field offset: 0x30
	private WebHeaderCollection _headers; //Field offset: 0x38
	private NameValueCollection _requestParameters; //Field offset: 0x40
	private WebResponse _webResponse; //Field offset: 0x48
	private WebRequest _webRequest; //Field offset: 0x50
	private Encoding _encoding; //Field offset: 0x58
	private string _method; //Field offset: 0x60
	private long _contentLength; //Field offset: 0x68
	private bool _canceled; //Field offset: 0x70
	private ProgressData _progress; //Field offset: 0x78
	private IWebProxy _proxy; //Field offset: 0x80
	private bool _proxySet; //Field offset: 0x88
	private int _callNesting; //Field offset: 0x8C
	[CompilerGenerated]
	private RequestCachePolicy <CachePolicy>k__BackingField; //Field offset: 0x90

	public RequestCachePolicy CachePolicy
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ICredentials Credentials
	{
		 get { } //Length: 76
	}

	public Encoding Encoding
	{
		 get { } //Length: 5
		 set { } //Length: 253
	}

	public WebHeaderCollection Headers
	{
		 get { } //Length: 175
	}

	private static WebClient() { }

	public WebClient() { }

	private static void AbortRequest(WebRequest request) { }

	private static bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray) { }

	private void CopyHeadersTo(WebRequest request) { }

	private byte[] DownloadBits(WebRequest request, Stream writeStream) { }

	public byte[] DownloadData(string address) { }

	public byte[] DownloadData(Uri address) { }

	private byte[] DownloadDataInternal(Uri address, out WebRequest request) { }

	public string DownloadString(Uri address) { }

	public string DownloadString(string address) { }

	private void EndOperation() { }

	[CompilerGenerated]
	public RequestCachePolicy get_CachePolicy() { }

	public ICredentials get_Credentials() { }

	public Encoding get_Encoding() { }

	public WebHeaderCollection get_Headers() { }

	private string GetStringUsingEncoding(WebRequest request, byte[] data) { }

	private Uri GetUri(string address) { }

	private Uri GetUri(Uri address) { }

	protected override WebRequest GetWebRequest(Uri address) { }

	protected override WebResponse GetWebResponse(WebRequest request) { }

	private string MapToDefaultMethod(Uri address) { }

	public void set_Encoding(Encoding value) { }

	private void StartOperation() { }

	private static void ThrowIfNull(object argument, string parameterName) { }

	private byte[] UploadBits(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer) { }

	public byte[] UploadData(string address, string method, byte[] data) { }

	public byte[] UploadData(Uri address, string method, byte[] data) { }

	private byte[] UploadDataInternal(Uri address, string method, byte[] data, out WebRequest request) { }

	public string UploadString(Uri address, string method, string data) { }

	public string UploadString(string address, string data) { }

}

