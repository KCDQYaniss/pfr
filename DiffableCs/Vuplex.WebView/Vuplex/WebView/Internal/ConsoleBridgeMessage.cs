namespace Vuplex.WebView.Internal;

internal class ConsoleBridgeMessage : BridgeMessage
{
	public string message; //Field offset: 0x18
	public string level; //Field offset: 0x20
	public string source; //Field offset: 0x28
	public int line; //Field offset: 0x30

	private ConsoleMessageLevel _parseMessageLevel(string levelString) { }

	public ConsoleBridgeMessage() { }

	public ConsoleMessageEventArgs ToEventArgs() { }

}

