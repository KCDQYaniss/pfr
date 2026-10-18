namespace EFT;

public static class TransitAbuseUtil
{
	public const string KEY = "scJoosLZvl"; //Field offset: 0x0
	public static bool LeaveInTransactionFlag; //Field offset: 0x0

	public static bool CanUsePunishFlag(TarkovApplication app, IEftSession session) { }

	public static void ClearPunishFlag() { }

	public static void SetPunishFlag(TransitionStatus status) { }

	public static bool TryGetPunishFlag(out TransitionStatus transitionInfo) { }

}

