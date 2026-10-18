namespace Vuplex.WebView;

public class DownloadChangedEventArgs : EventArgs
{
	public readonly string ContentType; //Field offset: 0x10
	public readonly string FilePath; //Field offset: 0x18
	public readonly string Id; //Field offset: 0x20
	public readonly float Progress; //Field offset: 0x28
	public readonly ProgressChangeType Type; //Field offset: 0x2C
	public readonly string Url; //Field offset: 0x30

	public DownloadChangedEventArgs(string contentType, string filePath, string id, float progress, ProgressChangeType type, string url) { }

}

