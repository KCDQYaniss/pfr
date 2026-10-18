//Type is in global namespace

public class JsonWebClient : WebClient
{
	public int Timeout; //Field offset: 0x98
	public bool ZipTraffic; //Field offset: 0x9C

	public JsonWebClient() { }

	public string DownloadString(string address) { }

	protected virtual WebRequest GetWebRequest(Uri address) { }

	public T ParseDataFromJson(string json) { }

	public int ParseErrorCodeFromJson(string json) { }

	public string UploadString(string address, string data, string method = "POST") { }

}

