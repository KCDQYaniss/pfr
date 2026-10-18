namespace Vuplex.WebView;

public interface IWithFallbackVideo
{

	public event EventHandler VideoRectChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public Texture2D VideoTexture
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_VideoRectChanged(EventHandler value) { }

	public Texture2D get_VideoTexture() { }

	[CompilerGenerated]
	public void remove_VideoRectChanged(EventHandler value) { }

	public void SetFallbackVideoEnabled(bool enabled) { }

}

