namespace Microsoft.Extensions.Logging;

[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class LoggingBuilderExtensions
{

	[Extension]
	public static ILoggingBuilder ClearProviders(ILoggingBuilder builder) { }

	[Extension]
	public static ILoggingBuilder SetMinimumLevel(ILoggingBuilder builder, LogLevel level) { }

}

