namespace Comfort.Net;

public class StatusChangedEventArgs : EventArgs
{
	public readonly ErrorCode ErrorCode; //Field offset: 0x10
	public readonly Status Status; //Field offset: 0x14
	public readonly Status StatusOld; //Field offset: 0x18

	public StatusChangedEventArgs(ErrorCode errorCode, Status status, Status statusOld) { }

}

