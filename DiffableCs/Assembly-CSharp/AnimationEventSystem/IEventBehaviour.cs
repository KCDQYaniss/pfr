namespace AnimationEventSystem;

public interface IEventBehaviour : IStateBehaviour
{

	public AnimationEventsContainer EventsContainer
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int FullNameHash
	{
		 get { } //Length: 0
	}

	public AnimationEventsContainer get_EventsContainer() { }

	public int get_FullNameHash() { }

	public void set_EventsContainer(AnimationEventsContainer value) { }

}

