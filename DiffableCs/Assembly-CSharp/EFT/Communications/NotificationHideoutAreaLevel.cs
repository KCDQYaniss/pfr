namespace EFT.Communications;

public sealed class NotificationHideoutAreaLevel : ProfileChangeEventNotification
{

	public virtual ENotificationRequirements Requirement
	{
		 get { } //Length: 6
	}

	public NotificationHideoutAreaLevel() { }

	protected virtual void ApplySingleChange(IEftSession session, string areaName, Nullable areaLevel) { }

	public virtual ENotificationRequirements get_Requirement() { }

}

