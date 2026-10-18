namespace EFT.Communications;

internal sealed class NotificationMessageProcessor
{
	internal enum EProcessError
	{
		None = 0,
		ParseError = 1,
		ChannelDeleted = 2,
		NotificationCreateFailed = 3,
	}

	private const char MESSAGES_DELIMITER = '\uA'; //Field offset: 0x0
	private const string DEFAULT_CHANNEL_DELETED_MESSAGE = "channel deleted"; //Field offset: 0x0
	private static readonly ENotificationType[] _serviceNotifications; //Field offset: 0x0
	private static readonly ENotificationType[] _beforeProfileNotifications; //Field offset: 0x8
	private readonly NotificationInbox _inbox; //Field offset: 0x10

	private static NotificationMessageProcessor() { }

	public NotificationMessageProcessor(NotificationInbox inbox) { }

	public void ProcessBatch(string[] messages, Action onProcessed, bool hasProfile, Nullable notificationType = null, string eventId = null) { }

	public NotificationProcessResult ProcessMessage(string message, bool hasProfile, Nullable notificationType = null, string eventId = null) { }

	public void ProcessPayload(byte[] bytes, Action onProcessed, bool hasProfile) { }

}

