namespace AnimationEventSystem;

public class EventsCollection
{
	[SerializeField]
	private List _animationEvents; //Field offset: 0x10

	public List AnimationEvents
	{
		 get { } //Length: 5
	}

	public EventsCollection(IEnumerable animationEvents) { }

	private static void FixEvents(EventsCollection eventsCollection) { }

	public List get_AnimationEvents() { }

}

