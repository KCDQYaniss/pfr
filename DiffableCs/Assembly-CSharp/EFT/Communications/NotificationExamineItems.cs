namespace EFT.Communications;

public sealed class NotificationExamineItems : ProfileChangeEventNotification
{

	public virtual ENotificationRequirements Requirement
	{
		 get { } //Length: 6
	}

	public NotificationExamineItems() { }

	protected virtual void ApplySingleChange(IEftSession session, string templateId, Nullable status) { }

	public virtual ENotificationRequirements get_Requirement() { }

}

