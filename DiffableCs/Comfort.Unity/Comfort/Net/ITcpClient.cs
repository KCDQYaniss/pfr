namespace Comfort.Net;

public interface ITcpClient : IClient, IPeer
{

	public void Connect(IPEndPoint endPoint, string clientId, string versionId) { }

	public void Connect(IPEndPoint endPoint, string clientId, string versionId, TimeSpan connectTimeout) { }

	public void Connect(IPEndPoint endPoint, string clientId, string versionId, TimeSpan connectTimeout, TimeSpan reconnectTimeout) { }

}

