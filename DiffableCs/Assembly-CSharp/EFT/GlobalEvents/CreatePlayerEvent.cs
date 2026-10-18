namespace EFT.GlobalEvents;

public class CreatePlayerEvent : BaseEvent
{
	public Player Player; //Field offset: 0x18

	public CreatePlayerEvent() { }

	public void Invoke(Player player) { }

	public virtual void Reset() { }

}

