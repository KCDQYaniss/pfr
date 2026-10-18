namespace Vuplex.WebView;

[Obsolete("The MacWebKitWebView class is only available on macOS. So, when building for other platforms (e.g. Windows, Android, iOS, WebGL), it's necessary to use the directive `#if (UNITY_STANDALONE_OSX && !UNITY_EDITOR) || UNITY_EDITOR_OSX` like described here: https://support.vuplex.com/articles/how-to-call-platform-specific-apis . Note: MacWebKitWebView isn't actually obsolete. This compiler error just reports it's obsolete because 3D WebView generated the error with System.ObsoleteAttribute.", True)]
public class MacWebKitWebView
{

	public MacWebKitWebView() { }

}

