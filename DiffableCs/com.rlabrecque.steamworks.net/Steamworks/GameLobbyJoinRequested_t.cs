namespace Steamworks;

[CallbackIdentity(333)]
public struct GameLobbyJoinRequested_t
{
	public const int k_iCallback = 333; //Field offset: 0x0
	public CSteamID m_steamIDLobby; //Field offset: 0x0
	public CSteamID m_steamIDFriend; //Field offset: 0x8

}

