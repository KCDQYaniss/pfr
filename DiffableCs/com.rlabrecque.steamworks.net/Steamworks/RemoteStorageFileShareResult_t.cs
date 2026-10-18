namespace Steamworks;

[CallbackIdentity(1307)]
public struct RemoteStorageFileShareResult_t
{
	public const int k_iCallback = 1307; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public UGCHandle_t m_hFile; //Field offset: 0x8
	private byte[] m_rgchFilename_; //Field offset: 0x10

	public string m_rgchFilename
	{
		 get { } //Length: 125
		 set { } //Length: 24
	}

	public string get_m_rgchFilename() { }

	public void set_m_rgchFilename(string value) { }

}

