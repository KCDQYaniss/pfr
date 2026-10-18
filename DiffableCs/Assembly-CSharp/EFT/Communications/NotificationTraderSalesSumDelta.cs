namespace EFT.Communications;

public sealed class NotificationTraderSalesSumDelta : NotificationTraderLoyalty
{

	public NotificationTraderSalesSumDelta() { }

	protected virtual void ApplySingleChange(IEftSession session, string traderId, Nullable salesSumDelta) { }

}

