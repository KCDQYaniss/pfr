namespace EFT.Communications;

public sealed class NotificationSkillPoints : ProfileChangeEventNotification
{

	public NotificationSkillPoints() { }

	protected virtual void ApplySingleChange(IEftSession session, string skillName, Nullable skillPoints) { }

}

