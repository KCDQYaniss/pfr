namespace EFT.GlobalEvents;

public class FinalExitZoneInitAnnouncerEventFilter : BaseEventFilter
{
	[SerializeField]
	private float _timeToRaidEndMS; //Field offset: 0x28
	[SerializeField]
	private bool _triggerOnce; //Field offset: 0x2C
	private bool _hasTriggered; //Field offset: 0x2D

	public FinalExitZoneInitAnnouncerEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

