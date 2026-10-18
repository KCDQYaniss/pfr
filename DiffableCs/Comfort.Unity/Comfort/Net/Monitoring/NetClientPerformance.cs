namespace Comfort.Net.Monitoring;

public sealed class NetClientPerformance
{

	public NetClientPerformance() { }

	[Conditional("NetPerformance")]
	public void ClientConnectAccepted() { }

	[Conditional("NetPerformance")]
	public void ClientConnectClosed() { }

	[Conditional("NetPerformance")]
	public void ClientConnectDebugCounter() { }

	[Conditional("NetPerformance")]
	public void ClientConnectFailed() { }

	[Conditional("NetPerformance")]
	public void ClientConnectOpened() { }

	[Conditional("NetPerformance")]
	public void ClientConnectResponsed() { }

	[Conditional("NetPerformance")]
	public void ClientConnectTimeout() { }

	[Conditional("NetPerformance")]
	public void ClientReconnectTimeout() { }

	public static NetClientPerformance Create(IPerformanceCountersRegistry registry) { }

}

