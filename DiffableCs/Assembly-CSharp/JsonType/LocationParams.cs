namespace JsonType;

public class LocationParams
{
	public string Id; //Field offset: 0x10
	public long UnixDateTime; //Field offset: 0x18
	public LootPointParameters[] Loot; //Field offset: 0x20
	public SpawnPointParams[] SpawnPointParams; //Field offset: 0x28
	public ExitTriggerSettings[] exits; //Field offset: 0x30
	public DailyZoneData[] DailyQuestZones; //Field offset: 0x38
	public LootableContainersGroupParams[] LootableContainersGroups; //Field offset: 0x40

	public LocationParams() { }

}

