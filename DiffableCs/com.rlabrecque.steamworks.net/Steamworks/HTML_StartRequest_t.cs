namespace Steamworks;

[CallbackIdentity(4503)]
public struct HTML_StartRequest_t
{
	public const int k_iCallback = 4503; //Field offset: 0x0
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	public string pchURL; //Field offset: 0x8
	public string pchTarget; //Field offset: 0x10
	public string pchPostData; //Field offset: 0x18
	public bool bIsRedirect; //Field offset: 0x20

}

