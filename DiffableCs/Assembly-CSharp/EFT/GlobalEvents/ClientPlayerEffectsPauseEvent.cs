namespace EFT.GlobalEvents;

public class ClientPlayerEffectsPauseEvent : BaseEvent
{
	private bool _isPaused; //Field offset: 0x18
	private string _playerProfileID; //Field offset: 0x20

	public bool IsPaused
	{
		 get { } //Length: 5
	}

	public string PlayerProfileID
	{
		 get { } //Length: 5
	}

	public ClientPlayerEffectsPauseEvent() { }

	public bool get_IsPaused() { }

	public string get_PlayerProfileID() { }

	public void Invoke(string playerProfileID, bool isPaused) { }

	public virtual void Reset() { }

}

