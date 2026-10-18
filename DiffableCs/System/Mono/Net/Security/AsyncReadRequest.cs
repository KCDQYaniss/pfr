namespace Mono.Net.Security;

internal class AsyncReadRequest : AsyncReadOrWriteRequest
{

	public AsyncReadRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

