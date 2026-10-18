namespace Steamworks;

[CallbackIdentity(332)]
public struct GameServerChangeRequested_t
{
	public const int k_iCallback = 332; //Field offset: 0x0
	private byte[] m_rgchServer_; //Field offset: 0x0
	private byte[] m_rgchPassword_; //Field offset: 0x8

	public string m_rgchPassword
	{
		 get { } //Length: 125
		 set { } //Length: 24
	}

	public string m_rgchServer
	{
		 get { } //Length: 125
		 set { } //Length: 23
	}

	public string get_m_rgchPassword() { }

	public string get_m_rgchServer() { }

	public void set_m_rgchPassword(string value) { }

	public void set_m_rgchServer(string value) { }

}

