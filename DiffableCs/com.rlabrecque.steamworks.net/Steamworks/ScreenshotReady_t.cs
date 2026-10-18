namespace Steamworks;

[CallbackIdentity(2301)]
public struct ScreenshotReady_t
{
	public const int k_iCallback = 2301; //Field offset: 0x0
	public ScreenshotHandle m_hLocal; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x4

}

