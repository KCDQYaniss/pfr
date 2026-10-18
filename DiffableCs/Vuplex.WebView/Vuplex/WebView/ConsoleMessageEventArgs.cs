namespace Vuplex.WebView;

public class ConsoleMessageEventArgs : EventArgs
{
	public readonly ConsoleMessageLevel Level; //Field offset: 0x10
	public readonly string Message; //Field offset: 0x18
	public readonly string Source; //Field offset: 0x20
	public readonly int Line; //Field offset: 0x28

	public ConsoleMessageEventArgs(ConsoleMessageLevel level, string message, string source, int line) { }

}

