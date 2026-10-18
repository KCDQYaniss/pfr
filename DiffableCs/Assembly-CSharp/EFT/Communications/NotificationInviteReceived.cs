namespace EFT.Communications;

public sealed class NotificationInviteReceived : Notification
{
	[JsonProperty("requestId")]
	public string RequestId; //Field offset: 0x30
	[JsonProperty("from")]
	public string Aid; //Field offset: 0x38
	[JsonProperty("members")]
	public GroupPlayer[] Members; //Field offset: 0x40

	public virtual string Description
	{
		 get { } //Length: 59
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationInviteReceived() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

