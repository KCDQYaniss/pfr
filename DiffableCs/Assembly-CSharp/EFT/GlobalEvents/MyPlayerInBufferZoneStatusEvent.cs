namespace EFT.GlobalEvents;

public class MyPlayerInBufferZoneStatusEvent : BaseEvent
{
	private bool _insideZone; //Field offset: 0x18
	private bool _afterReconnect; //Field offset: 0x19

	public bool AfterReconnect
	{
		 get { } //Length: 5
	}

	public bool InsideZone
	{
		 get { } //Length: 5
	}

	public MyPlayerInBufferZoneStatusEvent() { }

	public bool get_AfterReconnect() { }

	public bool get_InsideZone() { }

	public void Invoke(bool insideZone, bool afterReconnect = false) { }

	public virtual void Reset() { }

}

