namespace EFT.Communications;

public sealed class NotificationGroupMatchRaidReady : Notification
{
	[JsonProperty("extendedProfile")]
	public GroupPlayer GroupPlayer; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 59
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationGroupMatchRaidReady() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

