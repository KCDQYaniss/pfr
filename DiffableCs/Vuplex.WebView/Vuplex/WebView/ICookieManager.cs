namespace Vuplex.WebView;

public interface ICookieManager
{

	public Task DeleteCookies(string url, string cookieName = null) { }

	public Task GetCookies(string url, string cookieName = null) { }

	public Task SetCookie(Cookie cookie) { }

}

