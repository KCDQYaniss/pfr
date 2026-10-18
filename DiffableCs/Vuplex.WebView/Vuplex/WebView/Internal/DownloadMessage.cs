namespace Vuplex.WebView.Internal;

public class DownloadMessage
{
	public string ContentType; //Field offset: 0x10
	public string FilePath; //Field offset: 0x18
	public string Id; //Field offset: 0x20
	public float Progress; //Field offset: 0x28
	public int Type; //Field offset: 0x2C
	public string Url; //Field offset: 0x30

	public DownloadMessage() { }

	public static DownloadMessage FromJson(string json) { }

	public DownloadChangedEventArgs ToEventArgs() { }

}

