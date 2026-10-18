namespace EFT.GlobalEvents;

public class TimelineSignalEmitEventFilter : BaseEventFilter
{
	[SerializeField]
	private string signalID; //Field offset: 0x28

	public TimelineSignalEmitEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

