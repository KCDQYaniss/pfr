//Type is in global namespace

public interface IBotProfileCreator
{

	public int BundlesLoading
	{
		 get { } //Length: 0
	}

	public bool StartProfilesLoaded
	{
		 get { } //Length: 0
	}

	public void AddToTargetBackup(BotDifficulty difficulty, WildSpawnType role, int count) { }

	public Task CreateProfile(BotCreationData data, CancellationToken cancellationToken, bool withDelete) { }

	public void FillBackupProfilesData(DebugBotProfilesStructContainer resultCache) { }

	public int get_BundlesLoading() { }

	public bool get_StartProfilesLoaded() { }

}

