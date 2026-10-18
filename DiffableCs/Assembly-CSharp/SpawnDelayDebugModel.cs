//Type is in global namespace

public struct SpawnDelayDebugModel
{
	public WildSpawnType Role; //Field offset: 0x0
	public BotDifficulty Difficulty; //Field offset: 0x4
	public int Count; //Field offset: 0x8
	public string ZoneName; //Field offset: 0x10

	public SpawnDelayDebugModel(WildSpawnType role, BotDifficulty difficulty, int count, string zoneName) { }

	public static SpawnDelayDebugModel Deserialize(IBitReaderStream stream) { }

	public static void Serialize(SpawnDelayDebugModel data, IBitWriterStream stream) { }

	public virtual string ToString() { }

}

