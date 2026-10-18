namespace EFT.Communications;

public sealed class NotificationAchievement : NotificationWithText
{
	public EAchievementRarity Rarity; //Field offset: 0x38
	public Sprite Sprite; //Field offset: 0x40

	public virtual Nullable BackgroundColor
	{
		 get { } //Length: 170
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 6
	}

	public virtual bool ShowImmediately
	{
		 get { } //Length: 3
	}

	public NotificationAchievement() { }

	public virtual BaseNotificationView CreateView(INotificationViewFactory viewFactory) { }

	public virtual Nullable get_BackgroundColor() { }

	public virtual ENotificationIconType get_Icon() { }

	public virtual bool get_ShowImmediately() { }

}

