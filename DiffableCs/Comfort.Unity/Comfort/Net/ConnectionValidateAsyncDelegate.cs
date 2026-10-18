namespace Comfort.Net;

public sealed class ConnectionValidateAsyncDelegate : MulticastDelegate
{

	public ConnectionValidateAsyncDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(string clientId, string versionId, IPEndPoint endPoint, IValidator validator, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(string clientId, string versionId, IPEndPoint endPoint, IValidator validator) { }

}

