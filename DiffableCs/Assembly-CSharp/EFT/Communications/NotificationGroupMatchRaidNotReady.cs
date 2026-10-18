namespace EFT.Communications;

public sealed class NotificationGroupMatchRaidNotReady : Notification
{
	[JsonProperty("aid")]
	public string PlayerAid; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 59
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationGroupMatchRaidNotReady() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

