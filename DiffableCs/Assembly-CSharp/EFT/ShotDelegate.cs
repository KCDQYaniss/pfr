namespace EFT;

public sealed class ShotDelegate : MulticastDelegate
{

	public ShotDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(Shot shotResults, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(Shot shotResults) { }

}

