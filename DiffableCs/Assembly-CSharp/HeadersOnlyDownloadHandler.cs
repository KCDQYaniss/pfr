//Type is in global namespace

public sealed class HeadersOnlyDownloadHandler : DownloadHandlerScript
{

	public HeadersOnlyDownloadHandler() { }

	protected virtual bool ReceiveData(byte[] data, int dataLength) { }

}

