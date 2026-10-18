namespace Vuplex.WebView.Internal;

public class StandaloneRuntimeSettings : ScriptableObject
{
	private const string _assetFilePath = "Assets/Resources/VuplexWebViewStandaloneRuntimeSettings.asset"; //Field offset: 0x0
	public bool MacChromiumPluginDisabled; //Field offset: 0x18

	public StandaloneRuntimeSettings() { }

	public static StandaloneRuntimeSettings Load() { }

}

