namespace EFT.Communications;

public sealed class NotificationTraderSalesSum : NotificationTraderLoyalty
{

	public NotificationTraderSalesSum() { }

	protected virtual void ApplySingleChange(IEftSession session, string traderId, Nullable salesSum) { }

}

