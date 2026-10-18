namespace EFT.Communications;

public sealed class NotificationMasteringPoints : ProfileChangeEventNotification
{

	public NotificationMasteringPoints() { }

	protected virtual void ApplySingleChange(IEftSession session, string masteringGroup, Nullable masteringPoints) { }

}

