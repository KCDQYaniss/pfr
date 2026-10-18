namespace Steamworks;

public static class SteamEncryptedAppTicket
{

	public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey) { }

	public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	public static bool BIsTicketSigned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, byte[] pubRSAKey, uint cubRSAKey) { }

	public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID) { }

	public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData) { }

}

