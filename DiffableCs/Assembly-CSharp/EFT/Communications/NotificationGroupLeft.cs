namespace EFT.Communications;

public sealed class NotificationGroupLeft : Notification
{
	[JsonProperty("aid")]
	public string PlayerAid; //Field offset: 0x30
	[JsonProperty("Nickname")]
	public string Name; //Field offset: 0x38

	public virtual string Description
	{
		 get { } //Length: 396
	}

	public NotificationGroupLeft() { }

	public virtual string get_Description() { }

}

