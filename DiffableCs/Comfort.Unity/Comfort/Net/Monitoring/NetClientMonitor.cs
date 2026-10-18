namespace Comfort.Net.Monitoring;

public sealed class NetClientMonitor : INetClientMonitor
{
	public const string LogDefaultFileName = "NetLog"; //Field offset: 0x0
	[CompilerGenerated]
	private ConnectionPerformance ; //Field offset: 0x10
	[CompilerGenerated]
	private NetClientPerformance ; //Field offset: 0x18
	[CompilerGenerated]
	private NetLog ; //Field offset: 0x20

	public private override ConnectionPerformance ConnectionPerformance
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override NetLog NetLog
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override NetClientPerformance Performance
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private NetClientMonitor(IPerformanceCountersRegistry , ILog ) { }

	public static NetClientMonitor Create(IPerformanceCountersRegistry registry, ILog log) { }

	public static NetClientMonitor Default(IPerformanceCountersRegistry registry) { }

	[CompilerGenerated]
	public override ConnectionPerformance get_ConnectionPerformance() { }

	[CompilerGenerated]
	public override NetLog get_NetLog() { }

	[CompilerGenerated]
	public override NetClientPerformance get_Performance() { }

	public static NetClientMonitor None() { }

	[CompilerGenerated]
	private void set_ConnectionPerformance(ConnectionPerformance value) { }

	[CompilerGenerated]
	private void set_NetLog(NetLog value) { }

	[CompilerGenerated]
	private void set_Performance(NetClientPerformance value) { }

}

