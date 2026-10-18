//Type is in global namespace

public class WavesCountControlScenario
{
	private Dictionary _lastWaveZones; //Field offset: 0x10
	private BotSpawner _botSpawner; //Field offset: 0x18
	private Dictionary _zonesPatrols; //Field offset: 0x20
	private bool _isInited; //Field offset: 0x28

	public WavesCountControlScenario() { }

	private int AliveCount(BotsGroup group) { }

	private PatrolPoint ClosesPatrol(Player testedPlayer, out float dist) { }

	public void Dispose() { }

	private BotZone FindClosestZoneByPatrols() { }

	public void Init(BotSpawner botSpawner, Dictionary zonePatrols) { }

	private void OnBotCreated(BotOwner obj) { }

	private void OnBotRemoved(BotOwner obj) { }

	private void OnSpawnedWave(SpawnedWave obj) { }

}

