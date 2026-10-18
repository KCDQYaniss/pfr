namespace EFT.Communications;

public sealed class NotificationInGameBan : Notification
{
	[JsonProperty("banType")]
	public EBanType BanType; //Field offset: 0x30
	[JsonProperty("dateTime")]
	public long DateTime; //Field offset: 0x38

	public virtual string Description
	{
		 get { } //Length: 416
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 6
	}

	public NotificationInGameBan() { }

	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

}

