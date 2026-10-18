namespace Vuplex.WebView;

public class ScriptDialogEventArgs : EventArgs
{
	public readonly string Message; //Field offset: 0x10
	public readonly Action Continue; //Field offset: 0x18

	public ScriptDialogEventArgs(string message, Action continueCallback) { }

}

