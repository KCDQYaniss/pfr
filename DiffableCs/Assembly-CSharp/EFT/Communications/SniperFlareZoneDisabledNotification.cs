namespace EFT.Communications;

public sealed class SniperFlareZoneDisabledNotification : FireFlareForExitNotification
{

	public virtual string Description
	{
		 get { } //Length: 153
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 3
	}

	public SniperFlareZoneDisabledNotification() { }

	public virtual string get_Description() { }

	public virtual ENotificationIconType get_Icon() { }

	public void Hide() { }

}

