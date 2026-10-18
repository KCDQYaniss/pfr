namespace UnityEngine.UIElements;

public interface IVisualElementScheduler
{

	public IVisualElementScheduledItem Execute(Action timerUpdateEvent) { }

	public IVisualElementScheduledItem Execute(Action updateEvent) { }

}

