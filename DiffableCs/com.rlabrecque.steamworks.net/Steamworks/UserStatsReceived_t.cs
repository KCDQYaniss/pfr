namespace Steamworks;

[CallbackIdentity(1101)]
public struct UserStatsReceived_t
{
	public const int k_iCallback = 1101; //Field offset: 0x0
	public ulong m_nGameID; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x8
	public CSteamID m_steamIDUser; //Field offset: 0xC

}

