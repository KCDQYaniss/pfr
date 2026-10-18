//Type is in global namespace

internal interface ISender
{

	public Task WaitResponse(string url, byte[] data, Dictionary headers, int timeoutSeconds, string method = "POST", bool headersOnly = false) { }

}

