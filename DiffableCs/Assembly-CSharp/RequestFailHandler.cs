//Type is in global namespace

public sealed class RequestFailHandler : MulticastDelegate
{

	public RequestFailHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(int code, string error, bool abortOnFail, AsyncCallback callback, object object) { }

	public override ERequestErrorHandlingResult EndInvoke(IAsyncResult result) { }

	public override ERequestErrorHandlingResult Invoke(int code, string error, bool abortOnFail) { }

}

