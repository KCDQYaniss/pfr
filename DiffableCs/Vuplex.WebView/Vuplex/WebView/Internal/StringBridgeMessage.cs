namespace Vuplex.WebView.Internal;

internal class StringBridgeMessage : BridgeMessage
{
	public string value; //Field offset: 0x18

	public StringBridgeMessage() { }

	public static string ParseValue(string serializedMessage) { }

}

