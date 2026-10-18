namespace EFT.GlobalEvents;

public class PlayerInteractionWithBufferZoneEventFilter : BaseEventFilter
{
	[SerializeField]
	private EInteractState _neededState; //Field offset: 0x28

	public PlayerInteractionWithBufferZoneEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

