namespace EFT.Communications;

public sealed class HideoutItemNotification : HideoutAreaNotification
{
	public const string WISHLIST_NOTIFICATION = "Wishlist/Notify/Default{0}"; //Field offset: 0x0
	[JsonProperty("templateId")]
	public string TemplateId; //Field offset: 0x58
	private Nullable _wishlistGroup; //Field offset: 0x60

	public virtual string Description
	{
		 get { } //Length: 571
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 222
	}

	public HideoutItemNotification(EHideoutNotificationType eventType, AreaTemplate areaTemplate, string templateId, Nullable wishlistGroup, Action onClick) { }

	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

}

