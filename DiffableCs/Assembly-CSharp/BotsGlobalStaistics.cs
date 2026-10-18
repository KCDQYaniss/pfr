//Type is in global namespace

public static class BotsGlobalStaistics
{
	private static readonly List _botPersonalStats; //Field offset: 0x0
	private static bool enable; //Field offset: 0x8
	private static readonly BotMapStats _mapStats; //Field offset: 0x10
	private static readonly BotsProfilesAskingStats _profilesAsking; //Field offset: 0x18

	private static BotsGlobalStaistics() { }

	public static void AddBot(BotPersonalStats stat) { }

	public static void AddPlayer() { }

	private static List AllData() { }

	public static void AskBackendBotProfiles(List data, EProfilesAskingStat onStart) { }

	public static void DeadPlayer() { }

	public static void Enable(bool val = true) { }

	public static void SendCurrentStats(bool withDispose) { }

	internal static void UseProfile(Profile profile) { }

	public static void WritetoFile() { }

}

