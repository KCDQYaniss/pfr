namespace EFT.GlobalEvents;

public class InteractWithKeeperZoneEvent : BaseEvent
{
	internal enum EInteractState
	{
		None = 0,
		IsEntering = 1,
		Entered = 2,
		IsExiting = 3,
		Exited = 4,
	}

	private EInteractState _interactState; //Field offset: 0x18
	private Player _interactingPlayer; //Field offset: 0x20

	public Player InteractingPlayer
	{
		 get { } //Length: 5
	}

	public EInteractState InteractState
	{
		 get { } //Length: 4
	}

	public InteractWithKeeperZoneEvent() { }

	public Player get_InteractingPlayer() { }

	public EInteractState get_InteractState() { }

	public void Invoke(Player interactingPlayer, EInteractState state) { }

	public virtual void Reset() { }

}

