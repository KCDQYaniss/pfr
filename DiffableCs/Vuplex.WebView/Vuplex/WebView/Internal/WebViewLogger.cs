namespace Vuplex.WebView.Internal;

public static class WebViewLogger
{
	private const string PREFIX = "[3D WebView] "; //Field offset: 0x0
	private const string EM_OPENING_REPLACEMENT = ""; //Field offset: 0x0
	private const string EM_CLOSING_REPLACEMENT = ""; //Field offset: 0x0

	private static string _format(string originalMessage) { }

	public static void Log(string message, bool enableFormatting = true) { }

	public static void LogError(string message, bool enableFormatting = true) { }

	public static void LogErrorWithoutFormatting(string message) { }

	public static void LogTip(string message) { }

	public static void LogWarning(string message, bool enableFormatting = true) { }

	public static void LogWarningWithoutFormatting(string message) { }

}

