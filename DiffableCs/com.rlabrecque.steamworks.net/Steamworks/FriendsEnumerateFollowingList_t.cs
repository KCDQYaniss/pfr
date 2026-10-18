namespace Steamworks;

[CallbackIdentity(346)]
public struct FriendsEnumerateFollowingList_t
{
	public const int k_iCallback = 346; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public CSteamID[] m_rgSteamID; //Field offset: 0x8
	public int m_nResultsReturned; //Field offset: 0x10
	public int m_nTotalResultCount; //Field offset: 0x14

}

