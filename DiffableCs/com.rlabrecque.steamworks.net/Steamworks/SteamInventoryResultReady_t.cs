namespace Steamworks;

[CallbackIdentity(4700)]
public struct SteamInventoryResultReady_t
{
	public const int k_iCallback = 4700; //Field offset: 0x0
	public SteamInventoryResult_t m_handle; //Field offset: 0x0
	public EResult m_result; //Field offset: 0x4

}

