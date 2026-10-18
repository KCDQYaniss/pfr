namespace EFT.GlobalEvents;

public class CutsceneStartEventFilter : BaseEventFilter
{
	[SerializeField]
	private string _cutsceneID; //Field offset: 0x28

	public CutsceneStartEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

