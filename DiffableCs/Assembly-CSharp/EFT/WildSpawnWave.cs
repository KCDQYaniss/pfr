namespace EFT;

public class WildSpawnWave
{
	public int time_min; //Field offset: 0x10
	public int time_max; //Field offset: 0x14
	public int slots_min; //Field offset: 0x18
	public int slots_max; //Field offset: 0x1C
	public string SpawnPoints; //Field offset: 0x20
	public EPlayerSide BotSide; //Field offset: 0x28
	public WildSpawnType WildSpawnType; //Field offset: 0x2C
	public BotDifficulty _botDifficulty; //Field offset: 0x30
	public bool isPlayers; //Field offset: 0x34
	public string BotPreset; //Field offset: 0x38
	public float ChanceGroup; //Field offset: 0x40
	public bool KeepZoneOnSpawn; //Field offset: 0x44

	public BotDifficulty BotDifficulty
	{
		 get { } //Length: 4
		 set { } //Length: 172
	}

	public WildSpawnWave() { }

	public WildSpawnWave Copy() { }

	public BotDifficulty get_BotDifficulty() { }

	public BotDifficulty GetDifficulty() { }

	public void set_BotDifficulty(BotDifficulty value) { }

}

