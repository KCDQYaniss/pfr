namespace EFT.Communications;

public sealed class NotificationRagfairEventRating : ProfileChangeEventNotification
{

	public NotificationRagfairEventRating() { }

	protected virtual void ApplySingleChange(IEftSession session, string _, Nullable newRating) { }

}

