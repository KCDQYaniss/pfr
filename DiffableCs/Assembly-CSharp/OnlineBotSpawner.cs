//Type is in global namespace

public class OnlineBotSpawner : BotSpawner
{

	public OnlineBotSpawner(IBotCreator botCreator, IBotGame game, BotZone[] botZones, BotsList bots, ISpawnSystem spawnSystem, int maxBots, bool freeForAll, Dictionary allZonesPatrols, string openZones) { }

	private Dictionary GetFreePlacesAtZones(bool isSniper, out int totalSum) { }

	protected virtual SimpleBotSpawnDelayModel TrySpawnFreeInner(BotCreationData data, bool newWave, Action callback) { }

}

