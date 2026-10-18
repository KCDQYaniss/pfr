namespace Steamworks;

[CallbackIdentity(3402)]
public struct SteamUGCRequestUGCDetailsResult_t
{
	public const int k_iCallback = 3402; //Field offset: 0x0
	public SteamUGCDetails_t m_details; //Field offset: 0x0
	public bool m_bCachedData; //Field offset: 0x90

}

