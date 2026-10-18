namespace Vuplex.WebView.Internal;

public interface IWebPlugin
{

	public ICookieManager CookieManager
	{
		 get { } //Length: 0
	}

	public WebPluginType Type
	{
		 get { } //Length: 0
	}

	public void ClearAllData() { }

	public void CreateMaterial(Action callback) { }

	public IWebView CreateWebView() { }

	public void EnableRemoteDebugging() { }

	public ICookieManager get_CookieManager() { }

	public WebPluginType get_Type() { }

	public void SetAutoplayEnabled(bool enabled) { }

	public void SetCameraAndMicrophoneEnabled(bool enabled) { }

	public void SetIgnoreCertificateErrors(bool ignore) { }

	public void SetStorageEnabled(bool enabled) { }

	public void SetUserAgent(bool mobile) { }

	public void SetUserAgent(string userAgent) { }

}

