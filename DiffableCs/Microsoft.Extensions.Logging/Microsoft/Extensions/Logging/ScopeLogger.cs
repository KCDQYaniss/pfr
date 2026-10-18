namespace Microsoft.Extensions.Logging;

[IsReadOnly]
internal struct ScopeLogger
{
	[CompilerGenerated]
	private readonly ILogger <Logger>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IExternalScopeProvider <ExternalScopeProvider>k__BackingField; //Field offset: 0x8

	public ScopeLogger(ILogger logger, IExternalScopeProvider externalScopeProvider) { }

}

