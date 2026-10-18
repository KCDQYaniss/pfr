namespace MultiFlare;

public class LightStorage : ILightStorage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal ValueTuple <GetAll>b__20_0(KeyValuePair pair) { }

	}

	private const int InterLoopBatchCount = 100; //Field offset: 0x0
	private const int InitialLightCapacity = 1000; //Field offset: 0x0
	private static FlareLightData _empty; //Field offset: 0x0
	private readonly Dictionary _indexMap; //Field offset: 0x10
	private readonly Dictionary _indexMapReversed; //Field offset: 0x18
	private NativeList _lights; //Field offset: 0x20
	private NativeArray _intermediateJobData; //Field offset: 0x28
	private TransformAccessArray _transforms; //Field offset: 0x38
	private int _counter; //Field offset: 0x40

	public override int Capacity
	{
		 get { } //Length: 80
	}

	public override int Count
	{
		 get { } //Length: 80
	}

	public LightStorage() { }

	public int Add(FlareLight flareLight) { }

	private int AddIndex(FlareLight value) { }

	public override bool Contains(FlareLight flareLight) { }

	public void Dispose() { }

	public void DisposeIntermediateData() { }

	public FlareLightData Get(FlareLight flareLight) { }

	public override int get_Capacity() { }

	public override int get_Count() { }

	public IEnumerable GetAll() { }

	public ReadOnly GetJobData() { }

	private static void LogWarning(string lightName) { }

	public void Remove(FlareLight flareLight, out int removedIndex, out int replacedIndex) { }

	private void RemoveIndex(int index, out int replacedIndex) { }

	public JobHandle UpdatePositions() { }

}

