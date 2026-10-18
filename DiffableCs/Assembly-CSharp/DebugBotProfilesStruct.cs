//Type is in global namespace

public class DebugBotProfilesStruct
{
	public BotDifficulty[] Dif; //Field offset: 0x10
	public WildSpawnType[] Roles; //Field offset: 0x18
	public int[] Counts; //Field offset: 0x20
	public int TotalCount; //Field offset: 0x28
	public int LoadCount; //Field offset: 0x2C
	public int TotalBackups; //Field offset: 0x30
	public int LastSecondsPeriod; //Field offset: 0x34

	public DebugBotProfilesStruct() { }

	public static DebugBotProfilesStruct Deserialize(IBitReaderStream stream) { }

	public string MessageInfo() { }

	public static void Serialize(DebugBotProfilesStruct data, IBitWriterStream stream) { }

	public void SetData(TwoDimensionalDictionary listRole) { }

}

