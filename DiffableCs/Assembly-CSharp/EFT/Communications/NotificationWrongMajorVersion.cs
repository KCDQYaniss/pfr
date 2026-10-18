namespace EFT.Communications;

public sealed class NotificationWrongMajorVersion : Notification
{
	[JsonProperty("groupId")]
	public string GroupId; //Field offset: 0x30
	[JsonProperty("uid")]
	public string PlayerId; //Field offset: 0x38
	[JsonProperty("Nickname")]
	public string Name; //Field offset: 0x40

	public virtual string Description
	{
		 get { } //Length: 59
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationWrongMajorVersion() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

