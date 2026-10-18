namespace Steamworks;

[CallbackIdentity(3408)]
public struct SetUserItemVoteResult_t
{
	public const int k_iCallback = 3408; //Field offset: 0x0
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x8
	public bool m_bVoteUp; //Field offset: 0xC

}

