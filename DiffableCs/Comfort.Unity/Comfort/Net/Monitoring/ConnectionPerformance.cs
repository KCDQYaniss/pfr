namespace Comfort.Net.Monitoring;

public sealed class ConnectionPerformance
{

	public ConnectionPerformance() { }

	[Conditional("NetPerformance")]
	public void BytesReceived(int bytes) { }

	[Conditional("NetPerformance")]
	public void BytesSended(int bytes) { }

	public static ConnectionPerformance Create(IPerformanceCountersRegistry registry) { }

	[Conditional("NetPerformance")]
	public void Ping(long ping) { }

	[Conditional("NetPerformance")]
	public void ReceiveBufferExtended(int bytes) { }

	[Conditional("NetPerformance")]
	public void ReceiveBufferReduced(int bytes) { }

	[Conditional("NetPerformance")]
	public void SendBufferExtended(int bytes) { }

	[Conditional("NetPerformance")]
	public void SendBufferReduced(int bytes) { }

}

