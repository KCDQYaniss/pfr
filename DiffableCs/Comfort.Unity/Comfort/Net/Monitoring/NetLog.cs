namespace Comfort.Net.Monitoring;

public sealed class NetLog
{
	private readonly ILog ; //Field offset: 0x10

	public NetLog(ILog log = null) { }

	public void Error(object message) { }

	public void Info(object message) { }

	public void InfoFormat(string format, object message0) { }

}

