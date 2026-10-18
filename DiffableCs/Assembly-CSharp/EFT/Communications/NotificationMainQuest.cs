namespace EFT.Communications;

public sealed class NotificationMainQuest : NotificationWithText
{
	public string Title; //Field offset: 0x38
	public Sprite Sprite; //Field offset: 0x40
	public bool IsChapter; //Field offset: 0x48
	public EMainQuestNotificationProgressStatus Status; //Field offset: 0x4C

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 6
	}

	public virtual bool ShowImmediately
	{
		 get { } //Length: 3
	}

	public NotificationMainQuest() { }

	public virtual BaseNotificationView CreateView(INotificationViewFactory viewFactory) { }

	public virtual ENotificationIconType get_Icon() { }

	public virtual bool get_ShowImmediately() { }

}

