namespace Comfort.Net;

public sealed class ConnectionValidateDelegate : MulticastDelegate
{

	public ConnectionValidateDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(string clientId, string versionId, IPEndPoint endPoint, out ConnectionAcceptor acceptor, AsyncCallback callback, object object) { }

	public override bool EndInvoke(out ConnectionAcceptor acceptor, IAsyncResult result) { }

	public override bool Invoke(string clientId, string versionId, IPEndPoint endPoint, out ConnectionAcceptor acceptor) { }

}

