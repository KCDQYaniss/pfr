namespace EFT.Communications;

public abstract class NotificationRagFair : Notification
{

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 6
	}

	protected NotificationRagFair() { }

	public virtual ENotificationIconType get_Icon() { }

}

