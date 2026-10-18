namespace EFT.Communications;

public sealed class NotificationMasteringPointsDelta : ProfileChangeEventNotification
{

	public NotificationMasteringPointsDelta() { }

	protected virtual void ApplySingleChange(IEftSession session, string masteringGroup, Nullable masteringPointsDelta) { }

}

