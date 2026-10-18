namespace Koenigz.PerfectCulling;

[CreateAssetMenu]
[PreferBinarySerialization]
public class PerfectCullingVolumeBakeData : PerfectCullingBakeData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__26_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <MergeDownsample>b__26_0(int val) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public PerfectCullingVolumeBakeData <>4__this; //Field offset: 0x10
		public Vector3Int OptimizedCellSize; //Field offset: 0x18
		public Vector3Int optDim; //Field offset: 0x24
		public PerfectCullingVolumeBakeData tmpBakeData; //Field offset: 0x30
		public int processedElementCount; //Field offset: 0x38

		public <>c__DisplayClass26_0() { }

		internal Task <MergeDownsample>b__1(IGrouping groups) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_1
	{
		private struct <<MergeDownsample>b__2>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass26_1 <>4__this; //Field offset: 0x20

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public IGrouping groups; //Field offset: 0x10
		public <>c__DisplayClass26_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass26_1() { }

		[AsyncStateMachine(typeof(<<MergeDownsample>b__2>d))]
		internal Task <MergeDownsample>b__2() { }

	}

	internal struct RawData
	{
		public ushort[] uncompressed; //Field offset: 0x0

	}

	internal struct VisibilitySet
	{
		public byte[] compressed; //Field offset: 0x0
		public ushort numDeltaValues; //Field offset: 0x8

	}

	public const int MaxValue = 15; //Field offset: 0x0
	public const int HeaderBitSize = 2; //Field offset: 0x0
	public static uint[] BITS; //Field offset: 0x0
	private static BitStreamReader m_bitStreamReader; //Field offset: 0x8
	private static BitStreamWriter m_bitStreamWriter; //Field offset: 0x10
	public Vector3 cellCount; //Field offset: 0x38
	public Vector3 cellSize; //Field offset: 0x44
	public Vector3 originalCellSize; //Field offset: 0x50
	public Quaternion orientation; //Field offset: 0x5C
	public VisibilitySet[] data; //Field offset: 0x70
	public RawData[] rawData; //Field offset: 0x78
	public int runtimeAssetSize; //Field offset: 0x80
	public int maxStoredIndex; //Field offset: 0x84
	public int numberOfGroups; //Field offset: 0x88
	public string volumeGuid; //Field offset: 0x90
	public string groupGuid; //Field offset: 0x98

	public int RuntimeAssetSize
	{
		 get { } //Length: 115
	}

	private static PerfectCullingVolumeBakeData() { }

	public PerfectCullingVolumeBakeData() { }

	[CompilerGenerated]
	internal static void <SetDataCompressed>g__AddValue|24_0(int value, List values) { }

	public virtual void CompleteBake() { }

	public virtual void DrawInspectorGUI() { }

	public int get_RuntimeAssetSize() { }

	public virtual ushort[] GetRawData(int index) { }

	public void MergeDownsample() { }

	public virtual void PrepareForBake(PerfectCullingBakingBehaviour bakingBehaviour) { }

	public virtual void SampleAtIndex(int index, List indices) { }

	public void SampleAtIndexFast(int index, FastArray indices) { }

	private void SetDataCompressed(int index, ushort[] indices) { }

	public virtual void SetRawData(int index, ushort[] indices) { }

	public virtual void SetRawData(int index, BakedIndexBuffer indices) { }

	public virtual void SetRawDataMT(int index, int* buffer, int count) { }

	public void SetVolumeBakeData(Vector3 cellSize, Vector3 cellCount) { }

}

