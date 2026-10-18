namespace Steamworks;

[CallbackIdentity(3415)]
public struct RemoveAppDependencyResult_t
{
	public const int k_iCallback = 3415; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	public AppId_t m_nAppID; //Field offset: 0x10

}

