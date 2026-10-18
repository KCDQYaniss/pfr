namespace Steamworks;

[CallbackIdentity(505)]
public struct LobbyDataUpdate_t
{
	public const int k_iCallback = 505; //Field offset: 0x0
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	public ulong m_ulSteamIDMember; //Field offset: 0x8
	public byte m_bSuccess; //Field offset: 0x10

}

