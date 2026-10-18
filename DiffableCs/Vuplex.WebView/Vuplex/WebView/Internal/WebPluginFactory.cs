namespace Vuplex.WebView.Internal;

public class WebPluginFactory
{
	public static bool IgnoreMissingPluginInEditor; //Field offset: 0x0
	protected static HashSet _allPlugins; //Field offset: 0x8
	protected static IWebPlugin _androidPlugin; //Field offset: 0x10
	protected static IWebPlugin _androidGeckoPlugin; //Field offset: 0x18
	private static bool _beforeSceneLoadCalled; //Field offset: 0x20
	protected static IWebPlugin _iosPlugin; //Field offset: 0x28
	protected static IWebPlugin _macWebKitPlugin; //Field offset: 0x30
	protected static IWebPlugin _standalonePlugin; //Field offset: 0x38
	protected static IWebPlugin _uwpPlugin; //Field offset: 0x40
	protected static IWebPlugin _visionOSPlugin; //Field offset: 0x48
	protected static IWebPlugin _webGLPlugin; //Field offset: 0x50
	private bool _mockWarningLogged; //Field offset: 0x10

	private static void _addPlugin(IWebPlugin plugin) { }

	private void _assertNotTooEarly() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void _beforeSceneLoad() { }

	private IWebPlugin _choosePlugin(IWebPlugin originalPlugin, string buildPlatformName, string packageName, string storeUrlPath, WebPluginType[] preferredPlugins) { }

	private IWebPlugin _getCorrectPluginForStandalone(WebPluginType[] preferredPlugins) { }

	private string _getMoreInfoText(string storeUrlPath) { }

	private void _logMockWarningOnce(string reason) { }

	private static WebPluginFactory() { }

	public WebPluginFactory() { }

	public override List GetAllPlugins() { }

	public override IWebPlugin GetDefaultPlugin(WebPluginType[] preferredPlugins = null) { }

	public static void RegisterAndroidGeckoPlugin(IWebPlugin plugin) { }

	public static void RegisterAndroidPlugin(IWebPlugin plugin) { }

	public static void RegisterIOSPlugin(IWebPlugin plugin) { }

	public static void RegisterMacWebKitPlugin(IWebPlugin plugin) { }

	public static void RegisterStandalonePlugin(IWebPlugin plugin) { }

	public static void RegisterUwpPlugin(IWebPlugin plugin) { }

	public static void RegisterVisionOSPlugin(IWebPlugin plugin) { }

	public static void RegisterWebGLPlugin(IWebPlugin plugin) { }

}

