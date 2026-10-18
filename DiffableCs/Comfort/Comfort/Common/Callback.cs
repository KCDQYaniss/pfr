namespace Comfort.Common;

public sealed class Callback : MulticastDelegate
{

	public Callback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(IResult result, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(IResult result) { }

}

