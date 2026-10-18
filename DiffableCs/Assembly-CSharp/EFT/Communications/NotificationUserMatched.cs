namespace EFT.Communications;

public abstract class NotificationUserMatched : Notification
{
	public bool BlockExitButton; //Field offset: 0x30
	public int BlockExitButtonDuration; //Field offset: 0x34
	public bool ShowConfirmationPopup; //Field offset: 0x38

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	protected NotificationUserMatched() { }

	public virtual bool get_ShowNotification() { }

}

