namespace EFT.Communications;

public abstract class NotificationTraderLoyalty : ProfileChangeEventNotification
{

	protected NotificationTraderLoyalty() { }

	protected virtual void ApplySingleChange(IEftSession session, string traderId, Nullable _) { }

}

