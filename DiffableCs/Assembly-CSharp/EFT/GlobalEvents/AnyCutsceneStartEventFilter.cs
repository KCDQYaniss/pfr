namespace EFT.GlobalEvents;

public class AnyCutsceneStartEventFilter : BaseEventFilter
{

	public AnyCutsceneStartEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

