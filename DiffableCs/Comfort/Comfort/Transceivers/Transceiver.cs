namespace Comfort.Transceivers;

public sealed class Transceiver : MulticastDelegate
{

	public Transceiver(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(ref ArraySegment segment, AsyncCallback callback, object object) { }

	public override int EndInvoke(ref ArraySegment segment, IAsyncResult result) { }

	public override int Invoke(ref ArraySegment segment) { }

}

