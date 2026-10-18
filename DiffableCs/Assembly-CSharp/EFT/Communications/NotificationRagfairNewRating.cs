namespace EFT.Communications;

public sealed class NotificationRagfairNewRating : NotificationRagFair
{
	[JsonProperty("rating")]
	public float Rating; //Field offset: 0x30
	[JsonProperty("isRatingGrowing")]
	public bool IsRatingGrowing; //Field offset: 0x34

	public virtual string Description
	{
		 get { } //Length: 156
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationRagfairNewRating() { }

	public virtual string get_Description() { }

	public virtual bool get_ShowNotification() { }

}

