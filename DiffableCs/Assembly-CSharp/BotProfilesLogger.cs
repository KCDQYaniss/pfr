//Type is in global namespace

public sealed class BotProfilesLogger : AbstractLogger
{
	private static BotProfilesLogger _instance; //Field offset: 0x0

	public static BotProfilesLogger Instance
	{
		 get { } //Length: 311
	}

	private BotProfilesLogger() { }

	public static BotProfilesLogger get_Instance() { }

	internal void ProfileAdded(Profile profile) { }

	internal void ProfileAddedFromBackend(Profile profile) { }

}

