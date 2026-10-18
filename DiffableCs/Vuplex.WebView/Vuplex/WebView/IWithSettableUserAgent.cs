namespace Vuplex.WebView;

public interface IWithSettableUserAgent
{

	public void SetUserAgent(bool mobile) { }

	public void SetUserAgent(string userAgent) { }

}

