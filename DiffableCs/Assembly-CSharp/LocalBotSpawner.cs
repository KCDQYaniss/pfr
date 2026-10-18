//Type is in global namespace

public class LocalBotSpawner : BotSpawner
{

	public LocalBotSpawner(IBotCreator botCreator, IBotGame game, BotZone[] botZones, BotsList bots, ISpawnSystem spawnSystem, int maxBots, bool freeForAll, Dictionary allZonesPatrols, string openZones) { }

	protected virtual SimpleBotSpawnDelayModel TrySpawnFreeInner(BotCreationData data, bool newWave, Action callback) { }

}

