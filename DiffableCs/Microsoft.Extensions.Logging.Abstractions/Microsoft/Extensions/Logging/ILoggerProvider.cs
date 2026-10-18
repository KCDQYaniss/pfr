namespace Microsoft.Extensions.Logging;

public interface ILoggerProvider : IDisposable
{

	[NullableContext(1)]
	public ILogger CreateLogger(string categoryName) { }

}

