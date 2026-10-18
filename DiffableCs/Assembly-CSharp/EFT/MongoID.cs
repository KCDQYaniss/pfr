namespace EFT;

[BinaryReaderCompatible("ReadMongoId", "WriteMongoId")]
[IsReadOnly]
[JsonConverter(typeof(MongoIDConverter))]
[TypeConverter(typeof(MongoIdTypeConverter))]
public struct MongoID : IComparable, IEquatable
{
	public const string DEFAULT_MONGO_ID = "000000000000000000000000"; //Field offset: 0x0
	private static readonly Random _random; //Field offset: 0x0
	private static readonly ulong _processId; //Field offset: 0x8
	private static uint _newIdCounter; //Field offset: 0x10
	private readonly uint _timeStamp; //Field offset: 0x0
	private readonly ulong _counter; //Field offset: 0x8
	private readonly string _stringID; //Field offset: 0x10

	private static ulong NewProcessId
	{
		private get { } //Length: 192
	}

	private static uint TimeStamp
	{
		private get { } //Length: 237
	}

	private static MongoID() { }

	private MongoID(IBitStream stream) { }

	private MongoID(MongoID source, int increment, bool newTimestamp) { }

	public MongoID(Profile profile) { }

	private MongoID(BinaryReader reader) { }

	private MongoID(NetworkReader reader) { }

	private MongoID(uint timeStamp, ulong counter) { }

	public MongoID(bool newProcessId) { }

	[JsonConstructor]
	public MongoID(string id) { }

	public MongoID Add(int increment) { }

	public MongoID Combine(MongoID id) { }

	public override int CompareTo(MongoID other) { }

	private static ulong ConvertCounter(string id) { }

	private static uint ConvertTimeStamp(string id) { }

	private static string ConvertToString(uint timeStamp, ulong counter) { }

	private string ConvertToString() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(MongoID other) { }

	public bool EqualsToString(string str) { }

	public static MongoID Generate(bool newProcessId = true) { }

	private static ulong get_NewProcessId() { }

	private static uint get_TimeStamp() { }

	public virtual int GetHashCode() { }

	private void Init() { }

	public MongoID Next() { }

	public static MongoID op_Decrement(MongoID id) { }

	public static bool op_Equality(MongoID a, MongoID b) { }

	public static bool op_GreaterThan(MongoID a, MongoID b) { }

	public static bool op_GreaterThanOrEqual(MongoID a, MongoID b) { }

	public static string op_Implicit(MongoID mongoId) { }

	public static Nullable op_Implicit(string id) { }

	public static MongoID op_Implicit(string id) { }

	public static MongoID op_Increment(MongoID id) { }

	public static bool op_Inequality(MongoID a, MongoID b) { }

	public static bool op_LessThan(MongoID a, MongoID b) { }

	public static bool op_LessThanOrEqual(MongoID a, MongoID b) { }

	public static MongoID Read(IBitStream stream) { }

	public static MongoID Read(NetworkReader reader) { }

	public static MongoID Read(BinaryReader reader) { }

	public byte[] ToBytes() { }

	public virtual string ToString() { }

	public static bool TryParse(string id, out MongoID mongoId) { }

	public void Write(NetworkWriter writer) { }

	public void Write(BinaryWriter writer) { }

	public void Write(IBitStream stream) { }

}

