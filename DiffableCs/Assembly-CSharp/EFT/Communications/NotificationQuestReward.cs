namespace EFT.Communications;

public sealed class NotificationQuestReward : NotificationWithText
{
	public string Title; //Field offset: 0x38
	public Sprite Sprite; //Field offset: 0x40

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 6
	}

	public virtual bool ShowImmediately
	{
		 get { } //Length: 3
	}

	public NotificationQuestReward() { }

	public virtual BaseNotificationView CreateView(INotificationViewFactory viewFactory) { }

	public virtual ENotificationIconType get_Icon() { }

	public virtual bool get_ShowImmediately() { }

}

