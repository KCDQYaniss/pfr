namespace Koenigz.PerfectCulling.EFT;

[DisallowMultipleComponent]
public sealed class CrossSceneCullingGroupPreProcess : PerfectCullingCrossSceneGroupPreProcess
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetBakeGroups>b__15_0(PerfectCullingCrossSceneContentMeshes x, PerfectCullingCrossSceneContentMeshes y) { }

	}

	[SerializeField]
	private int _numBakeGroups; //Field offset: 0x20
	[SerializeField]
	private GuidReference[] _cullingGroups; //Field offset: 0x28
	[SerializeField]
	private int _bakeHash; //Field offset: 0x30

	public GuidReference[] CullingGroups
	{
		 get { } //Length: 5
	}

	public CrossSceneCullingGroupPreProcess() { }

	public virtual PerfectCullingBakeGroup[] CollectBakeGroups() { }

	private void CollectContent() { }

	public bool Contains(GuidReference guid) { }

	public virtual BakeBatch[] CreateBakeBatches(PerfectCullingBakeGroup[] inputGroups) { }

	public virtual SharedOccluder GenerateSharedOccluder() { }

	public GuidReference[] get_CullingGroups() { }

	public virtual BakeBatch[] GetBakeBatches() { }

	public PerfectCullingBakeGroup[] GetBakeGroups() { }

	public virtual int GetBakeHash() { }

	public virtual LODGroup[] GetLODGroups() { }

	public virtual void OnEndContentCollect() { }

	public virtual PerfectCullingBakeGroup[] PrepareRuntimeContent() { }

	internal void SetCullingGroups(GuidReference[] newCullingGroups) { }

}

