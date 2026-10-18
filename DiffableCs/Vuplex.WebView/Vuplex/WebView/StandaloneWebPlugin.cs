namespace Vuplex.WebView;

public class StandaloneWebPlugin : MonoBehaviour, IWebPlugin
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Start>b__20_0() { }

	}

	private static StandaloneWebPlugin _instance; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ICookieManager <CookieManager>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly WebPluginType <Type>k__BackingField; //Field offset: 0x28

	public override ICookieManager CookieManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public static StandaloneWebPlugin Instance
	{
		 get { } //Length: 639
	}

	public override WebPluginType Type
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void _registerPlugin() { }

	public StandaloneWebPlugin() { }

	public override void ClearAllData() { }

	public override void CreateMaterial(Action callback) { }

	public override IWebView CreateWebView() { }

	public override void EnableRemoteDebugging() { }

	[CompilerGenerated]
	public override ICookieManager get_CookieManager() { }

	public static StandaloneWebPlugin get_Instance() { }

	[CompilerGenerated]
	public override WebPluginType get_Type() { }

	public override void SetAutoplayEnabled(bool enabled) { }

	public override void SetCameraAndMicrophoneEnabled(bool enabled) { }

	public override void SetIgnoreCertificateErrors(bool ignore) { }

	public override void SetStorageEnabled(bool enabled) { }

	public override void SetUserAgent(bool mobile) { }

	public override void SetUserAgent(string userAgent) { }

	private void Start() { }

}

