namespace EFT.GlobalEvents;

public class ClientInteractiveTriggerEventFilter : BaseEventFilter
{
	[SerializeField]
	private string _triggerId; //Field offset: 0x28

	public ClientInteractiveTriggerEventFilter() { }

	protected virtual bool IsFilterPassed(BaseEvent eventToFilter) { }

}

