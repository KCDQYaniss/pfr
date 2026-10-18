namespace EFT.GlobalEvents;

public class BufferInnerZoneStatusEvent : BaseEvent
{
	internal enum EZoneState
	{
		None = 0,
		Common = 1,
		KickSoon = 2,
		DisabledAfterZryachiyKilled = 3,
		DisabledAfterPlayerKilled = 4,
		TimeEndingWarning = 5,
		CantShowTimeEndingWarning = 6,
	}

	private EZoneState _zoneState; //Field offset: 0x18

	public EZoneState ZoneState
	{
		 get { } //Length: 4
	}

	public BufferInnerZoneStatusEvent() { }

	public EZoneState get_ZoneState() { }

	public void Invoke(EZoneState zoneState) { }

	public virtual void Reset() { }

}

