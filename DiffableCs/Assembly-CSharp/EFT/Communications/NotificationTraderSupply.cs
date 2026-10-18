namespace EFT.Communications;

public sealed class NotificationTraderSupply : Notification
{
	[JsonProperty("tid")]
	public string TraderId; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 322
	}

	public NotificationTraderSupply() { }

	public virtual string get_Description() { }

}

