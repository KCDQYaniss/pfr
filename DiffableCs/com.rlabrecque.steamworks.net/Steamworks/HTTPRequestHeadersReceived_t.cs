namespace Steamworks;

[CallbackIdentity(2102)]
public struct HTTPRequestHeadersReceived_t
{
	public const int k_iCallback = 2102; //Field offset: 0x0
	public HTTPRequestHandle m_hRequest; //Field offset: 0x0
	public ulong m_ulContextValue; //Field offset: 0x8

}

