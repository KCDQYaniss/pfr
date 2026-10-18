namespace EFT.Communications;

public sealed class NotificationInviteCanceled : Notification
{
	[JsonProperty("aid")]
	public string PlayerAid; //Field offset: 0x30
	[JsonProperty("nickname")]
	public string Nickname; //Field offset: 0x38

	public virtual string Description
	{
		 get { } //Length: 237
	}

	public NotificationInviteCanceled() { }

	public virtual string get_Description() { }

}

