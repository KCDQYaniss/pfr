namespace FlyingWormConsole3.LiteNetLib;

[Flags]
public enum ConnectionState
{
	Outgoing = 2,
	Connected = 4,
	ShutdownRequested = 8,
	Disconnected = 16,
	Any = 14,
}

