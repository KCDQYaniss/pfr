namespace EFT.GameTriggers;

public class HandlerPlayerNotification : BaseTriggerHandler
{
	[SerializeField]
	private string _notificationText; //Field offset: 0x28
	[SerializeField]
	private bool _notificationForAll; //Field offset: 0x30

	public HandlerPlayerNotification() { }

	private void OnTriggerEvent(TriggerEvent triggerEvent) { }

	private void Start() { }

}

