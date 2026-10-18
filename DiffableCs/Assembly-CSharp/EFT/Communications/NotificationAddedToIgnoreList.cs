namespace EFT.Communications;

public sealed class NotificationAddedToIgnoreList : Notification
{
	[JsonProperty("profile")]
	public UpdatableChatMember Profile; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 252
	}

	public NotificationAddedToIgnoreList() { }

	public virtual string get_Description() { }

}

