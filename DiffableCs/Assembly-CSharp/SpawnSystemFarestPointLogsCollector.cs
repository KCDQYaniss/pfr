//Type is in global namespace

public class SpawnSystemFarestPointLogsCollector
{
	public bool Inited; //Field offset: 0x10
	private readonly List _listfarestListDebug; //Field offset: 0x18
	private FarestListDebug _resultFarset; //Field offset: 0x20
	private bool _calcFarestFromPlayer; //Field offset: 0x28
	private readonly Dictionary _collectionsOccupiedPoints; //Field offset: 0x30
	private ISpawnPoint _finalNoValidRandom; //Field offset: 0x38

	public SpawnSystemFarestPointLogsCollector() { }

	public void AddFarthestFromPlayers(ISpawnPoint spawnPoint, float sqrDistance) { }

	public void AddFarthestFromPlayersResult(ISpawnPoint rnd, float dist) { }

	public void AddFinalNoValiedRandom(ISpawnPoint spawnPoint) { }

	public void AddNotOccupied(ISpawnPoint point, bool isNotOccupied) { }

	public StringBuilder DebugInfo() { }

	public void StartCalcFarthestFromPlayers() { }

}

