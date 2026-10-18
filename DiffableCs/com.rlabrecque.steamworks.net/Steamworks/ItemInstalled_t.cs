namespace Steamworks;

[CallbackIdentity(3405)]
public struct ItemInstalled_t
{
	public const int k_iCallback = 3405; //Field offset: 0x0
	public AppId_t m_unAppID; //Field offset: 0x0
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	public UGCHandle_t m_hLegacyContent; //Field offset: 0x10
	public ulong m_unManifestID; //Field offset: 0x18

}

