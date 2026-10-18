namespace EFT.Communications;

public sealed class NotificationMatchRaidSettings : Notification
{
	[JsonProperty("raidSettings")]
	public RaidSettings RaidSettings; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 59
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationMatchRaidSettings() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

