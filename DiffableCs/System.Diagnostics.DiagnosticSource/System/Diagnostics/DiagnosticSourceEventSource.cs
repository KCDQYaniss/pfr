namespace System.Diagnostics;

[EventSource(Name = "Microsoft-Diagnostics-DiagnosticSource")]
internal sealed class DiagnosticSourceEventSource : EventSource
{
	internal static class Keywords
	{
		public const EventKeywords Messages = 1; //Field offset: 0x0
		public const EventKeywords Events = 2; //Field offset: 0x0
		public const EventKeywords IgnoreShortCutKeywords = 2048; //Field offset: 0x0
		public const EventKeywords AspNetCoreHosting = 4096; //Field offset: 0x0
		public const EventKeywords EntityFrameworkCoreCommands = 8192; //Field offset: 0x0

	}

	public static readonly DiagnosticSourceEventSource Log; //Field offset: 0x0
	private readonly string AspNetCoreHostingKeywordValue; //Field offset: 0x20
	private readonly string EntityFrameworkCoreCommandsKeywordValue; //Field offset: 0x28

	private static DiagnosticSourceEventSource() { }

	private DiagnosticSourceEventSource() { }

}

