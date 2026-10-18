namespace Vuplex.WebView;

public class StandaloneCookieManager : ICookieManager
{
	private static StandaloneCookieManager _instance; //Field offset: 0x0

	public static StandaloneCookieManager Instance
	{
		 get { } //Length: 183
	}

	public StandaloneCookieManager() { }

	public override Task DeleteCookies(string url, string cookieName = null) { }

	public static StandaloneCookieManager get_Instance() { }

	public override Task GetCookies(string url, string cookieName = null) { }

	public override Task SetCookie(Cookie cookie) { }

}

