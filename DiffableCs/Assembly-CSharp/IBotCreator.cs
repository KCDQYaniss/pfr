//Type is in global namespace

public interface IBotCreator
{

	public int BotsLoading
	{
		 get { } //Length: 0
	}

	public int BundlesLoading
	{
		 get { } //Length: 0
	}

	public bool StartProfilesLoaded
	{
		 get { } //Length: 0
	}

	public Task ActivateBot(BotCreationData data, BotZone zone, BotSpawnBossAndGroupParams shallBeGroup, Func groupAction, Action callback, CancellationToken cancellationToken) { }

	public Task ActivateBot(Profile profile, PositionNote position, BotZone zone, BotSpawnBossAndGroupParams shallBeGroup, Func groupAction, Action callback, CancellationToken cancellationToken) { }

	public void AddToTargetBackup(BotDifficulty difficulty, WildSpawnType role, int count) { }

	public void FillBackupProfilesData(DebugBotProfilesStructContainer resultCache) { }

	public Task GenerateProfile(BotCreationData data, CancellationToken cancellationToken, bool withDelete) { }

	public int get_BotsLoading() { }

	public int get_BundlesLoading() { }

	public bool get_StartProfilesLoaded() { }

}

