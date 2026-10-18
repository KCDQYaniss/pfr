namespace Steamworks;

public struct SteamNetConnectionInfo_t
{
	public SteamNetworkingIdentity m_identityRemote; //Field offset: 0x0
	public long m_nUserData; //Field offset: 0x88
	public HSteamListenSocket m_hListenSocket; //Field offset: 0x90
	public SteamNetworkingIPAddr m_addrRemote; //Field offset: 0x98
	public ushort m__pad1; //Field offset: 0xA8
	public SteamNetworkingPOPID m_idPOPRemote; //Field offset: 0xAC
	public SteamNetworkingPOPID m_idPOPRelay; //Field offset: 0xB0
	public ESteamNetworkingConnectionState m_eState; //Field offset: 0xB4
	public int m_eEndReason; //Field offset: 0xB8
	private byte[] m_szEndDebug_; //Field offset: 0xC0
	private byte[] m_szConnectionDescription_; //Field offset: 0xC8
	public int m_nFlags; //Field offset: 0xD0
	public uint[] reserved; //Field offset: 0xD8

	public string m_szConnectionDescription
	{
		 get { } //Length: 126
		 set { } //Length: 27
	}

	public string m_szEndDebug
	{
		 get { } //Length: 126
		 set { } //Length: 27
	}

	public string get_m_szConnectionDescription() { }

	public string get_m_szEndDebug() { }

	public void set_m_szConnectionDescription(string value) { }

	public void set_m_szEndDebug(string value) { }

}

