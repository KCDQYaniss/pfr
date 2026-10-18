namespace EFT.GlobalEvents;

public class DoorInteractionEvent : BaseEvent
{
	public Door Door; //Field offset: 0x18

	public DoorInteractionEvent() { }

	public void Invoke(Door door) { }

	public virtual void Reset() { }

}

