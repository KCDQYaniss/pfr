namespace EFT.Communications;

public sealed class NotificationExamineAllItems : ProfileChangeEventNotification
{

	public virtual string Description
	{
		 get { } //Length: 80
	}

	public virtual ENotificationRequirements Requirement
	{
		 get { } //Length: 6
	}

	public NotificationExamineAllItems() { }

	protected virtual void ApplySingleChange(IEftSession session, string _, Nullable __) { }

	public virtual string get_Description() { }

	public virtual ENotificationRequirements get_Requirement() { }

}

