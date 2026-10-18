namespace EFT.Game.Spawning;

public interface ISpawnSystem
{

	public AbstractLogger Logger
	{
		 get { } //Length: 0
	}

	public bool CheckFarthestFromOtherPlayers(IPlayer player) { }

	public void Dispose() { }

	public AbstractLogger get_Logger() { }

	public bool IsValidSpawn(ISpawnPoint spawnPoint, BotCreationData profileData, float time) { }

	[NotNull]
	public List SelectAISpawnPoints(BotCreationData profileData, BotZone zone, int maxCount, Nullable closestBossPos = null, ActionIfNotEnoughPoints mode = 1, List spawnProcess = null) { }

	[NotNull]
	public ISpawnPoint SelectPlayerSavageSpawn(ESpawnCategory category, string groupId = null, string teamId = null, IPlayer person = null, string zoneName = null, string profileId = null) { }

	[NotNull]
	public ISpawnPoint SelectSpawnPoint(ESpawnCategory category, EPlayerSide side, string groupId = null, string teamId = null, IPlayer person = null, string infiltration = null, string profileId = null) { }

	public bool TryGetSpawnPointById(string id, out ISpawnPoint spawnPoint) { }

	public void Validate() { }

	public bool ValidateSpawnPosition(ref Vector3 position, BotZone zone, IPlayer person, BotCreationData data) { }

}

