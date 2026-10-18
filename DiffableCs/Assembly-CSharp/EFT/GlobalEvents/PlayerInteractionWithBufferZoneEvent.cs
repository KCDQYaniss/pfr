namespace EFT.GlobalEvents;

public class PlayerInteractionWithBufferZoneEvent : BaseEvent
{
	internal enum EInteractState
	{
		None = 0,
		MyPlayerEntered = 1,
		MyPlayerExited = 2,
		PlayerEntered = 1,
		PlayerExited = 2,
	}

	private EInteractState _interactState; //Field offset: 0x18
	private IPlayer _interactingPlayer; //Field offset: 0x20

	public IPlayer InteractingPlayer
	{
		 get { } //Length: 5
	}

	public EInteractState InteractState
	{
		 get { } //Length: 4
	}

	public PlayerInteractionWithBufferZoneEvent() { }

	public IPlayer get_InteractingPlayer() { }

	public EInteractState get_InteractState() { }

	public void Invoke(IPlayer interactingPlayer, bool entered) { }

	public virtual void Reset() { }

}

