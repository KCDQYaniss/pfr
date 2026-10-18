namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class FlareShootZoneEvent : SyncEventFromServer
{
	internal enum EZoneEventType
	{
		None = 0,
		PlayerEnteredZone = 1,
		PlayerExitedZone = 2,
		FiredPlayerAddedInShotList = 3,
		PlayerByPartyAddedInShotList = 4,
		PlayerWithImmuneReconnected = 5,
	}

	private EZoneEventType _zoneEventType; //Field offset: 0x18
	private int _playerRaidId; //Field offset: 0x1C
	private FlareEventType _flareEventType; //Field offset: 0x20
	private string _zoneID; //Field offset: 0x28

	public FlareEventType FlareEventType
	{
		 get { } //Length: 4
	}

	public int PlayerRaidID
	{
		 get { } //Length: 4
	}

	public EZoneEventType ZoneEventType
	{
		 get { } //Length: 4
	}

	public string ZoneID
	{
		 get { } //Length: 5
	}

	public FlareShootZoneEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	public FlareEventType get_FlareEventType() { }

	public int get_PlayerRaidID() { }

	public EZoneEventType get_ZoneEventType() { }

	public string get_ZoneID() { }

	public void Invoke(FlareEventType flareType, EZoneEventType eventType, int playerRaidID, string zoneID) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

}

