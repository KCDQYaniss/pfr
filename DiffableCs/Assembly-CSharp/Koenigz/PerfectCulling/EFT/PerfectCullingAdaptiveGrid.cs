namespace Koenigz.PerfectCulling.EFT;

public sealed class PerfectCullingAdaptiveGrid : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public PerfectCullingAdaptiveGrid <>4__this; //Field offset: 0x10
		public string filePath; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <RuntimeLoadExternalDataAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public PerfectCullingAdaptiveGrid <>4__this; //Field offset: 0x10
		public CancellationToken token; //Field offset: 0x18
		public IProgress progress; //Field offset: 0x20

		public <>c__DisplayClass33_0() { }

		internal void <InitializeSpatialTree>b__0() { }

	}

	[CompilerGenerated]
	private struct <InitializeGridAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PerfectCullingAdaptiveGrid <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public IProgress progress; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeSpatialTree>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PerfectCullingAdaptiveGrid <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public IProgress progress; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RuntimeLoadExternalDataAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PerfectCullingAdaptiveGrid <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private <>c__DisplayClass29_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static PerfectCullingAdaptiveGrid <Instance>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private PerfectCullingAdaptiveGridData _gridData; //Field offset: 0x20
	[SerializeField]
	private string _gridHash; //Field offset: 0x28
	private AdaptiveBVH _runtimeBVH; //Field offset: 0x30
	private List _runtimeGroupMapping; //Field offset: 0x38
	private PackedCullingGridData _packedData; //Field offset: 0x40
	private List _tempAdaptiveCells; //Field offset: 0x48
	private List _tempAdaptivePoints; //Field offset: 0x50
	private IndexDataDecompressor _indexDecompressor; //Field offset: 0x58

	public List AdaptiveCells
	{
		 get { } //Length: 27
	}

	public PerfectCullingAdaptiveGridData GridData
	{
		 get { } //Length: 5
	}

	public string GridHash
	{
		 get { } //Length: 5
	}

	public IndexDataDecompressor IndexDecompressor
	{
		 get { } //Length: 5
	}

	public private static PerfectCullingAdaptiveGrid Instance
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 151
	}

	public PackedCullingGridData PackedData
	{
		 get { } //Length: 5
	}

	public AdaptiveBVH RuntimeBVH
	{
		 get { } //Length: 76
	}

	public List RuntimeGroupMapping
	{
		 get { } //Length: 5
	}

	public PerfectCullingAdaptiveGrid() { }

	private void Awake() { }

	internal void DeinitializeGrid() { }

	public List get_AdaptiveCells() { }

	public PerfectCullingAdaptiveGridData get_GridData() { }

	public string get_GridHash() { }

	public IndexDataDecompressor get_IndexDecompressor() { }

	[CompilerGenerated]
	public static PerfectCullingAdaptiveGrid get_Instance() { }

	public PackedCullingGridData get_PackedData() { }

	public AdaptiveBVH get_RuntimeBVH() { }

	public List get_RuntimeGroupMapping() { }

	public int GetGroupIndex(GuidReference reference) { }

	[AsyncStateMachine(typeof(<InitializeGridAsync>d__28))]
	internal Task InitializeGridAsync(CancellationToken token, IProgress progress = null) { }

	private void InitializeGroupMapping() { }

	[AsyncStateMachine(typeof(<InitializeSpatialTree>d__33))]
	internal Task InitializeSpatialTree(CancellationToken token, IProgress progress = null) { }

	public AdaptiveBVH InitializeSpatialTreeFromGridData(CancellationToken token, IProgress progress = null) { }

	private AdaptiveBVH InitializeSpatialTreeFromPackedData(CancellationToken token, IProgress progress = null) { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<RuntimeLoadExternalDataAsync>d__29))]
	private Task RuntimeLoadExternalDataAsync(CancellationToken token, IProgress progress = null) { }

	[CompilerGenerated]
	private static void set_Instance(PerfectCullingAdaptiveGrid value) { }

}

