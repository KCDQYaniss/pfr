namespace Steamworks;

[CallbackIdentity(1223)]
public struct SteamNetworkingFakeIPResult_t
{
	public const int k_iCallback = 1223; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public SteamNetworkingIdentity m_identity; //Field offset: 0x4
	public uint m_unIP; //Field offset: 0x8C
	public ushort[] m_unPorts; //Field offset: 0x90

}

