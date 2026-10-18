//Type is in global namespace

public class SpawnSystemDebugCollector
{
	private List active; //Field offset: 0x10
	private readonly List listFirst; //Field offset: 0x18
	private readonly List listSecond; //Field offset: 0x20
	private bool _haveNotValidePoints; //Field offset: 0x28
	private readonly Dictionary _dcCheckCarePlayers; //Field offset: 0x30
	private CheckPoisitonDataCarePlayers _activeCarePLayersInfo; //Field offset: 0x38
	private readonly ScavsTogetherDebug _scavsTogetherDebug; //Field offset: 0x40
	private readonly SpawnSystemFarestPointLogsCollector _farestPointLogsCollector; //Field offset: 0x48
	private SpawnPointDebugStruct _curTestingPoint; //Field offset: 0x50
	private ISpawnPoint _resultPoint; //Field offset: 0x58
	private IEnumerable _resultPoints; //Field offset: 0x60
	private readonly string _title; //Field offset: 0x68
	private string _finishTitle; //Field offset: 0x70
	private ISpawnPoint _lastRnd; //Field offset: 0x78

	public SpawnSystemDebugCollector(string title) { }

	public void AddFarthestFromPlayers(ISpawnPoint spawnPoint, float sqrDistance) { }

	public void AddFarthestFromPlayersResult(ISpawnPoint rnd, float dist) { }

	public void AddFinalNoValiedRandom(ISpawnPoint spawnPoint) { }

	public void AddNotOccupied(ISpawnPoint point, bool isNotOccupied) { }

	public void AddValidSpawnPoint(ISpawnPoint sp) { }

	public void AddValidSpawnPointSide(ISpawnPoint sp, bool isValid, Nullable profileDataSide) { }

	public void AddValidSpawnPointTime(ISpawnPoint sp, bool isValid, float time) { }

	public void CarePlayersIsGood(string spawnPointId) { }

	public void CarePlayersIsNull(string spawnPointId) { }

	public void CheckDist(string spawnPointId, int playerId, Vector3 playerPosition, Vector3 spawnPointPosition, float sDist, float distanceSqr) { }

	public void CheckPlayer(string spawnPointId, int playerId, Vector3 playerPosition, ISpawnPointCollider spawnPointCollider, bool contain) { }

	public void CheckValidPoints(ISpawnPoint validPoint) { }

	public void CheckValidPointsIsOccupied(bool notOccupied) { }

	public void CheckValidPointsSDist(float sDist) { }

	public void Finish(ISpawnPoint result, string finishTitle) { }

	public void Finish(IEnumerable result, string finishTitle) { }

	public void Finish(string finishTitle) { }

	public void GroupPlayerIsNull(ISpawnPoint spawnPoint) { }

	public void HaveValidPoints() { }

	public void LastRandom(ISpawnPoint lastRnd) { }

	public void NoValidPointsFirstIteration() { }

	private void PrintLogs() { }

	private void PrintTask() { }

	public void SetClosest(ISpawnPoint closest, float tmpDist) { }

	public void SetGroupCenter(Vector3 groupCenterPoint) { }

	public void SetValid(bool isValid) { }

	public void StartCalcFarthestFromPlayers() { }

	public void StartCheckCarePlayers(string spawnPointId) { }

	public void StartScavTogerther() { }

}

