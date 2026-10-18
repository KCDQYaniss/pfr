namespace Microsoft.Extensions.Logging;

[Extension]
internal static class ActivityExtensions
{

	[Extension]
	public static string GetParentId(Activity activity) { }

	[Extension]
	public static string GetSpanId(Activity activity) { }

	[Extension]
	public static string GetTraceId(Activity activity) { }

}

