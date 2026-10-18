namespace Steamworks;

[CallbackIdentity(6002)]
public struct SteamTimelineEventRecordingExists_t
{
	public const int k_iCallback = 6002; //Field offset: 0x0
	public ulong m_ulEventID; //Field offset: 0x0
	public bool m_bRecordingExists; //Field offset: 0x8

}

