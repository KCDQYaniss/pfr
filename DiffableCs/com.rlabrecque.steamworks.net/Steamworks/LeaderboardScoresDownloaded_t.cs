namespace Steamworks;

[CallbackIdentity(1105)]
public struct LeaderboardScoresDownloaded_t
{
	public const int k_iCallback = 1105; //Field offset: 0x0
	public SteamLeaderboard_t m_hSteamLeaderboard; //Field offset: 0x0
	public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries; //Field offset: 0x8
	public int m_cEntryCount; //Field offset: 0x10

}

