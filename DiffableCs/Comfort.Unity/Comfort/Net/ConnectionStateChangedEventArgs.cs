namespace Comfort.Net;

public class ConnectionStateChangedEventArgs : EventArgs
{
	public readonly ConnectionState State; //Field offset: 0x10
	public readonly ErrorCode ErrorCode; //Field offset: 0x14

	public ConnectionStateChangedEventArgs(ConnectionState state, ErrorCode errorCode) { }

}

