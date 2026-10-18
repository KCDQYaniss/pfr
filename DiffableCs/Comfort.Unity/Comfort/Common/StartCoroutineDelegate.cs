namespace Comfort.Common;

public sealed class StartCoroutineDelegate : MulticastDelegate
{

	public StartCoroutineDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(IEnumerator routine, AsyncCallback callback, object object) { }

	public override Coroutine EndInvoke(IAsyncResult result) { }

	public override Coroutine Invoke(IEnumerator routine) { }

}

