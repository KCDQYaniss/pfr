namespace System.Net.WebSockets;

public sealed class ClientWebSocketOptions
{
	private bool _isReadOnly; //Field offset: 0x10
	private readonly List _requestedSubProtocols; //Field offset: 0x18
	private readonly WebHeaderCollection _requestHeaders; //Field offset: 0x20
	private TimeSpan _keepAliveInterval; //Field offset: 0x28
	private IWebProxy _proxy; //Field offset: 0x30
	private X509CertificateCollection _clientCertificates; //Field offset: 0x38
	private CookieContainer _cookies; //Field offset: 0x40
	private int _receiveBufferSize; //Field offset: 0x48
	private int _sendBufferSize; //Field offset: 0x4C
	private Nullable _buffer; //Field offset: 0x50

	internal Nullable Buffer
	{
		internal get { } //Length: 21
	}

	public X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 171
	}

	public CookieContainer Cookies
	{
		 get { } //Length: 5
	}

	public TimeSpan KeepAliveInterval
	{
		 get { } //Length: 5
	}

	public IWebProxy Proxy
	{
		 set { } //Length: 168
	}

	internal int ReceiveBufferSize
	{
		internal get { } //Length: 4
	}

	internal List RequestedSubProtocols
	{
		internal get { } //Length: 5
	}

	internal WebHeaderCollection RequestHeaders
	{
		internal get { } //Length: 5
	}

	internal int SendBufferSize
	{
		internal get { } //Length: 4
	}

	internal ClientWebSocketOptions() { }

	public void AddSubProtocol(string subProtocol) { }

	internal Nullable get_Buffer() { }

	public X509CertificateCollection get_ClientCertificates() { }

	public CookieContainer get_Cookies() { }

	public TimeSpan get_KeepAliveInterval() { }

	internal int get_ReceiveBufferSize() { }

	internal List get_RequestedSubProtocols() { }

	internal WebHeaderCollection get_RequestHeaders() { }

	internal int get_SendBufferSize() { }

	public void set_Proxy(IWebProxy value) { }

	public void SetRequestHeader(string headerName, string headerValue) { }

	internal void SetToReadOnly() { }

	private void ThrowIfReadOnly() { }

}

