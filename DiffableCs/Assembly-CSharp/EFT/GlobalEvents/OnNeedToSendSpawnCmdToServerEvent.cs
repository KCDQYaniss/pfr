namespace EFT.GlobalEvents;

public class OnNeedToSendSpawnCmdToServerEvent : BaseEvent
{
	private int _playerID; //Field offset: 0x18

	public int PlayerID
	{
		 get { } //Length: 4
	}

	public OnNeedToSendSpawnCmdToServerEvent() { }

	public int get_PlayerID() { }

	public void Invoke(int playerProfileID) { }

	public virtual void Reset() { }

}

