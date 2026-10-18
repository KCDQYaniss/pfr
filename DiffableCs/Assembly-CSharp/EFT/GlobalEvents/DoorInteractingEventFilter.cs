namespace EFT.GlobalEvents;

public class DoorInteractingEventFilter : BaseEventFilter
{
	[SerializeField]
	private Door _doorForTracking; //Field offset: 0x28
	[SerializeField]
	private bool _doorOpened; //Field offset: 0x30
	[SerializeField]
	private bool _doorClosed; //Field offset: 0x31

	public DoorInteractingEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

