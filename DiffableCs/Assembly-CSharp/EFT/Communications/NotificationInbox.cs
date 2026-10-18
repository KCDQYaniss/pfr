namespace EFT.Communications;

internal sealed class NotificationInbox
{
	private const int MAX_MESSAGES_COUNT = 100; //Field offset: 0x0
	public readonly List ProfileChangeNotifications; //Field offset: 0x10
	public readonly List Notifications; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnNotificationReceived; //Field offset: 0x20

	public event Action OnNotificationReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public NotificationInbox() { }

	public void Add(Notification notification) { }

	[CompilerGenerated]
	public void add_OnNotificationReceived(Action value) { }

	[CompilerGenerated]
	public void remove_OnNotificationReceived(Action value) { }

}

