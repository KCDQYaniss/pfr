namespace Koenigz.PerfectCulling.EFT;

public sealed class CullingGridVisibilitySampler : IDisposable
{
	private struct TempRuntimeDecompress
	{
		public FastArray Indices; //Field offset: 0x0

		public void DecompressCallback(TemporaryCullingCellData cd) { }

	}

	[CompilerGenerated]
	private static CullingGridVisibilitySampler <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnCullingGridCreated; //Field offset: 0x8
	private PerfectCullingAdaptiveGrid _grid; //Field offset: 0x10
	private int _groupId; //Field offset: 0x18
	private IndexDataDecompressor _decompressor; //Field offset: 0x20
	private CullingGridPreProcess _preProc; //Field offset: 0x28
	private FastArray _tempIndices; //Field offset: 0x30

	public static event Action OnCullingGridCreated
	{
		[CompilerGenerated]
		 add { } //Length: 269
		[CompilerGenerated]
		 remove { } //Length: 269
	}

	public int GroupId
	{
		 get { } //Length: 4
	}

	public private static CullingGridVisibilitySampler Instance
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 151
	}

	public CullingGridPreProcess PreProc
	{
		 get { } //Length: 5
	}

	public Bounds[] VisibilityCells
	{
		 get { } //Length: 27
	}

	public CullingGridVisibilitySampler(PerfectCullingAdaptiveGrid grid, CullingGridPreProcess preProc) { }

	[CompilerGenerated]
	public static void add_OnCullingGridCreated(Action value) { }

	public override void Dispose() { }

	public int get_GroupId() { }

	[CompilerGenerated]
	public static CullingGridVisibilitySampler get_Instance() { }

	public CullingGridPreProcess get_PreProc() { }

	public Bounds[] get_VisibilityCells() { }

	public CullingGridVisibilityQueryResult Query(Vector3 point) { }

	[CompilerGenerated]
	public static void remove_OnCullingGridCreated(Action value) { }

	[CompilerGenerated]
	private static void set_Instance(CullingGridVisibilitySampler value) { }

	private void TryInitializeRuntime() { }

}

