namespace EFT.Communications;

public sealed class NotificationTraderStandingDelta : NotificationTraderLoyalty
{

	public NotificationTraderStandingDelta() { }

	protected virtual void ApplySingleChange(IEftSession session, string traderId, Nullable standingDelta) { }

}

