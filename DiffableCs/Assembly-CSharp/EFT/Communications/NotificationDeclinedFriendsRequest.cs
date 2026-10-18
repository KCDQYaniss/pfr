namespace EFT.Communications;

public sealed class NotificationDeclinedFriendsRequest : Notification
{
	[JsonProperty("profile")]
	public UpdatableChatMember Profile; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 252
	}

	public NotificationDeclinedFriendsRequest() { }

	public virtual string get_Description() { }

}

