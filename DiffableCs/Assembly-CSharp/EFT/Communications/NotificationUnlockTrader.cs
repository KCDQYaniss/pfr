namespace EFT.Communications;

public sealed class NotificationUnlockTrader : ProfileChangeEventNotification
{

	public virtual ENotificationRequirements Requirement
	{
		 get { } //Length: 3
	}

	public NotificationUnlockTrader() { }

	protected virtual void ApplySingleChange(IEftSession session, string traderId, Nullable status) { }

	public virtual ENotificationRequirements get_Requirement() { }

}

