namespace EFT.Communications;

public sealed class BufferGateNotAvailableNotification : Notification
{

	public virtual string Description
	{
		 get { } //Length: 153
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 6
	}

	public BufferGateNotAvailableNotification() { }

	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

}

