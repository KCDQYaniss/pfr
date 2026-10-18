namespace Steamworks;

public struct SteamNetConnectionRealTimeLaneStatus_t
{
	public int m_cbPendingUnreliable; //Field offset: 0x0
	public int m_cbPendingReliable; //Field offset: 0x4
	public int m_cbSentUnackedReliable; //Field offset: 0x8
	public int _reservePad1; //Field offset: 0xC
	public SteamNetworkingMicroseconds m_usecQueueTime; //Field offset: 0x10
	public uint[] reserved; //Field offset: 0x18

}

