namespace EFT.Counters;

public sealed class CountersCollection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__47_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetSupersetIdentifiers>b__47_0(object input) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public List elements; //Field offset: 0x10

		public <>c__DisplayClass47_0() { }

		internal bool <GetSupersetIdentifiers>b__1(Identifier identifier) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public Identifier identifier; //Field offset: 0x10

		public <>c__DisplayClass54_0() { }

		internal bool <SumCounters>b__0(string counter) { }

	}

	internal sealed class Identifier : ComparableHashSet
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__4_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal string <.ctor>b__4_0(object enum) { }

		}

		[CompilerGenerated]
		private readonly CounterValueType <ValueType>k__BackingField; //Field offset: 0x20

		public CounterValueType ValueType
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public Identifier(CounterValueType valueType, IEnumerable values) { }

		public Identifier(CounterValueType valueType, object[] enums) { }

		[CompilerGenerated]
		public CounterValueType get_ValueType() { }

	}

	private static readonly List _countersToMax; //Field offset: 0x0
	private const int FLOAT_PRECISION = 100; //Field offset: 0x0
	private const int DOUBLE_PRECISION = 10000; //Field offset: 0x0
	private readonly Dictionary _counters; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnCounterChanged; //Field offset: 0x18

	public event Action OnCounterChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public IReadOnlyDictionary Counters
	{
		 get { } //Length: 5
	}

	private static CountersCollection() { }

	public CountersCollection(CounterCollectionDescriptor descriptor) { }

	public CountersCollection(IDictionary counters) { }

	[CompilerGenerated]
	public void add_OnCounterChanged(Action value) { }

	public void AddDouble(double value, Identifier key) { }

	public void AddDouble(double value, object[] enums) { }

	public void AddFloat(float value, Identifier key) { }

	public void AddFloat(float value, object[] enums) { }

	public void AddInt(int value, Identifier key) { }

	public void AddInt(int value, object[] enums) { }

	public void AddLong(long value, Identifier key) { }

	public void AddLong(long value, object[] enums) { }

	public void Clear() { }

	private Identifier CreateKey(object[] enums) { }

	public double Get(Identifier key) { }

	public IReadOnlyDictionary get_Counters() { }

	public double GetAll(Identifier key) { }

	public float GetAllFloat(object[] enums) { }

	public int GetAllInt(object[] enums) { }

	public long GetAllLong(object[] enums) { }

	public double GetDouble(Identifier key) { }

	public double GetDouble(object[] enums) { }

	public float GetFloat(object[] enums) { }

	public float GetFloat(Identifier key) { }

	public int GetInt(object[] enums) { }

	public int GetInt(Identifier key) { }

	public long GetLong(object[] enums) { }

	public long GetLong(Identifier key) { }

	public List GetSupersetIdentifiers(object[] enums) { }

	public void MaxFloat(float value, object[] enums) { }

	public void MaxFloat(float value, Identifier key) { }

	public void MaxInt(int value, Identifier key) { }

	public void MaxInt(int value, object[] enums) { }

	public void MaxLong(long value, object[] enums) { }

	public void MaxLong(long value, Identifier key) { }

	public void MinFloat(float value, Identifier key) { }

	public void MinFloat(float value, object[] enums) { }

	public void MinInt(int value, object[] enums) { }

	public void MinInt(int value, Identifier key) { }

	public void MinLong(long value, Identifier key) { }

	public void MinLong(long value, object[] enums) { }

	[CompilerGenerated]
	public void remove_OnCounterChanged(Action value) { }

	public void Set(Identifier key, double value) { }

	public void SetFloat(float value, object[] enums) { }

	public void SetFloat(float value, Identifier key) { }

	public void SetInt(int value, Identifier key) { }

	public void SetInt(int value, object[] enums) { }

	public void SetLong(long value, object[] enums) { }

	public void SetLong(long value, Identifier key) { }

	public CountersCollection SumCounters(CountersCollection otherCounters) { }

}

