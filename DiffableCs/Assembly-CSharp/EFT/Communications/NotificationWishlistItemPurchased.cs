namespace EFT.Communications;

public sealed class NotificationWishlistItemPurchased : Notification
{
	private const string WISHLIST_PURCHASE_NOTIFICATION_FORMAT = "Wishlist/Notify/Purchase{0}"; //Field offset: 0x0
	private readonly EWishlistGroup _groupType; //Field offset: 0x30
	private readonly Item _item; //Field offset: 0x38

	public virtual string Description
	{
		 get { } //Length: 338
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 153
	}

	public NotificationWishlistItemPurchased(Item item, EWishlistGroup groupType) { }

	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

}

