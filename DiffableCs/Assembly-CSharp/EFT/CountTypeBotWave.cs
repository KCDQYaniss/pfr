namespace EFT;

public class CountTypeBotWave
{
	public WildSpawnType Role; //Field offset: 0x10
	public int Limit; //Field offset: 0x14
	public BotDifficulty Difficulty; //Field offset: 0x18

	public CountTypeBotWave(int count, WildSpawnType roleType, BotDifficulty difficulty) { }

	public CountTypeBotWave Copy() { }

	public string DebugData() { }

}

