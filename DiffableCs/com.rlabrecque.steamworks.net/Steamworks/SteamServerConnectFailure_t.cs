namespace Steamworks;

[CallbackIdentity(102)]
public struct SteamServerConnectFailure_t
{
	public const int k_iCallback = 102; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public bool m_bStillRetrying; //Field offset: 0x4

}

