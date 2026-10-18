//Type is in global namespace

public class BotSpawnLimiter
{
	private BotsController _botsController; //Field offset: 0x10
	private Dictionary _playerIndividualSpawnLimits; //Field offset: 0x18

	private int NonWaveSpawnBotsLimitPerPlayer
	{
		private get { } //Length: 81
	}

	public BotSpawnLimiter(BotsController controller) { }

	private int get_NonWaveSpawnBotsLimitPerPlayer() { }

	public void IncreaseUsedPlayerSpawns(Player player, BotCreationData creationData) { }

	public bool IsInPlayerSpawnLimit(Player player, BotCreationData creationData) { }

	private float NonWaveSpawnStartTime() { }

	private bool ShallUseBotLimits() { }

}

