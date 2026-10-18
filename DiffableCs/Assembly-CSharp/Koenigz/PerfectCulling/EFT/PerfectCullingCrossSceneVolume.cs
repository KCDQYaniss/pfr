namespace Koenigz.PerfectCulling.EFT;

public sealed class PerfectCullingCrossSceneVolume : PerfectCullingBakingBehaviour, IVolumeDataProvider, IResizableByHandle
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public GuidReference groupId; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <GetBakeDescriptor>b__0(BakeDescriptor x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public string groupId; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <GetBakeDescriptor>b__0(BakeDescriptor x) { }

	}

	[CompilerGenerated]
	private sealed class <GetSamplingPositionsEnum>d__63 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Nullable <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x24
		public PerfectCullingCrossSceneVolume <>4__this; //Field offset: 0x28
		private Vector3 cellSize; //Field offset: 0x30
		public Vector3 <>3__cellSize; //Field offset: 0x3C
		private Space space; //Field offset: 0x48
		public Space <>3__space; //Field offset: 0x4C
		private int <cellCount>5__2; //Field offset: 0x50
		private int <rawIndexCell>5__3; //Field offset: 0x54

		private override Nullable System.Collections.Generic.IEnumerator<UnityEngine.Vector3?>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 74
		}

		[DebuggerHidden]
		public <GetSamplingPositionsEnum>d__63(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<UnityEngine.Vector3?>.GetEnumerator() { }

		[DebuggerHidden]
		private override Nullable System.Collections.Generic.IEnumerator<UnityEngine.Vector3?>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class BakeDescriptor
	{
		internal enum LoadMode
		{
			Memory = 0,
			Stream = 1,
			AdaptiveGrid = 2,
		}

		public GuidReference crossSceneGroup; //Field offset: 0x10
		public int bakeCellSizeType; //Field offset: 0x18
		public int mergeIterations; //Field offset: 0x1C
		public StreamingVolumeBakeDataIndex streamingBakeData; //Field offset: 0x20
		public bool debugSamplingPoints; //Field offset: 0x28
		public LoadMode loadMode; //Field offset: 0x2C

		public Vector3 bakeCellSize
		{
			 get { } //Length: 244
		}

		public BakeDescriptor() { }

		public Vector3 get_bakeCellSize() { }

		public List GetAdditionalOccluders() { }

		public PerfectCullingCrossSceneGroup GetGroup() { }

		public void ValidateDescriptor() { }

	}

	internal sealed class RuntimeCrossGroupVolume
	{
		internal enum EUpdateResult
		{
			OutOfBounds = 0,
			Ok = 1,
			NoData = 2,
		}

		public PerfectCullingCrossSceneGroup group; //Field offset: 0x10
		public int groupIndex; //Field offset: 0x18
		public StreamingVolumeBakeDataIndex volumeBakeData; //Field offset: 0x20
		public Vector3[] visibilityOffsets; //Field offset: 0x28
		public Vector3 volumeSize; //Field offset: 0x30
		public Vector3 volumePosition; //Field offset: 0x3C
		public Quaternion volumeRotation; //Field offset: 0x48
		public string volumeName; //Field offset: 0x58
		public Bounds runtimeBounds; //Field offset: 0x60
		public int lastCellIndex; //Field offset: 0x78
		public float reuseDistance2; //Field offset: 0x7C
		public object lockSampleQueue; //Field offset: 0x80
		public object lockRemoveCells; //Field offset: 0x88
		public object lockReuse; //Field offset: 0x90
		public StreamingVolumeBakeDataGrid streamer; //Field offset: 0x98
		public ExcludeInnerVolumeSamplingProvider excludeInnerVolumeSamplingProvider; //Field offset: 0xA0
		public Dictionary syncSamples; //Field offset: 0xA8
		public string parentVolumeName; //Field offset: 0xB0
		public string groupName; //Field offset: 0xB8
		public Vector3 runtimeCellCount; //Field offset: 0xC0

		public bool IsFineVolume
		{
			 get { } //Length: 205
		}

		public RuntimeCrossGroupVolume(BakeDescriptor desc, PerfectCullingCrossSceneVolume parentVolume) { }

		public bool get_IsFineVolume() { }

		public int GetIndexForWorldPosMT(Vector3 pos, out bool isOutOfBounds) { }

		public int GetIndexForWorldPosMT(Vector3 pos, Vector3 cellCount, Vector3 cellSize, out bool isOutOfBounds) { }

		public int GetIndexForWorldPosNoOrientationMT(Vector3 pos, out bool isOutOfBounds) { }

		public FastArray GetPrecomputedIndices(int index) { }

		public Vector3 GetSamplingPositionAtMT(int index) { }

		private void UpdateVisibilityMT(FastArray indices, int newCounter) { }

		public EUpdateResult UpdateVisibleRenderersAtPointMT(Vector3 pos, int newCounter) { }

	}

	public static readonly float[] BAKE_CELL_SIZES; //Field offset: 0x0
	public const int MAX_RUNTIME_VOLUMES = 4096; //Field offset: 0x0
	public static readonly string[] BAKE_CELL_DISPLAY_VALUES; //Field offset: 0x8
	public static readonly string[] BAKE_CELL_DISPLAY_FILTER_VALUES; //Field offset: 0x10
	public static readonly string[] LOAD_MODES; //Field offset: 0x18
	private static readonly Color CULL_VOLUME_BOX_COLOR; //Field offset: 0x20
	public static readonly List AllRuntimeCrossGroupVolumes; //Field offset: 0x30
	private static readonly List _AllCrossSceneVolumes; //Field offset: 0x38
	private static List _scheduledBakeIds; //Field offset: 0x40
	private static BakeDescriptor _currentBakeDescriptor; //Field offset: 0x48
	private List _localVolumes; //Field offset: 0x48
	[SerializeField]
	private string _volumeGuid; //Field offset: 0x50
	[SerializeField]
	public Vector3 volumeSize; //Field offset: 0x58
	public Bounds runtimeVolumeBounds; //Field offset: 0x64
	[SerializeField]
	public List bakeDescriptors; //Field offset: 0x80

	public static BakeDescriptor ActiveBakeDescriptor
	{
		 get { } //Length: 84
	}

	public virtual List additionalOccluders
	{
		 get { } //Length: 100
		 set { } //Length: 62
	}

	public static IReadOnlyCollection AllCrossSceneVolumes
	{
		 get { } //Length: 84
	}

	public virtual PerfectCullingBakeData BakeData
	{
		 get { } //Length: 30
	}

	public virtual PerfectCullingBakeGroup[] bakeGroups
	{
		 get { } //Length: 110
		 set { } //Length: 62
	}

	public int CellCount
	{
		 get { } //Length: 237
	}

	public override Vector3 HandleSized
	{
		 get { } //Length: 81
		 set { } //Length: 310
	}

	public bool IsFineVolume
	{
		 get { } //Length: 233
	}

	public float MaxCellSize
	{
		 get { } //Length: 532
	}

	public override Vector3 SizeOfVolume
	{
		 get { } //Length: 19
	}

	[SerializeField]
	public Bounds volumeBakeBounds
	{
		 get { } //Length: 274
		 set { } //Length: 284
	}

	public PerfectCullingVolumeBakeData volumeBakeData
	{
		 get { } //Length: 30
	}

	public override string VolumeGuid
	{
		 get { } //Length: 5
	}

	private static PerfectCullingCrossSceneVolume() { }

	public PerfectCullingCrossSceneVolume() { }

	public BakeDescriptor AddBakeDescriptor() { }

	protected virtual void CullAdditionalOccluders(ref HashSet additionalOccluders) { }

	public void FixVolumeSize() { }

	public static BakeDescriptor get_ActiveBakeDescriptor() { }

	public virtual List get_additionalOccluders() { }

	public static IReadOnlyCollection get_AllCrossSceneVolumes() { }

	public virtual PerfectCullingBakeData get_BakeData() { }

	public virtual PerfectCullingBakeGroup[] get_bakeGroups() { }

	public int get_CellCount() { }

	public override Vector3 get_HandleSized() { }

	public bool get_IsFineVolume() { }

	public float get_MaxCellSize() { }

	public override Vector3 get_SizeOfVolume() { }

	public Bounds get_volumeBakeBounds() { }

	public PerfectCullingVolumeBakeData get_volumeBakeData() { }

	public override string get_VolumeGuid() { }

	internal List GetActiveSamplingPositions(Vector3 overrideBakeCellSize, Space space = 0, int maxPoints = 0) { }

	public BakeDescriptor GetBakeDescriptor(PerfectCullingCrossSceneGroup group) { }

	public BakeDescriptor GetBakeDescriptor(string groupId) { }

	public BakeDescriptor GetBakeDescriptor(GuidReference groupId) { }

	public virtual int GetBakeHash() { }

	public static int GetFrameHashNoOrientation(Vector3 pos, FastArray runtimeVolumesToUpdate = null, FastArray runtimeGroupsToUpdate = null) { }

	public virtual int GetIndexForWorldPos(Vector3 worldPos, out bool isOutOfBounds) { }

	public override Vector3 GetSamplingPositionAt(int index, Vector3 cellSize, Space space = 1) { }

	public Vector3 GetSamplingPositionAt(int index, Vector3 gridSize, Vector3 cellSize, Space space = 1) { }

	public static Vector3 GetSamplingPositionAtMT(int index, Vector3 cellSize, Vector3 volumeSize, Vector3 volumePosition, Quaternion volumeRotation, Space space = 1) { }

	public virtual List GetSamplingPositions(Space space = 1) { }

	public List GetSamplingPositions(Vector3 cellSize, Space space = 1) { }

	[IteratorStateMachine(typeof(<GetSamplingPositionsEnum>d__63))]
	public IEnumerable GetSamplingPositionsEnum(Vector3 cellSize, Space space = 1) { }

	public override List GetSamplingProviders() { }

	public override IReadOnlyCollection GetUniqueBakeCellSizes() { }

	public virtual Vector3 GetWorldPositionForIndex(int index) { }

	public bool HasGroup(PerfectCullingCrossSceneGroup group) { }

	public virtual void InitializeBake() { }

	internal void InitializeVolume() { }

	private void OnDestroy() { }

	public virtual void PostBake() { }

	public virtual void PostProcessBakeData(PerfectCullingBakeData data) { }

	public virtual bool PreBake() { }

	public void RemoteForceBakeSingle(int bakeDescId) { }

	public void ReplaceGroups(List newGroups) { }

	public void ScheduleBake(List bakeDescriptors, bool forceBakeAllNow = true) { }

	public virtual void set_additionalOccluders(List value) { }

	public virtual void set_bakeGroups(PerfectCullingBakeGroup[] value) { }

	public override void set_HandleSized(Vector3 value) { }

	public void set_volumeBakeBounds(Bounds value) { }

	public virtual void SetBakeData(PerfectCullingBakeData bakeData) { }

	internal void ShutdownVolume() { }

	public virtual void Start() { }

	public static Vector3 ToBakeCellSize(int type) { }

}

