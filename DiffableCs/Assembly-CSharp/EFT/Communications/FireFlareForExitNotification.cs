namespace EFT.Communications;

public class FireFlareForExitNotification : Notification
{

	public virtual string Description
	{
		 get { } //Length: 153
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 6
	}

	public FireFlareForExitNotification() { }

	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

	public void Hide() { }

}

