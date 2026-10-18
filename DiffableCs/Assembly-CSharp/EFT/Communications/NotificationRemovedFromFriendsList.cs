namespace EFT.Communications;

public sealed class NotificationRemovedFromFriendsList : Notification
{
	[JsonProperty("profile")]
	public UpdatableChatMember ChatMember; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 252
	}

	public NotificationRemovedFromFriendsList() { }

	public virtual string get_Description() { }

}

