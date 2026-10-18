namespace Koenigz.PerfectCulling.EFT;

public sealed class PerfectCullingDoorPreProcess : PerfectCullingCrossSceneGroupPreProcess
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetDoorBakeGroups>b__15_0(PerfectCullingCrossSceneContentDoors x, PerfectCullingCrossSceneContentDoors y) { }

	}

	[HideInInspector]
	[SerializeField]
	private GuidReference[] _doorContent; //Field offset: 0x20

	public IReadOnlyCollection DoorContent
	{
		 get { } //Length: 5
	}

	public PerfectCullingDoorPreProcess() { }

	public virtual PerfectCullingBakeGroup[] CollectBakeGroups() { }

	private void CollectDoorContent() { }

	public virtual BakeBatch[] CreateBakeBatches(PerfectCullingBakeGroup[] inputGroups) { }

	private static MeshRenderer CreateDoorProxy(WorldInteractiveObject doorObj) { }

	public virtual SharedOccluder GenerateSharedOccluder() { }

	public IReadOnlyCollection get_DoorContent() { }

	public virtual BakeBatch[] GetBakeBatches() { }

	public virtual int GetBakeHash() { }

	private PerfectCullingBakeGroup[] GetDoorBakeGroups() { }

	private static WorldInteractiveObject GetDoorInteractiveObject(PerfectCullingBakeGroup cullingGroup) { }

	private static Vector3 GetDoorSize(WorldInteractiveObject door) { }

	private static Bounds GetHierarchyBounds(Transform root) { }

	public virtual void OnEndContentCollect() { }

	public virtual PerfectCullingBakeGroup[] PrebakeTransform(BakeBatch batch, ICollection tempObjects, out Mode writeMode) { }

	public virtual PerfectCullingBakeGroup[] PrepareRuntimeContent() { }

}

