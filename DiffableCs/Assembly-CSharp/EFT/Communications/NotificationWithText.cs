namespace EFT.Communications;

public abstract class NotificationWithText : Notification
{
	[JsonProperty("text")]
	public string Text; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 76
	}

	protected NotificationWithText() { }

	public virtual string get_Description() { }

}

