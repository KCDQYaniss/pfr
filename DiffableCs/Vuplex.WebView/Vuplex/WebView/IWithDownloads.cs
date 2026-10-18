namespace Vuplex.WebView;

public interface IWithDownloads
{

	public event EventHandler DownloadProgressChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_DownloadProgressChanged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_DownloadProgressChanged(EventHandler value) { }

	public void SetDownloadsEnabled(bool enabled) { }

}

