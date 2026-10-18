namespace EFT.Communications;

public sealed class NotificationYouWasKickedFromDialogue : Notification
{
	[JsonProperty("groupId")]
	public string GroupId; //Field offset: 0x30
	[JsonProperty("groupName")]
	public string GroupName; //Field offset: 0x38

	public virtual string Description
	{
		 get { } //Length: 237
	}

	public NotificationYouWasKickedFromDialogue() { }

	public virtual string get_Description() { }

}

