namespace Vuplex.WebView;

public interface IWithPopups
{

	public event EventHandler PopupRequested
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_PopupRequested(EventHandler value) { }

	[CompilerGenerated]
	public void remove_PopupRequested(EventHandler value) { }

	public void SetPopupMode(PopupMode popupMode) { }

}

