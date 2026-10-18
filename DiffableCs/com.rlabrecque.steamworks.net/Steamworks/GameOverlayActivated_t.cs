namespace Steamworks;

[CallbackIdentity(331)]
public struct GameOverlayActivated_t
{
	public const int k_iCallback = 331; //Field offset: 0x0
	public byte m_bActive; //Field offset: 0x0
	public bool m_bUserInitiated; //Field offset: 0x1
	public AppId_t m_nAppID; //Field offset: 0x4
	public uint m_dwOverlayPID; //Field offset: 0x8

}

