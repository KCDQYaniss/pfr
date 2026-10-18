namespace EFT.Communications;

public sealed class NotificationRagfairPurchased : NotificationRagFair
{
	private const string MULTI_PURCHASES_NOTIFICATION_FORMAT = "You’ve purchased ({0}) offers. Check your stash!"; //Field offset: 0x0
	private const string SINGLE_PURCHASE_NOTIFICATION_FORMAT = "ragfair/You’ve purchased the offer ({0}). Check your stash!"; //Field offset: 0x0
	private const string WISHLIST_PURCHASE_NOTIFICATION_FORMAT = "Wishlist/Notify/Purchase{0}"; //Field offset: 0x0
	private readonly CommoditiesToPurchase _purchases; //Field offset: 0x30
	private readonly Nullable _wishlistGroup; //Field offset: 0x38

	public virtual string Description
	{
		 get { } //Length: 599
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 204
	}

	public NotificationRagfairPurchased(CommoditiesToPurchase purchases, Nullable wishlistGroup) { }

	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

}

