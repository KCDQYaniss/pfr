namespace Steamworks;

[CallbackIdentity(4705)]
public struct SteamInventoryRequestPricesResult_t
{
	public const int k_iCallback = 4705; //Field offset: 0x0
	public EResult m_result; //Field offset: 0x0
	private byte[] m_rgchCurrency_; //Field offset: 0x8

	public string m_rgchCurrency
	{
		 get { } //Length: 125
		 set { } //Length: 24
	}

	public string get_m_rgchCurrency() { }

	public void set_m_rgchCurrency(string value) { }

}

