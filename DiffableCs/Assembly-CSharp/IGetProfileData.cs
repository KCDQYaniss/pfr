//Type is in global namespace

public interface IGetProfileData
{

	public bool KeepZoneOnSpawn
	{
		 get { } //Length: 0
	}

	public Nullable Side
	{
		 get { } //Length: 0
	}

	public BotSpawnParams SpawnParams
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool CanAtZoneByType(BotZone botZone, BotZonesLeaveController botsControllerZonesLeaveController) { }

	[CanBeNull]
	public Profile ChooseProfile(List profiles2Select, bool withDelete) { }

	public bool get_KeepZoneOnSpawn() { }

	public Nullable get_Side() { }

	public BotSpawnParams get_SpawnParams() { }

	public string GetDebugData() { }

	public string GetDebugLocalName() { }

	public bool IsBossOrFollower() { }

	public bool IsBossOrFollowerByTime() { }

	public bool IsSpawnOnStart() { }

	public bool IsValidSpawnType(WildSpawnType wildSpawnType) { }

	public bool IsZeroWave() { }

	public CountTypeBotWave[] PrepareToLoadBackend(int count) { }

	public void set_SpawnParams(BotSpawnParams value) { }

	public bool ShallChooseByData() { }

	public bool TryGetRole(out WildSpawnType role, out BotDifficulty difficulty) { }

}

