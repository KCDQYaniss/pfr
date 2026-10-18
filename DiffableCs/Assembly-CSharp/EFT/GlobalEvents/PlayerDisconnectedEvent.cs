namespace EFT.GlobalEvents;

public class PlayerDisconnectedEvent : BaseEvent
{
	private string _profileID; //Field offset: 0x18

	public string ProfileID
	{
		 get { } //Length: 5
	}

	public PlayerDisconnectedEvent() { }

	public string get_ProfileID() { }

	public void Invoke(string playerProfileID) { }

	public virtual void Reset() { }

}

