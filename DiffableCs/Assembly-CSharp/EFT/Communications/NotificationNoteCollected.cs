namespace EFT.Communications;

public sealed class NotificationNoteCollected : NotificationWithText
{

	public NotificationNoteCollected() { }

	public virtual BaseNotificationView CreateView(INotificationViewFactory viewFactory) { }

	public static NotificationNoteCollected New(string noteName) { }

}

