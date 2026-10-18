namespace Steamworks;

[CallbackIdentity(714)]
public struct GamepadTextInputDismissed_t
{
	public const int k_iCallback = 714; //Field offset: 0x0
	public bool m_bSubmitted; //Field offset: 0x0
	public uint m_unSubmittedText; //Field offset: 0x4
	public AppId_t m_unAppID; //Field offset: 0x8

}

