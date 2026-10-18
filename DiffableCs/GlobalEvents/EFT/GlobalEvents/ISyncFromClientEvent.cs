namespace EFT.GlobalEvents;

public interface ISyncFromClientEvent : ISyncEvent, IEvent
{

	public int OriginPlayerRaidId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int get_OriginPlayerRaidId() { }

	public void set_OriginPlayerRaidId(int value) { }

}

