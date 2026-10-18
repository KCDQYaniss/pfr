namespace EFT.Communications;

public sealed class NotificationUserMatchCreated : NotificationUserMatched
{

	public virtual string Description
	{
		 get { } //Length: 153
	}

	public NotificationUserMatchCreated() { }

	public virtual string get_Description() { }

}

