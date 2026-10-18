namespace Steamworks;

[CallbackIdentity(343)]
public struct GameConnectedFriendChatMsg_t
{
	public const int k_iCallback = 343; //Field offset: 0x0
	public CSteamID m_steamIDUser; //Field offset: 0x0
	public int m_iMessageID; //Field offset: 0x8

}

