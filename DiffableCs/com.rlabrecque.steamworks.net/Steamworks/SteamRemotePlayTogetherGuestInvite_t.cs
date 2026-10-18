namespace Steamworks;

[CallbackIdentity(5703)]
public struct SteamRemotePlayTogetherGuestInvite_t
{
	public const int k_iCallback = 5703; //Field offset: 0x0
	private byte[] m_szConnectURL_; //Field offset: 0x0

	public string m_szConnectURL
	{
		 get { } //Length: 125
		 set { } //Length: 23
	}

	public string get_m_szConnectURL() { }

	public void set_m_szConnectURL(string value) { }

}

