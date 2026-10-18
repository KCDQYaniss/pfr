namespace Vuplex.WebView;

public class FileSelectionEventArgs : EventArgs
{
	public readonly string[] AcceptFilters; //Field offset: 0x10
	public readonly bool MultipleAllowed; //Field offset: 0x18
	public readonly Action Continue; //Field offset: 0x20
	public readonly Action Cancel; //Field offset: 0x28

	public FileSelectionEventArgs(string[] acceptFilters, bool multipleAllowed, Action continueCallback, Action cancelCallback) { }

}

