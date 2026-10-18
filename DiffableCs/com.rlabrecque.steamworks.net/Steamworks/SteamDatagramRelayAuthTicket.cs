namespace Steamworks;

public struct SteamDatagramRelayAuthTicket
{
	private struct ExtraField
	{
		private enum EType
		{
			k_EType_String = 0,
			k_EType_Int = 1,
			k_EType_Fixed64 = 2,
		}

		internal struct FixedBytes128
		{

		}

		private struct OptionValue
		{
			public FixedBytes128 m_szStringValue; //Field offset: 0x0
			private long m_nIntValue; //Field offset: 0x0
			private ulong m_nFixed64Value; //Field offset: 0x0

		}

		private EType m_eType; //Field offset: 0x0
		private byte[] m_szName; //Field offset: 0x8
		private OptionValue m_val; //Field offset: 0x10

	}

	private const int k_nMaxExtraFields = 16; //Field offset: 0x0
	private SteamNetworkingIdentity m_identityGameserver; //Field offset: 0x0
	private SteamNetworkingIdentity m_identityAuthorizedClient; //Field offset: 0x88
	private uint m_unPublicIP; //Field offset: 0x110
	private RTime32 m_rtimeTicketExpiry; //Field offset: 0x114
	private SteamDatagramHostedAddress m_routing; //Field offset: 0x118
	private uint m_nAppID; //Field offset: 0x128
	private int m_nRestrictToVirtualPort; //Field offset: 0x12C
	private int m_nExtraFields; //Field offset: 0x130
	private ExtraField[] m_vecExtraFields; //Field offset: 0x138

	public void Clear() { }

}

