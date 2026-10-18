namespace EFT.Communications;

public sealed class NotificationAchievementUnlocked : Notification
{
	[JsonProperty("achievementId")]
	public string AchievementId; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 153
	}

	public NotificationAchievementUnlocked() { }

	public virtual string get_Description() { }

}

