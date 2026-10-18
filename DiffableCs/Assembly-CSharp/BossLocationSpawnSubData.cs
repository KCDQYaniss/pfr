//Type is in global namespace

public class BossLocationSpawnSubData : MonoBehaviour
{
	public int BossEscortAmount; //Field offset: 0x20
	public WildSpawnType BossEscortType; //Field offset: 0x24
	public BotDifficulty EscortDifficulty; //Field offset: 0x28

	public BossLocationSpawnSubData(int v, WildSpawnType escortType, BotDifficulty difficulty) { }

	public CountTypeBotWave GetTypesBotWave() { }

}

