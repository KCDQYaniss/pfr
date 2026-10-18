namespace Diz.Jobs;

public sealed class YieldDelegate : MulticastDelegate
{

	public YieldDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(JobYield jobYield, AsyncCallback callback, object object) { }

	public override IJobAwaitable EndInvoke(IAsyncResult result) { }

	public override IJobAwaitable Invoke(JobYield jobYield = null) { }

}

