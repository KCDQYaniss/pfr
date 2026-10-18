namespace EFT.Communications;

public abstract class NotificationFriendsRequest : Notification
{
	private UpdatableChatMember _profile; //Field offset: 0x30
	private bool _showNotification; //Field offset: 0x38

	[JsonProperty("profile")]
	public UpdatableChatMember Profile
	{
		 get { } //Length: 76
		 set { } //Length: 221
	}

	protected abstract HashSet RequestsCache
	{
		 get { } //Length: 0
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 5
	}

	protected NotificationFriendsRequest() { }

	public UpdatableChatMember get_Profile() { }

	protected abstract HashSet get_RequestsCache() { }

	public virtual bool get_ShowNotification() { }

	public void set_Profile(UpdatableChatMember value) { }

}

