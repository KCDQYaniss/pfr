namespace EFT.Communications;

public sealed class NotificationFriendRequestCanceled : NotificationFriendsRequest
{
	private static readonly HashSet _requestsCache; //Field offset: 0x0

	public virtual string Description
	{
		 get { } //Length: 305
	}

	protected virtual HashSet RequestsCache
	{
		 get { } //Length: 83
	}

	private static NotificationFriendRequestCanceled() { }

	public NotificationFriendRequestCanceled() { }

	public virtual string get_Description() { }

	protected virtual HashSet get_RequestsCache() { }

}

