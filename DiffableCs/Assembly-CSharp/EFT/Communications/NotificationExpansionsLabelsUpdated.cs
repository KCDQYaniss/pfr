namespace EFT.Communications;

public sealed class NotificationExpansionsLabelsUpdated : Notification
{
	[JsonProperty("newOffers")]
	public int NewOffersCount; //Field offset: 0x30
	[JsonProperty("freeOffers")]
	public int FreeOffersCount; //Field offset: 0x34
	[JsonProperty("saleOffers")]
	public int SaleOffersCount; //Field offset: 0x38

	public virtual string Description
	{
		 get { } //Length: 59
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationExpansionsLabelsUpdated() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

