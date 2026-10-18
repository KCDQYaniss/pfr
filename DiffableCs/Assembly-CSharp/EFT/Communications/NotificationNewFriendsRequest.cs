namespace EFT.Communications;

public sealed class NotificationNewFriendsRequest : NotificationFriendsRequest
{
	private static readonly HashSet _requestsCache; //Field offset: 0x0
	[JsonProperty("_id")]
	public string Id; //Field offset: 0x40

	public virtual string Description
	{
		 get { } //Length: 305
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 6
	}

	protected virtual HashSet RequestsCache
	{
		 get { } //Length: 83
	}

	private static NotificationNewFriendsRequest() { }

	public NotificationNewFriendsRequest() { }

	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

	protected virtual HashSet get_RequestsCache() { }

}

