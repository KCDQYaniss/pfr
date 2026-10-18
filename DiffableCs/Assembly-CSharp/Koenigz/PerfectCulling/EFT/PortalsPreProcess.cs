namespace Koenigz.PerfectCulling.EFT;

public sealed class PortalsPreProcess : PerfectCullingCrossSceneGroupPreProcess
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetBakeGroups>b__9_0(CrossSceneContentPortals x, CrossSceneContentPortals y) { }

	}

	public static readonly LODGroup[] EMPTY_LOD_GROUPS; //Field offset: 0x0
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

	private static PortalsPreProcess() { }

	public PortalsPreProcess() { }

	public GuidReference[] get_CullingGroups() { }

	public PerfectCullingBakeGroup[] GetBakeGroups() { }

	public virtual int GetBakeHash() { }

	public virtual LODGroup[] GetLODGroups() { }

	public virtual PerfectCullingBakeGroup[] PrepareRuntimeContent() { }

}

