namespace EFT.UI;

public interface INotificationViewFactory
{

	public BaseNotificationView CreateDefaultView(Notification notification) { }

	public BaseNotificationView CreateNotificationView(TNotification notification) { }

}

