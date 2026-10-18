namespace EFT.Communications;

public sealed class NotificationRemovedFromIgnoreList : Notification
{
	[JsonProperty("profile")]
	public UpdatableChatMember Profile; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 252
	}

	public NotificationRemovedFromIgnoreList() { }

	public virtual string get_Description() { }

}

