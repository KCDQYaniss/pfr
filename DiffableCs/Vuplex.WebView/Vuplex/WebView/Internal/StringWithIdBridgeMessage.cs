namespace Vuplex.WebView.Internal;

public class StringWithIdBridgeMessage : BridgeMessage
{
	public string id; //Field offset: 0x18
	public string value; //Field offset: 0x20

	public StringWithIdBridgeMessage() { }

}

