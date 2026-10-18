//Type is in global namespace

public struct DebugBotSpawnStruct
{
	public int Alive; //Field offset: 0x0
	public int ProfileWait; //Field offset: 0x4
	public int SpawnBundlesWait; //Field offset: 0x8
	public int Delayed; //Field offset: 0xC
	public int SpawnProcess; //Field offset: 0x10
	public int Hour; //Field offset: 0x14
	public int DelayedGroups; //Field offset: 0x18
	public SpawnDelayDebugModel[] DelayDebugModels; //Field offset: 0x20

	public DebugBotSpawnStruct(int alive, int profileWait, int delayed, int spawnProcess, int bundlesProcess, int hour, List delayModels) { }

	public static DebugBotSpawnStruct Deserialize(IBitReaderStream stream) { }

	public static void Serialize(DebugBotSpawnStruct data, IBitWriterStream stream) { }

}

