namespace EFT.Communications;

public sealed class NotificationInGameUnBan : Notification
{
	[JsonProperty("banType")]
	public EBanType BanType; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 416
	}

	public NotificationInGameUnBan() { }

	public virtual string get_Description() { }

}

