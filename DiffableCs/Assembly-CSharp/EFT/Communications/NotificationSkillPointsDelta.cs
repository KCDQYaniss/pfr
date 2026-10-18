namespace EFT.Communications;

public sealed class NotificationSkillPointsDelta : ProfileChangeEventNotification
{

	public NotificationSkillPointsDelta() { }

	protected virtual void ApplySingleChange(IEftSession session, string skillName, Nullable skillPointsDelta) { }

}

