namespace Steamworks;

[CallbackIdentity(202)]
public struct GSClientDeny_t
{
	public const int k_iCallback = 202; //Field offset: 0x0
	public CSteamID m_SteamID; //Field offset: 0x0
	public EDenyReason m_eDenyReason; //Field offset: 0x8
	private byte[] m_rgchOptionalText_; //Field offset: 0x10

	public string m_rgchOptionalText
	{
		 get { } //Length: 125
		 set { } //Length: 24
	}

	public string get_m_rgchOptionalText() { }

	public void set_m_rgchOptionalText(string value) { }

}

