namespace Steamworks;

public struct SteamNetworkingIdentity : IEquatable
{
	public const int k_cbMaxGenericBytes = 32; //Field offset: 0x0
	public const int k_cchMaxGenericString = 32; //Field offset: 0x0
	public const int k_cchMaxString = 128; //Field offset: 0x0
	public const int k_cchMaxXboxPairwiseID = 33; //Field offset: 0x0
	public ESteamNetworkingIdentityType m_eType; //Field offset: 0x0
	private int m_cbSize; //Field offset: 0x4
	private uint m_reserved0; //Field offset: 0x8
	private uint m_reserved1; //Field offset: 0xC
	private uint m_reserved2; //Field offset: 0x10
	private uint m_reserved3; //Field offset: 0x14
	private uint m_reserved4; //Field offset: 0x18
	private uint m_reserved5; //Field offset: 0x1C
	private uint m_reserved6; //Field offset: 0x20
	private uint m_reserved7; //Field offset: 0x24
	private uint m_reserved8; //Field offset: 0x28
	private uint m_reserved9; //Field offset: 0x2C
	private uint m_reserved10; //Field offset: 0x30
	private uint m_reserved11; //Field offset: 0x34
	private uint m_reserved12; //Field offset: 0x38
	private uint m_reserved13; //Field offset: 0x3C
	private uint m_reserved14; //Field offset: 0x40
	private uint m_reserved15; //Field offset: 0x44
	private uint m_reserved16; //Field offset: 0x48
	private uint m_reserved17; //Field offset: 0x4C
	private uint m_reserved18; //Field offset: 0x50
	private uint m_reserved19; //Field offset: 0x54
	private uint m_reserved20; //Field offset: 0x58
	private uint m_reserved21; //Field offset: 0x5C
	private uint m_reserved22; //Field offset: 0x60
	private uint m_reserved23; //Field offset: 0x64
	private uint m_reserved24; //Field offset: 0x68
	private uint m_reserved25; //Field offset: 0x6C
	private uint m_reserved26; //Field offset: 0x70
	private uint m_reserved27; //Field offset: 0x74
	private uint m_reserved28; //Field offset: 0x78
	private uint m_reserved29; //Field offset: 0x7C
	private uint m_reserved30; //Field offset: 0x80
	private uint m_reserved31; //Field offset: 0x84

	public void Clear() { }

	public override bool Equals(SteamNetworkingIdentity x) { }

	public ESteamNetworkingFakeIPType GetFakeIPType() { }

	public byte[] GetGenericBytes(out int cbLen) { }

	public string GetGenericString() { }

	public SteamNetworkingIPAddr GetIPAddr() { }

	public uint GetIPv4() { }

	public ulong GetPSNID() { }

	public CSteamID GetSteamID() { }

	public ulong GetSteamID64() { }

	public string GetXboxPairwiseID() { }

	public bool IsFakeIP() { }

	public bool IsInvalid() { }

	public bool IsLocalHost() { }

	public bool ParseString(string pszStr) { }

	public bool SetGenericBytes(byte[] data, uint cbLen) { }

	public bool SetGenericString(string pszString) { }

	public void SetIPAddr(SteamNetworkingIPAddr addr) { }

	public void SetIPv4Addr(uint nIPv4, ushort nPort) { }

	public void SetLocalHost() { }

	public void SetPSNID(ulong id) { }

	public void SetSteamID(CSteamID steamID) { }

	public void SetSteamID64(ulong steamID) { }

	public bool SetXboxPairwiseID(string pszString) { }

	public void ToString(out string buf) { }

}

