namespace Steamworks;

[CallbackIdentity(203)]
public struct GSClientKick_t
{
	public const int k_iCallback = 203; //Field offset: 0x0
	public CSteamID m_SteamID; //Field offset: 0x0
	public EDenyReason m_eDenyReason; //Field offset: 0x8

}

