namespace Vuplex.WebView;

public class MockWebPlugin : IWebPlugin
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Action callback; //Field offset: 0x10
		public Material material; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <CreateMaterial>b__0() { }

	}

	private static MockWebPlugin _instance; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ICookieManager <CookieManager>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly WebPluginType <Type>k__BackingField; //Field offset: 0x18

	public override ICookieManager CookieManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public static MockWebPlugin Instance
	{
		 get { } //Length: 492
	}

	public override WebPluginType Type
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public MockWebPlugin() { }

	public override void ClearAllData() { }

	public override void CreateMaterial(Action callback) { }

	public override IWebView CreateWebView() { }

	public override void EnableRemoteDebugging() { }

	[CompilerGenerated]
	public override ICookieManager get_CookieManager() { }

	public static MockWebPlugin get_Instance() { }

	[CompilerGenerated]
	public override WebPluginType get_Type() { }

	public override void SetAutoplayEnabled(bool enabled) { }

	public override void SetCameraAndMicrophoneEnabled(bool enabled) { }

	public override void SetIgnoreCertificateErrors(bool ignore) { }

	public override void SetStorageEnabled(bool enabled) { }

	public override void SetUserAgent(bool mobile) { }

	public override void SetUserAgent(string userAgent) { }

}

