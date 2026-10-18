namespace EFT.Communications;

public sealed class NotificationTraderStanding : NotificationTraderLoyalty
{

	public NotificationTraderStanding() { }

	protected virtual void ApplySingleChange(IEftSession session, string traderId, Nullable standing) { }

}

