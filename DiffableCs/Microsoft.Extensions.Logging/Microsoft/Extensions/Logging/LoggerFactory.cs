namespace Microsoft.Extensions.Logging;

[DebuggerDisplay("{DebuggerToString(),nq}")]
[DebuggerTypeProxy(typeof(LoggerFactoryDebugView))]
[Nullable(0)]
[NullableContext(1)]
public class LoggerFactory : ILoggerFactory, IDisposable
{
	private sealed class DisposingLoggerFactory : ILoggerFactory, IDisposable
	{
		private readonly ILoggerFactory _loggerFactory; //Field offset: 0x10
		private readonly ServiceProvider _serviceProvider; //Field offset: 0x18

		public DisposingLoggerFactory(ILoggerFactory loggerFactory, ServiceProvider serviceProvider) { }

		public override ILogger CreateLogger(string categoryName) { }

		public override void Dispose() { }

	}

	private sealed class LoggerFactoryDebugView
	{

	}

	private struct ProviderRegistration
	{
		public ILoggerProvider Provider; //Field offset: 0x0
		public bool ShouldDispose; //Field offset: 0x8

	}

	private readonly ConcurrentDictionary _loggers; //Field offset: 0x10
	private readonly List _providerRegistrations; //Field offset: 0x18
	private readonly object _sync; //Field offset: 0x20
	private bool _disposed; //Field offset: 0x28
	private readonly IDisposable _changeTokenRegistration; //Field offset: 0x30
	private LoggerFilterOptions _filterOptions; //Field offset: 0x38
	private IExternalScopeProvider _scopeProvider; //Field offset: 0x40
	private readonly LoggerFactoryOptions _factoryOptions; //Field offset: 0x48

	public LoggerFactory() { }

	public LoggerFactory(IEnumerable providers) { }

	public LoggerFactory(IEnumerable providers, LoggerFilterOptions filterOptions) { }

	public LoggerFactory(IEnumerable providers, IOptionsMonitor filterOption) { }

	public LoggerFactory(IEnumerable providers, IOptionsMonitor filterOption, IOptions options) { }

	public LoggerFactory(IEnumerable providers, IOptionsMonitor filterOption, IOptions options = null, IExternalScopeProvider scopeProvider = null) { }

	private void AddProviderRegistration(ILoggerProvider provider, bool dispose) { }

	private ValueTuple ApplyFilters(LoggerInformation[] loggers) { }

	protected override bool CheckDisposed() { }

	public static ILoggerFactory Create(Action configure) { }

	public override ILogger CreateLogger(string categoryName) { }

	private LoggerInformation[] CreateLoggers(string categoryName) { }

	public override void Dispose() { }

	[MemberNotNull("_filterOptions")]
	private void RefreshFilters(LoggerFilterOptions filterOptions) { }

}

