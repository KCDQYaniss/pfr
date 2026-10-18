namespace EFT.Communications;

public sealed class NotificationTournamentWarning : Notification
{
	[JsonProperty("message")]
	public string Message; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 76
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationTournamentWarning() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

