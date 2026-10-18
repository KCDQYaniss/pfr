namespace EFT;

public sealed class ClientLogConfiguration : LogConfiguration
{
	private static readonly string aiDataName; //Field offset: 0x0
	private readonly GlobalLogger _errors; //Field offset: 0x38
	private readonly GlobalLogger _output; //Field offset: 0x40
	private readonly GlobalLogger _aiErrors; //Field offset: 0x48

	private static ClientLogConfiguration() { }

	public ClientLogConfiguration(bool ignoreErrors = false) { }

	public virtual void GlobalLog(string sourceLogger, LogLevel logLevel, string message) { }

}

