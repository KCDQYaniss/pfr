namespace Microsoft.Extensions.Logging;

internal static class LoggerRuleSelector
{

	private static bool IsBetter(LoggerFilterRule rule, LoggerFilterRule current, string logger, string category) { }

	public static void Select(LoggerFilterOptions options, Type providerType, string category, out Nullable minLevel, out Func filter) { }

}

