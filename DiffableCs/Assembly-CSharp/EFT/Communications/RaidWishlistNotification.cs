namespace EFT.Communications;

public sealed class RaidWishlistNotification : Notification
{
	public const string WISHLIST_NOTIFICATION = "Wishlist/Notify/Default{0}"; //Field offset: 0x0
	private string _templateId; //Field offset: 0x30
	private EWishlistGroup _wishlistGroup; //Field offset: 0x38

	public virtual string Description
	{
		 get { } //Length: 322
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 153
	}

	public RaidWishlistNotification(string templateId, EWishlistGroup wishlistGroup) { }

	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

}

