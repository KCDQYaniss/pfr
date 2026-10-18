namespace EFT.NetworkPackets;

public enum SyncPositionReason
{
	Speed = 0,
	Stuck = 1,
	Lift = 2,
	PacketsQueue = 3,
	NanInfinity = 4,
}

