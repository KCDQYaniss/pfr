namespace EFT.Communications;

public sealed class NotificationCustomizationUpdateRequired : Notification
{

	public virtual string Description
	{
		 get { } //Length: 153
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationCustomizationUpdateRequired() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

