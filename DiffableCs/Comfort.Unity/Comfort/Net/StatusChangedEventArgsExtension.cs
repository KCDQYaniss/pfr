namespace Comfort.Net;

[Extension]
public static class StatusChangedEventArgsExtension
{
	public static readonly ErrorCode[] ConnectAllowedCodes; //Field offset: 0x0
	public static readonly ErrorCode[] ReconnectAllowedCodes; //Field offset: 0x8
	public static readonly ErrorCode[] DisconnectedCodes; //Field offset: 0x10

	private static StatusChangedEventArgsExtension() { }

	[Extension]
	public static bool IsConnectAllowed(IPeer peer) { }

	[Extension]
	public static bool IsConnectedEvent(StatusChangedEventArgs args) { }

	[Extension]
	public static bool IsContain(Status[] statuses, Status status) { }

	[Extension]
	public static bool IsContain(ErrorCode[] codes, ErrorCode error) { }

	[Extension]
	public static bool IsDisconnectedErrorCode(ErrorCode errorCode) { }

	[Extension]
	public static bool IsReconnectAllowed(IPeer peer) { }

	[Extension]
	public static bool IsReconnectedEvent(StatusChangedEventArgs args) { }

	[Extension]
	public static bool IsReconnectingEvent(StatusChangedEventArgs args) { }

	[Extension]
	public static bool IsReconnectingFailedEvent(StatusChangedEventArgs args) { }

	[Extension]
	public static bool IsReconnectingTimeoutEvent(StatusChangedEventArgs args) { }

}

