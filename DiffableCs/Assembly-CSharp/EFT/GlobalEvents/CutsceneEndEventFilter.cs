namespace EFT.GlobalEvents;

public class CutsceneEndEventFilter : BaseEventFilter
{
	[SerializeField]
	private string _cutsceneID; //Field offset: 0x28

	public CutsceneEndEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

