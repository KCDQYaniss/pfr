namespace Comfort.Communication.Core;

public sealed class ProxyFactory : MulticastDelegate
{

	public ProxyFactory(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(ref CommunicationId id, bool unreliable, byte offset, IPipe pipe, AsyncCallback callback, object object) { }

	public override object EndInvoke(ref CommunicationId id, IAsyncResult result) { }

	public override object Invoke(ref CommunicationId id, bool unreliable, byte offset, IPipe pipe) { }

}

