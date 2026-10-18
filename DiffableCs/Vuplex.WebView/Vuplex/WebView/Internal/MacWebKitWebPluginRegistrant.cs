namespace Vuplex.WebView.Internal;

internal class MacWebKitWebPluginRegistrant
{

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void _registerPlugin() { }

	public MacWebKitWebPluginRegistrant() { }

}

