namespace Steamworks;

[CallbackIdentity(1800)]
public struct GSStatsReceived_t
{
	public const int k_iCallback = 1800; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public CSteamID m_steamIDUser; //Field offset: 0x4

}

