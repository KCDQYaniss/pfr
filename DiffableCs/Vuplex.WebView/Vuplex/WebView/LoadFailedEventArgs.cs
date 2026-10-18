namespace Vuplex.WebView;

public class LoadFailedEventArgs : EventArgs
{
	public readonly string NativeErrorCode; //Field offset: 0x10
	public readonly string Url; //Field offset: 0x18

	public LoadFailedEventArgs(string nativeErrorCode, string url) { }

	public virtual string ToString() { }

}

