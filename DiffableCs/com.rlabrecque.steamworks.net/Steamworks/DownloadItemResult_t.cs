namespace Steamworks;

[CallbackIdentity(3406)]
public struct DownloadItemResult_t
{
	public const int k_iCallback = 3406; //Field offset: 0x0
	public AppId_t m_unAppID; //Field offset: 0x0
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	public EResult m_eResult; //Field offset: 0x10

}

