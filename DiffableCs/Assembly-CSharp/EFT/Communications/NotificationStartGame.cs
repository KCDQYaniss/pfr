namespace EFT.Communications;

public sealed class NotificationStartGame : Notification
{
	[JsonProperty("estimate")]
	public int MatchingEstimateTimeSeconds; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 153
	}

	public NotificationStartGame() { }

	public virtual string get_Description() { }

}

