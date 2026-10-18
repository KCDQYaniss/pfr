namespace EFT.Utilities;

public sealed class ClientMetricsEvents
{
	[JsonIgnore]
	private readonly AbstractLogger _logger; //Field offset: 0x10
	[JsonIgnore]
	private readonly float _metricsTime; //Field offset: 0x18
	[JsonIgnore]
	private readonly Stopwatch _stopwatch; //Field offset: 0x20
	public float MatchingCompleted; //Field offset: 0x28
	public float MatchingCompletedReal; //Field offset: 0x2C
	public float LocationLoaded; //Field offset: 0x30
	public float LocationLoadedReal; //Field offset: 0x34
	public float GamePrepared; //Field offset: 0x38
	public float GamePreparedReal; //Field offset: 0x3C
	public float GameCreated; //Field offset: 0x40
	public float GameCreatedReal; //Field offset: 0x44
	public float GamePooled; //Field offset: 0x48
	public float GamePooledReal; //Field offset: 0x4C
	public float GameRunned; //Field offset: 0x50
	public float GameRunnedReal; //Field offset: 0x54
	public float GameSpawn; //Field offset: 0x58
	public float GameSpawnReal; //Field offset: 0x5C
	public float PlayerSpawnEvent; //Field offset: 0x60
	public float PlayerSpawnEventReal; //Field offset: 0x64
	public float GameSpawned; //Field offset: 0x68
	public float GameSpawnedReal; //Field offset: 0x6C
	public float GameStarting; //Field offset: 0x70
	public float GameStartingReal; //Field offset: 0x74
	public float GameStarted; //Field offset: 0x78
	public float GameStartedReal; //Field offset: 0x7C

	public ClientMetricsEvents(AbstractLogger logger) { }

	private static float Diff(float from, float value) { }

	private ValueTuple MetricsTime() { }

	public void SetGameCreated() { }

	public void SetGamePooled() { }

	public void SetGamePrepared() { }

	public void SetGameRunned() { }

	public void SetGameSpawn() { }

	public void SetGameSpawned() { }

	public void SetGameStarted() { }

	public void SetGameStarting() { }

	public void SetLocationLoaded() { }

	public void SetMatchingCompleted() { }

	public void SetPlayerSpawnEvent() { }

}

