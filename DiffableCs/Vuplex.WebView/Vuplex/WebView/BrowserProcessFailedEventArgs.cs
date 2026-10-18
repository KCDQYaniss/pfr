namespace Vuplex.WebView;

public class BrowserProcessFailedEventArgs : EventArgs
{
	public readonly string ErrorMessage; //Field offset: 0x10

	public BrowserProcessFailedEventArgs(string errorMessage) { }

	public virtual string ToString() { }

}

