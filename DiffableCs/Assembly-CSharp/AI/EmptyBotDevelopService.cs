namespace AI;

public class EmptyBotDevelopService : IBotDevelopService
{
	[CompilerGenerated]
	private Action OnPlayerDataAdded; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnPlayerDataRemoved; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Player <MyPlayer>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <IsDeveloperMode>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly GameWorld <GameWorld>k__BackingField; //Field offset: 0x30

	public override event Action OnPlayerDataAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnPlayerDataRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override GameWorld GameWorld
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public override bool IsDeveloperMode
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override Player MyPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public EmptyBotDevelopService() { }

	[CompilerGenerated]
	public override void add_OnPlayerDataAdded(Action value) { }

	[CompilerGenerated]
	public override void add_OnPlayerDataRemoved(Action value) { }

	public void AddDebugLogMarker(int playerId) { }

	public void AddEffectToAllBots(EDebugBotEffect selectedEffect) { }

	public void AddEffectToBot(int botId, EDebugBotEffect selectedEffect) { }

	public void DebugSpawnBot(WildSpawnType profile, BotDifficulty difficulty) { }

	public void DeserializeCanFireAllBots(byte[] data) { }

	public void DeserializeDataGroups(byte[] data) { }

	public void DeserializeDataZones(byte[] spawns) { }

	public void DeserializeDebugBotStruct(byte[] data) { }

	public void FillGroupData(List resultCache) { }

	public void FillProfilesData(DebugBotProfilesStructContainer resultCache) { }

	[CompilerGenerated]
	public override GameWorld get_GameWorld() { }

	[CompilerGenerated]
	public override bool get_IsDeveloperMode() { }

	[CompilerGenerated]
	public override Player get_MyPlayer() { }

	public DebugBotStruct GetBotDebugData(IPlayer person, int playerRaidId) { }

	public bool GetCanFireAllBots() { }

	public override List GetGroupData() { }

	public override DebugBotProfilesStructContainer GetProfilesData() { }

	public DebugBotSpawnStruct GetSpawnsData() { }

	public DebugZoneInfoStruct GetZoneData() { }

	public override void Initialize(int playerId = 0) { }

	public void KillAllBots() { }

	public void KillBot(int botId) { }

	[CompilerGenerated]
	public override void remove_OnPlayerDataAdded(Action value) { }

	[CompilerGenerated]
	public override void remove_OnPlayerDataRemoved(Action value) { }

	public void SetCanFireAllBots(bool canFire) { }

	public void SetDataProfiles(byte[] data) { }

	public void SetDebugBrain(int botId, DebugBotDesition selectedDebugBrain) { }

	public void SetDebugBrainAllBots(DebugBotDesition selectedDebugBrain) { }

	public void SetDisableGrenadesForAll(bool needDisable) { }

	public void SetFogMaxDebuffDistanceK(int botId, float value) { }

	public void SetFreeForAll(bool isFree) { }

	public void SetIgnoreKarmaAllBots(bool needIgnore) { }

	public override void SetNetworkDataUpdateKd(float networkDataUpdateKd) { }

	public void SetRainMaxDebuffDistanceK(int botId, float value) { }

	public void SpawnBotDebugClient(EPlayerSide side, bool canBeSnipe, DebugBotProfileChooser profile = 0, bool forcedSpawn = false) { }

	public void SpawnBotDebugServer(EPlayerSide side, bool canBeSnipe, WildSpawnType profile = 1, BotDifficulty botDifficulty = 1, bool forcedSpawn = false) { }

	public void SpawnBotDebugServerLocalFiles(EPlayerSide side, bool canBeSnipe, int count, DebugBotProfileChooser profile = 0, bool forcedSpawn = false) { }

	public void StartGettingInfo() { }

	public void StopGettingInfo() { }

	public void TeleportClosestBot(Vector3 pos) { }

	public void TeleportSelectedBot(int botId, Vector3 pos) { }

}

