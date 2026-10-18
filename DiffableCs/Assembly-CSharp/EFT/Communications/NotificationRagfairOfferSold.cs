namespace EFT.Communications;

public sealed class NotificationRagfairOfferSold : NotificationRagFair
{
	[JsonProperty("offerId")]
	public string OfferId; //Field offset: 0x30
	[JsonProperty("count")]
	public int Count; //Field offset: 0x38
	[JsonProperty("handbookId")]
	public string HandbookId; //Field offset: 0x40

	public virtual string Description
	{
		 get { } //Length: 153
	}

	public NotificationRagfairOfferSold() { }

	public virtual string get_Description() { }

}

