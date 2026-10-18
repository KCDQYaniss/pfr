namespace Steamworks;

[CallbackIdentity(5301)]
public struct JoinPartyCallback_t
{
	public const int k_iCallback = 5301; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public PartyBeaconID_t m_ulBeaconID; //Field offset: 0x8
	public CSteamID m_SteamIDBeaconOwner; //Field offset: 0x10
	private byte[] m_rgchConnectString_; //Field offset: 0x18

	public string m_rgchConnectString
	{
		 get { } //Length: 125
		 set { } //Length: 24
	}

	public string get_m_rgchConnectString() { }

	public void set_m_rgchConnectString(string value) { }

}

