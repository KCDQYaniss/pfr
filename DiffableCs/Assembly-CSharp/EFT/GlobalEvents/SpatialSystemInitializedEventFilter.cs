namespace EFT.GlobalEvents;

public class SpatialSystemInitializedEventFilter : BaseEventFilter
{

	public SpatialSystemInitializedEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

