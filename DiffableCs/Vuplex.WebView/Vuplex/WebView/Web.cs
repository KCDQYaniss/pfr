namespace Vuplex.WebView;

public static class Web
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__5_0; //Field offset: 0x8
		public static Action <>9__8_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <ClearAllData>b__5_0(IWebPlugin p) { }

		internal void <EnableRemoteDebugging>b__8_0(IWebPlugin p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public bool enabled; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal void <SetCameraAndMicrophoneEnabled>b__0(IWebPlugin p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public bool ignore; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <SetIgnoreCertificateErrors>b__0(IWebPlugin p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public bool enabled; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal void <SetStorageEnabled>b__0(IWebPlugin p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public bool mobile; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal void <SetUserAgent>b__0(IWebPlugin p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public string userAgent; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal void <SetUserAgent>b__0(IWebPlugin p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public bool enabled; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal void <SetAutoplayEnabled>b__0(IWebPlugin p) { }

	}

	public static bool AutoEnableIme; //Field offset: 0x0
	private const string CreateMaterialMessage = "Web.CreateMaterial() is now deprecated in v4. Please use IWebView.CreateMaterial() instead: https://developer.vuplex.com/webview/IWebView#CreateMaterial"; //Field offset: 0x0
	private const string CreateTextureMessage = "Web.CreateTexture() has been removed in v4 because IWebView instances now automatically create their own textures. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init"; //Field offset: 0x0
	private static WebPluginFactory _pluginFactory; //Field offset: 0x8

	public static ICookieManager CookieManager
	{
		 get { } //Length: 153
	}

	public static WebPluginType DefaultPluginType
	{
		 get { } //Length: 156
	}

	private static Web() { }

	public static void ClearAllData() { }

	[Obsolete("Web.CreateMaterial() is now deprecated in v4. Please use IWebView.CreateMaterial() instead: https://developer.vuplex.com/webview/IWebView#CreateMaterial")]
	public static void CreateMaterial(Action callback) { }

	[Obsolete("Web.CreateMaterial() is now deprecated in v4. Please use IWebView.CreateMaterial() instead: https://developer.vuplex.com/webview/IWebView#CreateMaterial")]
	public static Task CreateMaterial() { }

	[Obsolete("Web.CreateTexture() has been removed in v4 because IWebView instances now automatically create their own textures. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", True)]
	public static void CreateTexture(float width, float height, Action callback) { }

	[Obsolete("Web.CreateTexture() has been removed in v4 because IWebView instances now automatically create their own textures. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", True)]
	public static Task CreateTexture(int width, int height) { }

	[Obsolete("Web.CreateVideoMaterial() has been removed. Please use IWithFallbackVideo.CreateVideoMaterial() instead: https://developer.vuplex.com/webview/IWithFallbackVideo#CreateVideoMaterial", True)]
	public static void CreateVideoMaterial(Action callback) { }

	public static IWebView CreateWebView() { }

	public static IWebView CreateWebView(WebPluginType[] preferredPlugins) { }

	public static void EnableRemoteDebugging() { }

	public static ICookieManager get_CookieManager() { }

	public static WebPluginType get_DefaultPluginType() { }

	public static void SetAutoplayEnabled(bool enabled) { }

	public static void SetCameraAndMicrophoneEnabled(bool enabled) { }

	public static void SetIgnoreCertificateErrors(bool ignore) { }

	internal static void SetPluginFactory(WebPluginFactory pluginFactory) { }

	public static void SetStorageEnabled(bool enabled) { }

	[Obsolete("Web.SetTouchScreenKeyboardEnabled() has been removed. Please use the NativeOnScreenKeyboardEnabled property of WebViewPrefab / CanvasWebViewPrefab or the IWithNativeOnScreenKeyboard interface instead: https://developer.vuplex.com/webview/WebViewPrefab#NativeOnScreenKeyboardEnabled", True)]
	public static void SetTouchScreenKeyboardEnabled(bool enabled) { }

	public static void SetUserAgent(string userAgent) { }

	public static void SetUserAgent(bool mobile) { }

}

