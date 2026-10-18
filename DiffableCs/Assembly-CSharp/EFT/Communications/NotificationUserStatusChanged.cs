namespace EFT.Communications;

public sealed class NotificationUserStatusChanged : Notification
{
	public ProfileStatus Status; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 59
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationUserStatusChanged() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

