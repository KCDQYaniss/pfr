namespace Steamworks;

[CallbackIdentity(351)]
public struct EquippedProfileItems_t
{
	public const int k_iCallback = 351; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public CSteamID m_steamID; //Field offset: 0x4
	public bool m_bHasAnimatedAvatar; //Field offset: 0xC
	public bool m_bHasAvatarFrame; //Field offset: 0xD
	public bool m_bHasProfileModifier; //Field offset: 0xE
	public bool m_bHasProfileBackground; //Field offset: 0xF
	public bool m_bHasMiniProfileBackground; //Field offset: 0x10
	public bool m_bFromCache; //Field offset: 0x11

}

