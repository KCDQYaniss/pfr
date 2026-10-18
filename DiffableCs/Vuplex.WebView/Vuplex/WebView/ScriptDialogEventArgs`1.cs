namespace Vuplex.WebView;

public class ScriptDialogEventArgs`1 : EventArgs
{
	public readonly string Message; //Field offset: 0x0
	public readonly Action Continue; //Field offset: 0x0

	public ScriptDialogEventArgs`1(string message, Action continueCallback) { }

}

