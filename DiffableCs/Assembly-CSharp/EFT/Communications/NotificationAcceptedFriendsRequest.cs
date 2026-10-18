namespace EFT.Communications;

public sealed class NotificationAcceptedFriendsRequest : Notification
{
	[JsonProperty("profile")]
	public UpdatableChatMember ChatMember; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 252
	}

	public NotificationAcceptedFriendsRequest() { }

	public virtual string get_Description() { }

}

