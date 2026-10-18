namespace Steamworks;

[CallbackIdentity(1222)]
public struct SteamNetAuthenticationStatus_t
{
	public const int k_iCallback = 1222; //Field offset: 0x0
	public ESteamNetworkingAvailability m_eAvail; //Field offset: 0x0
	private byte[] m_debugMsg_; //Field offset: 0x8

	public string m_debugMsg
	{
		 get { } //Length: 125
		 set { } //Length: 24
	}

	public string get_m_debugMsg() { }

	public void set_m_debugMsg(string value) { }

}

