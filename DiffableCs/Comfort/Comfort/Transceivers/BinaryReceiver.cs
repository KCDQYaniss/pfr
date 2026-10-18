namespace Comfort.Transceivers;

public sealed class BinaryReceiver : MulticastDelegate
{

	public BinaryReceiver(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(BinaryReader reader, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(BinaryReader reader) { }

}

