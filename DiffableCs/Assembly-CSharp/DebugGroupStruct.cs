//Type is in global namespace

public struct DebugGroupStruct
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__22_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__22_0(KeyValuePair x) { }

	}

	public static List GroupsNames; //Field offset: 0x0
	private const int DangerAreaCount = 63; //Field offset: 0x0
	private const int ENEMIES_COUNT = 127; //Field offset: 0x0
	private const int MembersCount = 63; //Field offset: 0x0
	private const int POWER_MAX = 511; //Field offset: 0x0
	private static readonly Dictionary ConvertedLetters; //Field offset: 0x8
	private static Dictionary _cache; //Field offset: 0x10
	public EPlayerSide Side; //Field offset: 0x0
	public string name; //Field offset: 0x8
	public int Members; //Field offset: 0x10
	public int Enemies; //Field offset: 0x14
	public int Warns; //Field offset: 0x18
	public int ActiveEnemies; //Field offset: 0x1C
	public int Requests; //Field offset: 0x20
	public int DeadBodies; //Field offset: 0x24
	public int PlacesForCheckCount; //Field offset: 0x28
	public int DangerArea; //Field offset: 0x2C
	public int enemiesCount; //Field offset: 0x30
	public float[] powers; //Field offset: 0x38
	public string[] ids; //Field offset: 0x40
	public string[] members; //Field offset: 0x48
	public string[] enemies; //Field offset: 0x50
	public string[] warns; //Field offset: 0x58
	public string[] neutrals; //Field offset: 0x60
	public string[] allies; //Field offset: 0x68

	private static DebugGroupStruct() { }

	public DebugGroupStruct(BotsGroup groupData) { }

	private static string ConvertToLatin(string source) { }

	public static string ConvertToLatinic(string toConvert) { }

	public static DebugGroupStruct Deserialize(IBitReaderStream stream) { }

	public string MessageInfo() { }

	public static void Serialize(DebugGroupStruct data, IBitWriterStream stream) { }

}

