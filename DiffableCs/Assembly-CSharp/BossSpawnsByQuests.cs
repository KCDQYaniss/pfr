//Type is in global namespace

public class BossSpawnsByQuests
{
	private readonly List _byQuestsSpawns; //Field offset: 0x10
	private ITimer _loopTimer; //Field offset: 0x18
	private IPlayersCollection people; //Field offset: 0x20
	private readonly Action activateWave; //Field offset: 0x28

	private float PeriodCheck
	{
		private get { } //Length: 9
	}

	public BossSpawnsByQuests(Action activateWave) { }

	private bool ActivateByTriggerId(BossLocationSpawn wave, string playerQuestId) { }

	public void AddWave(BossLocationSpawn wave) { }

	private void CheckPlayerOnQuests(IPlayer playerToTest) { }

	public void Dispose() { }

	private float get_PeriodCheck() { }

	private void OnPersonAdd(IPlayer playerToTest) { }

	private void OnTimer() { }

	public void Run() { }

}

