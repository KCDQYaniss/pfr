namespace Steamworks;

[CallbackIdentity(168)]
public struct GetTicketForWebApiResponse_t
{
	public const int k_iCallback = 168; //Field offset: 0x0
	public HAuthTicket m_hAuthTicket; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x4
	public int m_cubTicket; //Field offset: 0x8
	public byte[] m_rgubTicket; //Field offset: 0x10

}

