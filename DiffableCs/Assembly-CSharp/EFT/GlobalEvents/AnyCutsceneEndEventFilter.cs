namespace EFT.GlobalEvents;

public class AnyCutsceneEndEventFilter : BaseEventFilter
{

	public AnyCutsceneEndEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

