namespace EFT.Communications;

public sealed class NotificationChatMessageReceived : Notification
{
	[JsonProperty("dialogId")]
	public string DialogueId; //Field offset: 0x30
	[JsonProperty("message")]
	public DialogueChatMessage Message; //Field offset: 0x38
	[JsonProperty("EventId")]
	public string EventId; //Field offset: 0x40

	public virtual string Description
	{
		 get { } //Length: 59
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationChatMessageReceived() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

