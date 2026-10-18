namespace EFT.Communications;

public static class Notifications
{

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private static AbstractLogger get_Logger() { }

	[CanBeNull]
	public static Notification ParseNotificationByType(ENotificationType type, UnparsedData data) { }

}

