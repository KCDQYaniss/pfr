namespace Vuplex.WebView;

internal class MockCookieManager : ICookieManager
{
	private static MockCookieManager _instance; //Field offset: 0x0

	public static MockCookieManager Instance
	{
		 get { } //Length: 183
	}

	public MockCookieManager() { }

	public override Task DeleteCookies(string url, string cookieName = null) { }

	public static MockCookieManager get_Instance() { }

	public override Task GetCookies(string url, string cookieName = null) { }

	public override Task SetCookie(Cookie cookie) { }

}

