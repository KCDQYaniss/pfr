namespace EFT.Communications;

public sealed class NotificationLeaderChanged : Notification
{
	[JsonProperty("owner")]
	public string OwnerAid; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 153
	}

	public NotificationLeaderChanged() { }

	public virtual string get_Description() { }

}

