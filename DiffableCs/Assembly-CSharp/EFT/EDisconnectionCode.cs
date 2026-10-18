namespace EFT;

public enum EDisconnectionCode
{
	Unknown = 0,
	SABER_ANTICHEAT_AnticheatConnectionFailed = 1,
	BATTLEYE_ANTICHEAT_ClientNotResponding = 2,
	BATTLEYE_ANTICHEAT_QueryTimeout = 3,
	BATTLEYE_ANTICHEAT_GameRestartRequired = 4,
	BATTLEYE_ANTICHEAT_BadServiceVersion = 5,
	BATTLEYE_ANTICHEAT_DisallowedProgram = 6,
	BATTLEYE_ANTICHEAT_CorruptedMemory = 7,
	BATTLEYE_ANTICHEAT_CorruptedData = 8,
	BATTLEYE_ANTICHEAT_WinAPIFailure = 9,
	BATTLEYE_ANTICHEAT_GlobalBan = 10,
	BAD_RTT = 11,
	HIGH_PACKETS_LOSS = 12,
	TIME_MISMATCH = 13,
}

