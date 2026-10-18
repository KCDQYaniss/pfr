//Type is in global namespace

public class ResponseData : IDisposable
{
	public int responseCode; //Field offset: 0x10
	public Dictionary responseHeaders; //Field offset: 0x18
	public byte[] responseData; //Field offset: 0x20
	public int responseDataLength; //Field offset: 0x28
	public string responseText; //Field offset: 0x30
	public Stopwatch stopwatch; //Field offset: 0x38
	public string errorText; //Field offset: 0x40

	public ResponseData(int code, string error, Dictionary headers, byte[] data, int dataLength, string textResponse, Stopwatch watch) { }

	public ResponseData(string error, int code = 0) { }

	public override void Dispose() { }

}

