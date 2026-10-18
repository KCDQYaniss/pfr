namespace Comfort.Net;

public enum ErrorCode
{
	None = 0,
	Disconnected = 1,
	Destroyed = 2,
	ClosedByServer = 3,
	WrongVersion = 4,
	CacheMiss = 5,
	Timeout = 6,
	BadPacket = 7,
}

