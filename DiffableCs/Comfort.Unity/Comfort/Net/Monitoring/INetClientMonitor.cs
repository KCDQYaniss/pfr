namespace Comfort.Net.Monitoring;

public interface INetClientMonitor
{

	public ConnectionPerformance ConnectionPerformance
	{
		 get { } //Length: 0
	}

	public NetLog NetLog
	{
		 get { } //Length: 0
	}

	public NetClientPerformance Performance
	{
		 get { } //Length: 0
	}

	public ConnectionPerformance get_ConnectionPerformance() { }

	public NetLog get_NetLog() { }

	public NetClientPerformance get_Performance() { }

}

