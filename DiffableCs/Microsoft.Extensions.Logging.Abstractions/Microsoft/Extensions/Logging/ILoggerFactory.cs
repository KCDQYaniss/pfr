namespace Microsoft.Extensions.Logging;

[NullableContext(1)]
public interface ILoggerFactory : IDisposable
{

	public ILogger CreateLogger(string categoryName) { }

}

