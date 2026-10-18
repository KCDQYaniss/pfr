namespace EFT.GlobalEvents;

public class InteractWithKeeperZoneEventFilter : BaseEventFilter
{
	[SerializeField]
	private EInteractState _neededState; //Field offset: 0x28

	public InteractWithKeeperZoneEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

