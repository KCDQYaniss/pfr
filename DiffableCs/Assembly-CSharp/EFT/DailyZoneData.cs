namespace EFT;

public class DailyZoneData
{
	internal enum EQuestZoneType
	{
		Kill = 0,
		Hide = 1,
		Mark = 2,
	}

	private const string DAILY_ZONE_PREFIX = "dl_"; //Field offset: 0x0
	private const char SEPARATOR = '\u5F'; //Field offset: 0x0
	public string Name; //Field offset: 0x10
	public string Location; //Field offset: 0x18
	public EQuestZoneType ZoneType; //Field offset: 0x20

	public DailyZoneData(string zoneName, string locationId) { }

	private EQuestZoneType GetZoneType(string typePartOfName) { }

	public static bool IsDailyQuestZone(string zoneName) { }

}

