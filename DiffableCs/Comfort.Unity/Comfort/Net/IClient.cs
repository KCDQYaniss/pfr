namespace Comfort.Net;

public interface IClient : IPeer
{

	public void Connect(string connectionPoint, string clientId, string versionId) { }

	public void Connect(string connectionPoint, string clientId, string versionId, TimeSpan connectTimeout, TimeSpan reconnectTimeout) { }

	public void Disconnect() { }

	public void Reconnect() { }

}

