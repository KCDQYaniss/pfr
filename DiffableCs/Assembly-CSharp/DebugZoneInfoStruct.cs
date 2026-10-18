//Type is in global namespace

public struct DebugZoneInfoStruct
{
	public const int OFFSET = 1; //Field offset: 0x0
	private static int BLOCK_LIMIT; //Field offset: 0x0
	private static int WILD_COUNT; //Field offset: 0x4
	public int wildTypesCount; //Field offset: 0x0
	public int ZonesCount; //Field offset: 0x4
	public string[] Names; //Field offset: 0x8
	public int[][] Blocks; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 18
	}

	private static DebugZoneInfoStruct() { }

	public DebugZoneInfoStruct(Dictionary data) { }

	public static DebugZoneInfoStruct Deserialize(IBitReaderStream stream) { }

	public int get_Count() { }

	public static void Serialize(DebugZoneInfoStruct data, IBitWriterStream stream) { }

}

