namespace EFT;

public class SpawnWave
{
	public int BotsCount; //Field offset: 0x10
	public EPlayerSide Side; //Field offset: 0x14
	public string SpawnAreaName; //Field offset: 0x18
	public float Time; //Field offset: 0x20
	public WildSpawnType WildSpawnType; //Field offset: 0x24
	public bool IsPlayers; //Field offset: 0x28
	public BotDifficulty Difficulty; //Field offset: 0x2C
	public float ChanceGroup; //Field offset: 0x30
	public bool WithCheckMinMax; //Field offset: 0x34
	public bool KeepZoneOnSpawn; //Field offset: 0x35

	public SpawnWave() { }

}

