namespace Steamworks;

[CallbackIdentity(2804)]
public struct SteamInputGamepadSlotChange_t
{
	public const int k_iCallback = 2804; //Field offset: 0x0
	public AppId_t m_unAppID; //Field offset: 0x0
	public InputHandle_t m_ulDeviceHandle; //Field offset: 0x8
	public ESteamInputType m_eDeviceType; //Field offset: 0x10
	public int m_nOldGamepadSlot; //Field offset: 0x14
	public int m_nNewGamepadSlot; //Field offset: 0x18

}

