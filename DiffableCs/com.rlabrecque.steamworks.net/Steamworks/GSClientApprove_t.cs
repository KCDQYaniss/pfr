namespace Steamworks;

[CallbackIdentity(201)]
public struct GSClientApprove_t
{
	public const int k_iCallback = 201; //Field offset: 0x0
	public CSteamID m_SteamID; //Field offset: 0x0
	public CSteamID m_OwnerSteamID; //Field offset: 0x8

}

