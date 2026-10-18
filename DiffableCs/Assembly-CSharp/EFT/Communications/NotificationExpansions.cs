namespace EFT.Communications;

public sealed class NotificationExpansions : Notification
{
	[CompilerGenerated]
	private readonly ExpansionsShopNotificationData <ShopData>k__BackingField; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 7
	}

	public ExpansionsShopNotificationData ShopData
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public virtual bool ShowImmediately
	{
		 get { } //Length: 3
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 168
	}

	public NotificationExpansions(ExpansionsShopNotificationData shopData) { }

	public virtual BaseNotificationView CreateView(INotificationViewFactory viewFactory) { }

	public virtual string get_Description() { }

	[CompilerGenerated]
	public ExpansionsShopNotificationData get_ShopData() { }

	public virtual bool get_ShowImmediately() { }

	public virtual bool get_ShowNotification() { }

}

