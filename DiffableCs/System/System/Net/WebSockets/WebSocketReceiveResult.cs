namespace System.Net.WebSockets;

public class WebSocketReceiveResult
{
	[CompilerGenerated]
	private readonly int <Count>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <EndOfMessage>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly WebSocketMessageType <MessageType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Nullable <CloseStatus>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly string <CloseStatusDescription>k__BackingField; //Field offset: 0x28

	public int Count
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public bool EndOfMessage
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public WebSocketMessageType MessageType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage) { }

	public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage, Nullable closeStatus, string closeStatusDescription) { }

	[CompilerGenerated]
	public int get_Count() { }

	[CompilerGenerated]
	public bool get_EndOfMessage() { }

	[CompilerGenerated]
	public WebSocketMessageType get_MessageType() { }

}

